using System;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace zNevis
{
   class MPlayerController
   {
      #region Fields
      Process _p = null;
      bool _isIdentifying = false;
      Regex _idTagRegex = new Regex(@"ID_(?<tag>[A-Z_\d]+)=(?<value>[A-Z\d\.:\\]+)");
      Dictionary<string, string> _mediaIdDict = new Dictionary<string, string>();
      #endregion

      #region Properties
      public string FileName { set; get; }
      #endregion

      #region Events
      public delegate void OnDataReceived(string s);
      public event OnDataReceived OnOutputReceived;
      public event OnDataReceived OnErrorReceived;

      public delegate void NumericIdNotifire(double length);
      public event NumericIdNotifire VideoLengthChanged;
      #endregion

      public MPlayerController(string wid)
      {
         _p = new Process();
         _p.StartInfo.FileName = "mplayer.exe";
         _p.StartInfo.Arguments = @"-slave -idle -identify -osdlevel 0 -noconfig all -noautosub -nocookies -noborder -ass -wid " + wid;
         _p.StartInfo.CreateNoWindow = true;
         _p.StartInfo.UseShellExecute = false;
         _p.StartInfo.RedirectStandardInput = true;
         _p.StartInfo.RedirectStandardOutput = true;
         _p.StartInfo.RedirectStandardError = true;
         _p.OutputDataReceived += ReadStdOut;
         _p.ErrorDataReceived += ReadStdErr;
         _p.Start();
         _p.BeginErrorReadLine();
         _p.BeginOutputReadLine();
      }

      public void PlayPause()
      {
         _p.StandardInput.Write("p\n");
      }

      /// <summary>
      /// Loads file from path into the mplayer and starts playing
      /// </summary>
      /// <param name="path"></param>
      public void LoadFile(string path)
      {
         if (!File.Exists(path))
            return;
         string command = string.Format("pausing_keep_force loadfile \"{0}\" 0\n", path.Replace(@"\", @"\\"));
         _isIdentifying = true;
         _p.StandardInput.Write(command);
      }

      private async void ReadStdOut(object sender, DataReceivedEventArgs e)
      {
         if (_isIdentifying)
         {
            if (e.Data.ToUpper().Contains("ID_PAUSED"))
            {
               _isIdentifying = false;
               foreach (var x in _mediaIdDict)
               {
                  System.Console.WriteLine(x);
               }
               VideoLengthChanged(Convert.ToDouble(_mediaIdDict["length"]));
            }
            else
            {
               foreach (Match match in _idTagRegex.Matches(e.Data.ToUpper()))
               {
                  GroupCollection groups = match.Groups;
                  System.Console.ForegroundColor = System.ConsoleColor.Green;
                  System.Console.WriteLine(string.Format("{0}::{1}", groups[1].Value, groups[2].Value));
                  _mediaIdDict[groups[1].Value.ToLower()] = groups[2].Value;
                  System.Console.ResetColor();
                  //return;
               }
            }

         }

         await Task.Factory.StartNew(() => { OnOutputReceived(e.Data); });
      }

      private async void ReadStdErr(object sender, DataReceivedEventArgs e)
      {
         await Task.Factory.StartNew(() => { OnErrorReceived(e.Data); });
      }

   }
}
