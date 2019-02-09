namespace mBible
{
    partial class DdProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DdProject));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lineDown = new System.Windows.Forms.Label();
            this.lineTop = new System.Windows.Forms.Label();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.tblBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lblVerse = new System.Windows.Forms.Label();
            this.lblSongLabel = new System.Windows.Forms.Label();
            this.lblSongno = new System.Windows.Forms.Label();
            this.lblSongText = new System.Windows.Forms.Label();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tmrLinerr = new System.Windows.Forms.Timer(this.components);
            this.tblMain.SuspendLayout();
            this.tblBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lineDown, 0, 3);
            this.tblMain.Controls.Add(this.lineTop, 0, 1);
            this.tblMain.Controls.Add(this.lblSongTitle, 0, 0);
            this.tblMain.Controls.Add(this.tblBottom, 0, 4);
            this.tblMain.Controls.Add(this.lblSongText, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.ForeColor = System.Drawing.Color.White;
            this.tblMain.Location = new System.Drawing.Point(10, 10);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 5;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.Size = new System.Drawing.Size(1000, 562);
            this.tblMain.TabIndex = 2;
            this.tblMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tblMain_Paint);
            // 
            // lineDown
            // 
            this.lineDown.AutoSize = true;
            this.lineDown.BackColor = System.Drawing.Color.White;
            this.lineDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineDown.Location = new System.Drawing.Point(3, 519);
            this.lineDown.Name = "lineDown";
            this.lineDown.Size = new System.Drawing.Size(994, 3);
            this.lineDown.TabIndex = 2;
            this.lineDown.Text = "...";
            this.lineDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lineDown.Click += new System.EventHandler(this.lineDown_Click);
            // 
            // lineTop
            // 
            this.lineTop.AutoSize = true;
            this.lineTop.BackColor = System.Drawing.Color.White;
            this.lineTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineTop.Location = new System.Drawing.Point(3, 50);
            this.lineTop.Name = "lineTop";
            this.lineTop.Size = new System.Drawing.Size(994, 3);
            this.lineTop.TabIndex = 1;
            this.lineTop.Text = "...";
            this.lineTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lineTop.Click += new System.EventHandler(this.lineTop_Click);
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSongTitle.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTitle.ForeColor = System.Drawing.Color.White;
            this.lblSongTitle.Location = new System.Drawing.Point(3, 0);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(994, 50);
            this.lblSongTitle.TabIndex = 4;
            this.lblSongTitle.Text = "Song Title";
            this.lblSongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSongTitle.Click += new System.EventHandler(this.lblSongTitle_Click);
            // 
            // tblBottom
            // 
            this.tblBottom.ColumnCount = 6;
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblBottom.Controls.Add(this.lblVerse, 3, 0);
            this.tblBottom.Controls.Add(this.txtCommandLine, 2, 0);
            this.tblBottom.Controls.Add(this.lblSongLabel, 0, 0);
            this.tblBottom.Controls.Add(this.lblSongno, 1, 0);
            this.tblBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBottom.Location = new System.Drawing.Point(3, 525);
            this.tblBottom.Name = "tblBottom";
            this.tblBottom.RowCount = 1;
            this.tblBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBottom.Size = new System.Drawing.Size(994, 34);
            this.tblBottom.TabIndex = 3;
            this.tblBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.tblBottom_Paint);
            // 
            // lblVerse
            // 
            this.lblVerse.AutoSize = true;
            this.lblVerse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVerse.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerse.ForeColor = System.Drawing.Color.White;
            this.lblVerse.Location = new System.Drawing.Point(717, 0);
            this.lblVerse.Name = "lblVerse";
            this.lblVerse.Size = new System.Drawing.Size(194, 34);
            this.lblVerse.TabIndex = 8;
            this.lblVerse.Text = "Verse 1";
            this.lblVerse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVerse.Visible = false;
            this.lblVerse.Click += new System.EventHandler(this.lblVerse_Click);
            // 
            // lblSongLabel
            // 
            this.lblSongLabel.AutoSize = true;
            this.lblSongLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSongLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongLabel.ForeColor = System.Drawing.Color.White;
            this.lblSongLabel.Location = new System.Drawing.Point(3, 0);
            this.lblSongLabel.Name = "lblSongLabel";
            this.lblSongLabel.Size = new System.Drawing.Size(94, 34);
            this.lblSongLabel.TabIndex = 6;
            this.lblSongLabel.Text = "Song";
            this.lblSongLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSongLabel.Click += new System.EventHandler(this.lblSongLabel_Click);
            // 
            // lblSongno
            // 
            this.lblSongno.AutoSize = true;
            this.lblSongno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSongno.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongno.ForeColor = System.Drawing.Color.White;
            this.lblSongno.Location = new System.Drawing.Point(103, 0);
            this.lblSongno.Name = "lblSongno";
            this.lblSongno.Size = new System.Drawing.Size(94, 34);
            this.lblSongno.TabIndex = 7;
            this.lblSongno.Text = "#01";
            this.lblSongno.Click += new System.EventHandler(this.lblSongno_Click);
            // 
            // lblSongText
            // 
            this.lblSongText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSongText.AutoSize = true;
            this.lblSongText.Location = new System.Drawing.Point(405, 53);
            this.lblSongText.Name = "lblSongText";
            this.lblSongText.Size = new System.Drawing.Size(189, 466);
            this.lblSongText.TabIndex = 5;
            this.lblSongText.Text = "Amazing Grace, how sweet the sound,\r\nThat saved a wretch like me,\r\nI once was los" +
    "t but now am found,\r\nWas blind but now I see.";
            this.lblSongText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Location = new System.Drawing.Point(203, 3);
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(225, 20);
            this.txtCommandLine.TabIndex = 0;
            this.txtCommandLine.Visible = false;
            this.txtCommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommandLine_KeyDown);
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 60000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // tmrLinerr
            // 
            this.tmrLinerr.Interval = 3000;
            this.tmrLinerr.Tick += new System.EventHandler(this.tmrLinerr_Tick);
            // 
            // DdProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1020, 582);
            this.ControlBox = false;
            this.Controls.Add(this.tblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DdProject";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DdProject_Load);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblBottom.ResumeLayout(false);
            this.tblBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lineDown;
        private System.Windows.Forms.Label lineTop;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.TableLayoutPanel tblBottom;
        private System.Windows.Forms.Label lblVerse;
        private System.Windows.Forms.Label lblSongLabel;
        private System.Windows.Forms.Label lblSongno;
        private System.Windows.Forms.Timer tmrLinerr;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Label lblSongText;
    }
}