namespace mBible
{
    partial class CcBibleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CcBibleView));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tblLeft = new System.Windows.Forms.TableLayoutPanel();
            this.grpCriteria = new System.Windows.Forms.GroupBox();
            this.btnSearchAll = new JacksiroCtrl.JsSwitch();
            this.lblSearchAll = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.grpSongResults = new System.Windows.Forms.GroupBox();
            this.lstSongResults = new System.Windows.Forms.ListBox();
            this.lstBookcodes = new System.Windows.Forms.ListBox();
            this.lstSongids = new System.Windows.Forms.ListBox();
            this.tblRight = new System.Windows.Forms.TableLayoutPanel();
            this.txtSongContent = new System.Windows.Forms.TextBox();
            this.ToolStripSong = new System.Windows.Forms.ToolStrip();
            this.tsbtnProject = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnLast = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBigger = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSmaller = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFont = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSelect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPrint = new System.Windows.Forms.ToolStripButton();
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new JacksiroCtrl.JsButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.tmrTimerWait = new System.Windows.Forms.Timer(this.components);
            this.jsFeedback = new JacksiroCtrl.JsFeedback();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tblLeft.SuspendLayout();
            this.grpCriteria.SuspendLayout();
            this.grpSongResults.SuspendLayout();
            this.tblRight.SuspendLayout();
            this.ToolStripSong.SuspendLayout();
            this.tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Margin = new System.Windows.Forms.Padding(0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AutoScroll = true;
            this.splitMain.Panel1.BackColor = System.Drawing.Color.White;
            this.splitMain.Panel1.Controls.Add(this.tblLeft);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tblRight);
            this.splitMain.Size = new System.Drawing.Size(747, 338);
            this.splitMain.SplitterDistance = 200;
            this.splitMain.SplitterWidth = 3;
            this.splitMain.TabIndex = 0;
            // 
            // tblLeft
            // 
            this.tblLeft.BackColor = System.Drawing.Color.Black;
            this.tblLeft.ColumnCount = 1;
            this.tblLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Controls.Add(this.grpCriteria, 0, 1);
            this.tblLeft.Controls.Add(this.cmbBooks, 0, 0);
            this.tblLeft.Controls.Add(this.grpSongResults, 0, 2);
            this.tblLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeft.Location = new System.Drawing.Point(0, 0);
            this.tblLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tblLeft.Name = "tblLeft";
            this.tblLeft.RowCount = 3;
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLeft.Size = new System.Drawing.Size(200, 338);
            this.tblLeft.TabIndex = 0;
            // 
            // grpCriteria
            // 
            this.grpCriteria.Controls.Add(this.btnSearchAll);
            this.grpCriteria.Controls.Add(this.lblSearchAll);
            this.grpCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCriteria.ForeColor = System.Drawing.Color.White;
            this.grpCriteria.Location = new System.Drawing.Point(3, 38);
            this.grpCriteria.Name = "grpCriteria";
            this.grpCriteria.Padding = new System.Windows.Forms.Padding(5);
            this.grpCriteria.Size = new System.Drawing.Size(194, 44);
            this.grpCriteria.TabIndex = 12;
            this.grpCriteria.TabStop = false;
            this.grpCriteria.Text = "Search Criteria:";
            this.grpCriteria.Enter += new System.EventHandler(this.grpCriteria_Enter);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.BackColor = System.Drawing.Color.Black;
            this.btnSearchAll.BorderColor = System.Drawing.Color.Black;
            this.btnSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchAll.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAll.ForeColor = System.Drawing.Color.Black;
            this.btnSearchAll.IsOn = true;
            this.btnSearchAll.Location = new System.Drawing.Point(151, 18);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(38, 21);
            this.btnSearchAll.TabIndex = 7;
            this.btnSearchAll.Text = "Search All";
            this.btnSearchAll.TextEnabled = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // lblSearchAll
            // 
            this.lblSearchAll.AutoSize = true;
            this.lblSearchAll.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchAll.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAll.ForeColor = System.Drawing.Color.White;
            this.lblSearchAll.Location = new System.Drawing.Point(8, 18);
            this.lblSearchAll.Name = "lblSearchAll";
            this.lblSearchAll.Size = new System.Drawing.Size(158, 22);
            this.lblSearchAll.TabIndex = 11;
            this.lblSearchAll.Text = "Search All Songbooks";
            this.lblSearchAll.Click += new System.EventHandler(this.lblSearchAll_Click);
            this.lblSearchAll.Enter += new System.EventHandler(this.lblSearchAll_Enter);
            // 
            // cmbBooks
            // 
            this.cmbBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(3, 3);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(194, 30);
            this.cmbBooks.TabIndex = 11;
            this.cmbBooks.SelectedIndexChanged += new System.EventHandler(this.cmbBooks_SelectedIndexChanged);
            // 
            // grpSongResults
            // 
            this.grpSongResults.Controls.Add(this.lstSongResults);
            this.grpSongResults.Controls.Add(this.lstBookcodes);
            this.grpSongResults.Controls.Add(this.lstSongids);
            this.grpSongResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSongResults.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSongResults.ForeColor = System.Drawing.Color.White;
            this.grpSongResults.Location = new System.Drawing.Point(3, 85);
            this.grpSongResults.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.grpSongResults.Name = "grpSongResults";
            this.grpSongResults.Size = new System.Drawing.Size(194, 250);
            this.grpSongResults.TabIndex = 13;
            this.grpSongResults.TabStop = false;
            this.grpSongResults.Text = " 0 Songs Found: ";
            // 
            // lstSongResults
            // 
            this.lstSongResults.BackColor = System.Drawing.Color.Black;
            this.lstSongResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSongResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSongResults.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSongResults.ForeColor = System.Drawing.Color.White;
            this.lstSongResults.FormattingEnabled = true;
            this.lstSongResults.ItemHeight = 22;
            this.lstSongResults.Location = new System.Drawing.Point(3, 16);
            this.lstSongResults.Margin = new System.Windows.Forms.Padding(0);
            this.lstSongResults.Name = "lstSongResults";
            this.lstSongResults.Size = new System.Drawing.Size(188, 231);
            this.lstSongResults.TabIndex = 8;
            this.lstSongResults.SelectedIndexChanged += new System.EventHandler(this.lstSongResults_SelectedIndexChanged);
            // 
            // lstBookcodes
            // 
            this.lstBookcodes.FormattingEnabled = true;
            this.lstBookcodes.ItemHeight = 16;
            this.lstBookcodes.Location = new System.Drawing.Point(23, 34);
            this.lstBookcodes.Name = "lstBookcodes";
            this.lstBookcodes.Size = new System.Drawing.Size(144, 180);
            this.lstBookcodes.TabIndex = 0;
            this.lstBookcodes.SelectedIndexChanged += new System.EventHandler(this.lstBookcodes_SelectedIndexChanged);
            // 
            // lstSongids
            // 
            this.lstSongids.FormattingEnabled = true;
            this.lstSongids.ItemHeight = 16;
            this.lstSongids.Location = new System.Drawing.Point(23, 20);
            this.lstSongids.Name = "lstSongids";
            this.lstSongids.Size = new System.Drawing.Size(135, 228);
            this.lstSongids.TabIndex = 0;
            this.lstSongids.SelectedIndexChanged += new System.EventHandler(this.lstSongids_SelectedIndexChanged);
            // 
            // tblRight
            // 
            this.tblRight.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblRight.ColumnCount = 1;
            this.tblRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRight.Controls.Add(this.txtSongContent, 0, 2);
            this.tblRight.Controls.Add(this.ToolStripSong, 0, 1);
            this.tblRight.Controls.Add(this.tblSearch, 0, 0);
            this.tblRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRight.Location = new System.Drawing.Point(0, 0);
            this.tblRight.Margin = new System.Windows.Forms.Padding(0);
            this.tblRight.Name = "tblRight";
            this.tblRight.RowCount = 4;
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tblRight.Size = new System.Drawing.Size(544, 338);
            this.tblRight.TabIndex = 6;
            // 
            // txtSongContent
            // 
            this.txtSongContent.BackColor = System.Drawing.Color.White;
            this.txtSongContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSongContent.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongContent.Location = new System.Drawing.Point(1, 78);
            this.txtSongContent.Margin = new System.Windows.Forms.Padding(0);
            this.txtSongContent.Multiline = true;
            this.txtSongContent.Name = "txtSongContent";
            this.txtSongContent.ReadOnly = true;
            this.txtSongContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSongContent.ShortcutsEnabled = false;
            this.txtSongContent.Size = new System.Drawing.Size(542, 258);
            this.txtSongContent.TabIndex = 1;
            // 
            // ToolStripSong
            // 
            this.ToolStripSong.AutoSize = false;
            this.ToolStripSong.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStripSong.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripSong.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnProject,
            this.tsbtnEdit,
            this.toolStripSeparator1,
            this.tsbtnLast,
            this.tsbtnNext,
            this.toolStripSeparator2,
            this.tsbtnBigger,
            this.tsbtnSmaller,
            this.tsbtnFont,
            this.tsbtnBold,
            this.toolStripSeparator3,
            this.tsbtnCopy,
            this.tsbtnSelect,
            this.toolStripSeparator4,
            this.tsbtnPrint});
            this.ToolStripSong.Location = new System.Drawing.Point(1, 42);
            this.ToolStripSong.Name = "ToolStripSong";
            this.ToolStripSong.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.ToolStripSong.Size = new System.Drawing.Size(542, 35);
            this.ToolStripSong.Stretch = true;
            this.ToolStripSong.TabIndex = 5;
            // 
            // tsbtnProject
            // 
            this.tsbtnProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProject.Image")));
            this.tsbtnProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProject.Name = "tsbtnProject";
            this.tsbtnProject.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnProject.Size = new System.Drawing.Size(93, 32);
            this.tsbtnProject.Text = "&PROJECT";
            this.tsbtnProject.ToolTipText = "Project current song";
            this.tsbtnProject.Click += new System.EventHandler(this.tsbtnProject_Click);
            // 
            // tsbtnEdit
            // 
            this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
            this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEdit.Name = "tsbtnEdit";
            this.tsbtnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnEdit.Size = new System.Drawing.Size(69, 32);
            this.tsbtnEdit.Text = "&EDIT";
            this.tsbtnEdit.ToolTipText = "Edit current song";
            this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnLast
            // 
            this.tsbtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLast.Image")));
            this.tsbtnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLast.Name = "tsbtnLast";
            this.tsbtnLast.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnLast.Size = new System.Drawing.Size(38, 32);
            this.tsbtnLast.Text = "&Last";
            this.tsbtnLast.ToolTipText = "Last song before current song";
            this.tsbtnLast.Click += new System.EventHandler(this.tsbtnLast_Click);
            // 
            // tsbtnNext
            // 
            this.tsbtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNext.Image")));
            this.tsbtnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNext.Name = "tsbtnNext";
            this.tsbtnNext.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnNext.Size = new System.Drawing.Size(38, 32);
            this.tsbtnNext.Text = "&Next";
            this.tsbtnNext.ToolTipText = "Next song after current song";
            this.tsbtnNext.Click += new System.EventHandler(this.tsbtnNext_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnBigger
            // 
            this.tsbtnBigger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBigger.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBigger.Image")));
            this.tsbtnBigger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBigger.Name = "tsbtnBigger";
            this.tsbtnBigger.Size = new System.Drawing.Size(28, 32);
            this.tsbtnBigger.Text = "&Bigger";
            this.tsbtnBigger.ToolTipText = "Increase font size";
            this.tsbtnBigger.Click += new System.EventHandler(this.tsbtnBigger_Click);
            // 
            // tsbtnSmaller
            // 
            this.tsbtnSmaller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSmaller.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSmaller.Image")));
            this.tsbtnSmaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSmaller.Name = "tsbtnSmaller";
            this.tsbtnSmaller.Size = new System.Drawing.Size(28, 32);
            this.tsbtnSmaller.Text = "&Smaller";
            this.tsbtnSmaller.ToolTipText = "Decrease font size";
            this.tsbtnSmaller.Click += new System.EventHandler(this.tsbtnSmaller_Click);
            // 
            // tsbtnFont
            // 
            this.tsbtnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFont.Image")));
            this.tsbtnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFont.Name = "tsbtnFont";
            this.tsbtnFont.Size = new System.Drawing.Size(28, 32);
            this.tsbtnFont.Text = "Change Font";
            this.tsbtnFont.ToolTipText = "Change Font Type";
            this.tsbtnFont.Click += new System.EventHandler(this.tsbtnFont_Click);
            // 
            // tsbtnBold
            // 
            this.tsbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBold.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBold.Image")));
            this.tsbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBold.Name = "tsbtnBold";
            this.tsbtnBold.Size = new System.Drawing.Size(28, 32);
            this.tsbtnBold.Text = "Bold";
            this.tsbtnBold.ToolTipText = "Make song Text Bold";
            this.tsbtnBold.Click += new System.EventHandler(this.tsbtnBold_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnCopy
            // 
            this.tsbtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCopy.Image")));
            this.tsbtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCopy.Name = "tsbtnCopy";
            this.tsbtnCopy.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnCopy.Size = new System.Drawing.Size(38, 32);
            this.tsbtnCopy.Text = "&Copy";
            this.tsbtnCopy.ToolTipText = "Copy text of current song";
            this.tsbtnCopy.Click += new System.EventHandler(this.tsbtnCopy_Click);
            // 
            // tsbtnSelect
            // 
            this.tsbtnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSelect.Image")));
            this.tsbtnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSelect.Name = "tsbtnSelect";
            this.tsbtnSelect.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnSelect.Size = new System.Drawing.Size(38, 32);
            this.tsbtnSelect.Text = "&Select All";
            this.tsbtnSelect.ToolTipText = "Select all the text of the current song";
            this.tsbtnSelect.Click += new System.EventHandler(this.tsbtnSelect_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrint.Image")));
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnPrint.Size = new System.Drawing.Size(38, 32);
            this.tsbtnPrint.Text = "&Print";
            this.tsbtnPrint.ToolTipText = "Print current song";
            this.tsbtnPrint.Click += new System.EventHandler(this.tsbtnPrint_Click);
            // 
            // tblSearch
            // 
            this.tblSearch.BackColor = System.Drawing.Color.White;
            this.tblSearch.ColumnCount = 3;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblSearch.Controls.Add(this.btnClear, 2, 0);
            this.tblSearch.Controls.Add(this.txtSearch, 1, 0);
            this.tblSearch.Controls.Add(this.pbxSearch, 0, 0);
            this.tblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearch.Location = new System.Drawing.Point(1, 1);
            this.tblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.Padding = new System.Windows.Forms.Padding(5);
            this.tblSearch.RowCount = 1;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSearch.Size = new System.Drawing.Size(542, 40);
            this.tblSearch.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Inactive2 = System.Drawing.Color.Gray;
            this.btnClear.Location = new System.Drawing.Point(507, 5);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Radius = 15;
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.Stroke = true;
            this.btnClear.StrokeColor = System.Drawing.Color.Black;
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "X";
            this.btnClear.Transparency = false;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(35, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(472, 28);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "Search for Songs";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // pbxSearch
            // 
            this.pbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(5, 5);
            this.pbxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(30, 30);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSearch.TabIndex = 9;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
            // 
            // jsFeedback
            // 
            this.jsFeedback.BackColor = System.Drawing.Color.LightGreen;
            this.jsFeedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jsFeedback.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.jsFeedback.ForeColor = System.Drawing.Color.Black;
            this.jsFeedback.Interval = 2500F;
            this.jsFeedback.IsPositive = true;
            this.jsFeedback.IsTimed = false;
            this.jsFeedback.Location = new System.Drawing.Point(0, 288);
            this.jsFeedback.Name = "jsFeedback";
            this.jsFeedback.Size = new System.Drawing.Size(747, 50);
            this.jsFeedback.TabIndex = 3;
            this.jsFeedback.Text = "mBible Feedback";
            this.jsFeedback.Visible = false;
            // 
            // CcBibleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 338);
            this.Controls.Add(this.jsFeedback);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CcBibleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bible  View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CcBibleView_FormClosing);
            this.Load += new System.EventHandler(this.CcBibleView_Load);
            this.Resize += new System.EventHandler(this.CcBibleView_Resize);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tblLeft.ResumeLayout(false);
            this.grpCriteria.ResumeLayout(false);
            this.grpCriteria.PerformLayout();
            this.grpSongResults.ResumeLayout(false);
            this.tblRight.ResumeLayout(false);
            this.tblRight.PerformLayout();
            this.ToolStripSong.ResumeLayout(false);
            this.ToolStripSong.PerformLayout();
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.ListBox lstSongResults;
        private System.Windows.Forms.TableLayoutPanel tblLeft;
        private System.Windows.Forms.GroupBox grpCriteria;
        private JacksiroCtrl.JsSwitch btnSearchAll;
        private System.Windows.Forms.Label lblSearchAll;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.TableLayoutPanel tblRight;
        private System.Windows.Forms.GroupBox grpSongResults;
        private System.Windows.Forms.ListBox lstSongids;
        private System.Windows.Forms.ListBox lstBookcodes;
        private System.Windows.Forms.TextBox txtSongContent;
        private System.Windows.Forms.Timer tmrTimerWait;
        private JacksiroCtrl.JsFeedback jsFeedback;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tblSearch;
        private System.Windows.Forms.ToolStrip ToolStripSong;
        private System.Windows.Forms.ToolStripButton tsbtnProject;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnLast;
        private System.Windows.Forms.ToolStripButton tsbtnNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnBigger;
        private System.Windows.Forms.ToolStripButton tsbtnSmaller;
        private System.Windows.Forms.ToolStripButton tsbtnFont;
        private System.Windows.Forms.ToolStripButton tsbtnBold;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnCopy;
        private System.Windows.Forms.ToolStripButton tsbtnSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnPrint;
        private System.Windows.Forms.PictureBox pbxSearch;
        private JacksiroCtrl.JsButton btnClear;
    }
}