using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zNevis
{
   class SrtSubtitle
   {
      #region fields
      List<SrtSubtitleLine> _lines;
      #endregion

      #region Properties
      public string FileName { protected set; get; }
      public bool AutoSaveToFile { set; get; }
      public SrtSubtitleLine this[int line]
      {
         get
         {
            return _lines[line];
         }
         set
         {
            _lines[line] = value;
         }
      }
      #endregion

      /// <summary>
      /// Creates and returns a new SrtSubtitle from file
      /// </summary>
      /// <param name="file">Address to a SRT subtitle file</param>
      /// <returns>SrtSubtitle object if Read was successful otherwise returns null</returns>
      public static SrtSubtitle CreateFrom(string file)
      {
         //if file exists
         var srt = new SrtSubtitle();
         srt.FileName = file;
         if (srt.Read())
            return srt;
         else
            return null;
      }

      /// <summary>
      /// Creates a new SRT subtitle in file path containing one empty line
      /// </summary>
      /// <param name="filePath">Address to the new SRT subtitle file</param>
      /// <param name="overwrite">Wether overwrite if file exists</param>
      /// <returns>SrtSubtitle object if was successfully created otherwise returns null</returns>
      public static SrtSubtitle CreateNew(string filePath, bool overwrite)
      {
         if (File.Exists(filePath) && !overwrite)
         {
            return null;
         }
         // check for the SRT ending of the file

         using (var fileStream = File.Create(filePath))
         {
            string text = "1\n" +
                        //"00:00:00.000 --> 00:00:00.000\n" +
                        "\n";
            byte[] bytes = new UTF8Encoding(true).GetBytes(text);
            fileStream.Write(bytes, 0, bytes.Length);
         }
         
         var srt = new SrtSubtitle();
         srt.FileName = filePath;
         srt._lines = new List<SrtSubtitleLine>(10);
         srt._lines.Add(new SrtSubtitleLine() { Text = "", ShowTime = "0", HideTime = "0" });
         return srt;
      }

      public bool Read(string file = null)
      {
         if (string.IsNullOrEmpty(file) || string.IsNullOrWhiteSpace(file))
         {
            //file = this.FileName;
            return false;
         }
         // read the file into _lines list
         return true;
      }

   }
}
