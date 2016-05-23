namespace zNevis
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.newToolButton = new System.Windows.Forms.ToolStripButton();
         this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
         this.panel1 = new System.Windows.Forms.Panel();
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.trackBar1 = new System.Windows.Forms.TrackBar();
         this.trackBar2 = new System.Windows.Forms.TrackBar();
         this.mplayerPanel = new System.Windows.Forms.Panel();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabSubtitle = new System.Windows.Forms.TabPage();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel1.SuspendLayout();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         this.toolStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.flowLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
         this.tabControl1.SuspendLayout();
         this.tabSubtitle.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
         this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
         this.splitContainer1.Size = new System.Drawing.Size(846, 546);
         this.splitContainer1.SplitterDistance = 275;
         this.splitContainer1.TabIndex = 0;
         // 
         // splitContainer2
         // 
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.Location = new System.Drawing.Point(0, 0);
         this.splitContainer2.Name = "splitContainer2";
         // 
         // splitContainer2.Panel1
         // 
         this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
         this.splitContainer2.Panel2.Controls.Add(this.panel1);
         this.splitContainer2.Size = new System.Drawing.Size(846, 275);
         this.splitContainer2.SplitterDistance = 282;
         this.splitContainer2.TabIndex = 0;
         // 
         // toolStrip1
         // 
         this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolButton,
            this.openToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton,
            this.saveToolStripButton});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(24, 275);
         this.toolStrip1.TabIndex = 2;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // newToolButton
         // 
         this.newToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.newToolButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolButton.Image")));
         this.newToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.newToolButton.Name = "newToolButton";
         this.newToolButton.Size = new System.Drawing.Size(21, 20);
         this.newToolButton.Text = "&New";
         this.newToolButton.Click += new System.EventHandler(this.newToolButton_Click);
         // 
         // openToolStripButton
         // 
         this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
         this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.openToolStripButton.Name = "openToolStripButton";
         this.openToolStripButton.Size = new System.Drawing.Size(21, 20);
         this.openToolStripButton.Text = "&Open";
         this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
         // 
         // printToolStripButton
         // 
         this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
         this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.printToolStripButton.Name = "printToolStripButton";
         this.printToolStripButton.Size = new System.Drawing.Size(21, 20);
         this.printToolStripButton.Text = "&Print";
         // 
         // toolStripSeparator
         // 
         this.toolStripSeparator.Name = "toolStripSeparator";
         this.toolStripSeparator.Size = new System.Drawing.Size(21, 6);
         // 
         // cutToolStripButton
         // 
         this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
         this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.cutToolStripButton.Name = "cutToolStripButton";
         this.cutToolStripButton.Size = new System.Drawing.Size(21, 20);
         this.cutToolStripButton.Text = "C&ut";
         // 
         // copyToolStripButton
         // 
         this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
         this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.copyToolStripButton.Name = "copyToolStripButton";
         this.copyToolStripButton.Size = new System.Drawing.Size(21, 20);
         this.copyToolStripButton.Text = "&Copy";
         // 
         // pasteToolStripButton
         // 
         this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
         this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.pasteToolStripButton.Name = "pasteToolStripButton";
         this.pasteToolStripButton.Size = new System.Drawing.Size(21, 20);
         this.pasteToolStripButton.Text = "&Paste";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(21, 6);
         // 
         // helpToolStripButton
         // 
         this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
         this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.helpToolStripButton.Name = "helpToolStripButton";
         this.helpToolStripButton.Size = new System.Drawing.Size(21, 20);
         this.helpToolStripButton.Text = "He&lp";
         // 
         // saveToolStripButton
         // 
         this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
         this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.saveToolStripButton.Name = "saveToolStripButton";
         this.saveToolStripButton.Size = new System.Drawing.Size(21, 20);
         this.saveToolStripButton.Text = "&Save";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.flowLayoutPanel1);
         this.panel1.Controls.Add(this.trackBar2);
         this.panel1.Controls.Add(this.mplayerPanel);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(560, 275);
         this.panel1.TabIndex = 0;
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Controls.Add(this.trackBar1);
         this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 233);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Size = new System.Drawing.Size(515, 42);
         this.flowLayoutPanel1.TabIndex = 2;
         // 
         // trackBar1
         // 
         this.trackBar1.Location = new System.Drawing.Point(3, 3);
         this.trackBar1.Name = "trackBar1";
         this.trackBar1.Size = new System.Drawing.Size(506, 45);
         this.trackBar1.TabIndex = 0;
         // 
         // trackBar2
         // 
         this.trackBar2.Dock = System.Windows.Forms.DockStyle.Right;
         this.trackBar2.Location = new System.Drawing.Point(515, 0);
         this.trackBar2.Name = "trackBar2";
         this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
         this.trackBar2.Size = new System.Drawing.Size(45, 275);
         this.trackBar2.TabIndex = 1;
         // 
         // mplayerPanel
         // 
         this.mplayerPanel.BackColor = System.Drawing.Color.Black;
         this.mplayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mplayerPanel.Location = new System.Drawing.Point(0, 0);
         this.mplayerPanel.Name = "mplayerPanel";
         this.mplayerPanel.Size = new System.Drawing.Size(560, 275);
         this.mplayerPanel.TabIndex = 0;
         this.mplayerPanel.Click += new System.EventHandler(this.mplayerPanel_Click);
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabSubtitle);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.Location = new System.Drawing.Point(0, 0);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(846, 267);
         this.tabControl1.TabIndex = 0;
         // 
         // tabSubtitle
         // 
         this.tabSubtitle.Controls.Add(this.dataGridView1);
         this.tabSubtitle.Location = new System.Drawing.Point(4, 22);
         this.tabSubtitle.Name = "tabSubtitle";
         this.tabSubtitle.Padding = new System.Windows.Forms.Padding(3);
         this.tabSubtitle.Size = new System.Drawing.Size(838, 241);
         this.tabSubtitle.TabIndex = 1;
         this.tabSubtitle.Text = "Subtitle";
         this.tabSubtitle.UseVisualStyleBackColor = true;
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
         this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridView1.Location = new System.Drawing.Point(3, 3);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(832, 235);
         this.dataGridView1.TabIndex = 0;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Column1";
         this.Column1.Name = "Column1";
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Column2";
         this.Column2.Name = "Column2";
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Column3";
         this.Column3.Name = "Column3";
         // 
         // statusStrip1
         // 
         this.statusStrip1.Location = new System.Drawing.Point(0, 524);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(846, 22);
         this.statusStrip1.TabIndex = 1;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(846, 546);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.splitContainer1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
         this.Load += new System.EventHandler(this.Form1_Load);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.splitContainer2.Panel1.ResumeLayout(false);
         this.splitContainer2.Panel1.PerformLayout();
         this.splitContainer2.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.flowLayoutPanel1.ResumeLayout(false);
         this.flowLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
         this.tabControl1.ResumeLayout(false);
         this.tabSubtitle.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.SplitContainer splitContainer2;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.TrackBar trackBar2;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabSubtitle;
      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton newToolButton;
      private System.Windows.Forms.ToolStripButton openToolStripButton;
      private System.Windows.Forms.ToolStripButton printToolStripButton;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
      private System.Windows.Forms.ToolStripButton cutToolStripButton;
      private System.Windows.Forms.ToolStripButton copyToolStripButton;
      private System.Windows.Forms.ToolStripButton pasteToolStripButton;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripButton helpToolStripButton;
      private System.Windows.Forms.ToolStripButton saveToolStripButton;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel mplayerPanel;
      private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
   }
}

