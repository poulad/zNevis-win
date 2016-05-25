using System.Threading.Tasks;
using System.Diagnostics;

namespace zNevis
{
   class MPlayerController
   {
      #region Fields
      Process _p = null;
      #endregion

      #region Properties
      public string FileName { set; get; }
      #endregion

      #region Events
      public delegate void OnDataReceived(string s);
      public event OnDataReceived OnOutputReceived;
      #endregion

      public MPlayerController(string wid)
      {
         _p = new Process();
         _p.StartInfo.FileName = "mplayer.exe";
         //p.StartInfo.Arguments = "-slave -idle -osdlevel 0 -noconfig all -noautosub -nocookies -noborder -ass -wid " + mplayerPanel.Handle.ToString() + " \"" + fileName + "\"";
         _p.StartInfo.Arguments = @"-slave -wid " + wid + @" C:\mplayer\movie.mp4";
         _p.StartInfo.CreateNoWindow = true;
         _p.StartInfo.UseShellExecute = false;
         _p.StartInfo.RedirectStandardInput = true;
         _p.StartInfo.RedirectStandardOutput = true;
         _p.StartInfo.RedirectStandardError = true;
         _p.OutputDataReceived += _p_OutputDataReceived;
         _p.Start();
         _p.BeginErrorReadLine();
         _p.BeginOutputReadLine();

      }

      private async void _p_OutputDataReceived(object sender, DataReceivedEventArgs e)
      {
         await Task.Factory.StartNew(() => { OnOutputReceived(e.Data); });
      }

      public void PlayPause()
      {
         if (_p == null)
            return;
         _p.StandardInput.Write("p\n");
      }


   }
}
