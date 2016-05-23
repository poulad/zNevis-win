using System;
using System.ComponentModel;
using System.Windows.Forms;


using System.Diagnostics;

namespace zNevis
{
   public partial class Form1 : Form
   {
      #region fields
      string fileName;
      Process p = null;
      SrtSubtitle srt;
      #endregion
      public Form1()
      {
         InitializeComponent();
      }


      private void Form1_Load(object sender, EventArgs e)
      {
         Console.WriteLine(IsHandleCreated);
         Console.WriteLine(Handle.ToString());
         Console.WriteLine(splitContainer2.Panel2.Handle.ToInt64());
      }

      private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
      {

      }
      
      private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
      {

      }

      private void openToolStripButton_Click(object sender, EventArgs e)
      {
         if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
         {
            fileName = openFileDialog1.FileName;
            Play();
         }
      }

      void Play()
      {
         /*
          * << "-slave"
            << "-idle"
            << "-osdlevel" << "0"
            << "-noconfig" << "all"
            << "-noautosub"
            << "-nocookies"
            << "-noborder"
            << "-ass"
            << "-wid" << QString::number(parent->winId())
          */
         if (p == null)
         {
            p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "mplayer";
         }
         else if (!p.HasExited)
         {
            p.Kill();
         }
         p.StartInfo.Arguments = "-slave -quiet -idle -osdlevel 0 -noconfig all -noautosub -nocookies -noborder -ass -wid " + mplayerPanel.Handle.ToString() + " \"" + fileName + "\"";
         Console.WriteLine(p.StartInfo.FileName + " " + p.StartInfo.Arguments);
         p.Start();
         p.StandardInput.AutoFlush = true;
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (p == null)
            return;
         p.Kill();
         p.Dispose();
      }

      private void mplayerPanel_Paint(object sender, PaintEventArgs e)
      {
      }

      private void mplayerPanel_Click(object sender, EventArgs e)
      {
         p.StandardInput.Write("p\n");
      }

      private void newToolButton_Click(object sender, EventArgs e)
      {
         var sfd = new SaveFileDialog();
         if (sfd.ShowDialog() != DialogResult.OK)
            return;
         srt = SrtSubtitle.CreateNew(sfd.FileName, false);
      }
   }
}
