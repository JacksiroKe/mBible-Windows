namespace mBible
{
    partial class CcBookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CcBookList));
            this.grpBookResults = new System.Windows.Forms.GroupBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lstBookids = new System.Windows.Forms.ListBox();
            this.btnUpdate = new JacksiroCtrl.JsButton();
            this.btnDelete = new JacksiroCtrl.JsButton();
            this.lblActions = new System.Windows.Forms.Label();
            this.txtBookTitle = new JacksiroCtrl.JsTextBox();
            this.tblTop = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNew = new JacksiroCtrl.JsButton();
            this.btnSaveNew = new JacksiroCtrl.JsButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtBookCode = new JacksiroCtrl.JsTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.jsFeedback = new JacksiroCtrl.JsFeedback();
            this.grpBookResults.SuspendLayout();
            this.tblTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBookResults
            // 
            this.grpBookResults.Controls.Add(this.lstBooks);
            this.grpBookResults.Controls.Add(this.lstBookids);
            this.grpBookResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBookResults.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookResults.Location = new System.Drawing.Point(5, 5);
            this.grpBookResults.Name = "grpBookResults";
            this.grpBookResults.Padding = new System.Windows.Forms.Padding(5);
            this.grpBookResults.Size = new System.Drawing.Size(230, 385);
            this.grpBookResults.TabIndex = 1;
            this.grpBookResults.TabStop = false;
            this.grpBookResults.Text = " 0 books exist currently";
            // 
            // lstBooks
            // 
            this.lstBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBooks.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 22;
            this.lstBooks.Location = new System.Drawing.Point(5, 21);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(220, 359);
            this.lstBooks.TabIndex = 0;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // lstBookids
            // 
            this.lstBookids.FormattingEnabled = true;
            this.lstBookids.ItemHeight = 18;
            this.lstBookids.Location = new System.Drawing.Point(36, 61);
            this.lstBookids.Name = "lstBookids";
            this.lstBookids.Size = new System.Drawing.Size(144, 184);
            this.lstBookids.TabIndex = 0;
            this.lstBookids.SelectedIndexChanged += new System.EventHandler(this.lstBookids_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(168, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Radius = 5;
            this.btnUpdate.Size = new System.Drawing.Size(52, 38);
            this.btnUpdate.Stroke = true;
            this.btnUpdate.StrokeColor = System.Drawing.Color.Black;
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Transparency = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(113, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 5;
            this.btnDelete.Size = new System.Drawing.Size(49, 38);
            this.btnDelete.Stroke = true;
            this.btnDelete.StrokeColor = System.Drawing.Color.Black;
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Transparency = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblActions.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(122, 0);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(75, 62);
            this.lblActions.TabIndex = 0;
            this.lblActions.Text = "ACTIONS";
            this.lblActions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtBookTitle.Background = System.Drawing.Color.White;
            this.txtBookTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBookTitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.ForeColor = System.Drawing.Color.Black;
            this.txtBookTitle.IsSearch = false;
            this.txtBookTitle.Location = new System.Drawing.Point(5, 5);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Placeholder = "Title of the Book";
            this.txtBookTitle.ShowIcon = false;
            this.txtBookTitle.Size = new System.Drawing.Size(431, 40);
            this.txtBookTitle.TabIndex = 11;
            this.txtBookTitle.Text = "Title of the Book";
            // 
            // tblTop
            // 
            this.tblTop.ColumnCount = 4;
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTop.Controls.Add(this.btnAddNew, 0, 0);
            this.tblTop.Controls.Add(this.btnSaveNew, 1, 0);
            this.tblTop.Controls.Add(this.btnDelete, 2, 0);
            this.tblTop.Controls.Add(this.btnUpdate, 3, 0);
            this.tblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTop.Location = new System.Drawing.Point(5, 5);
            this.tblTop.Name = "tblTop";
            this.tblTop.RowCount = 1;
            this.tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblTop.Size = new System.Drawing.Size(223, 44);
            this.tblTop.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNew.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNew.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.Black;
            this.btnAddNew.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNew.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddNew.Location = new System.Drawing.Point(3, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Radius = 5;
            this.btnAddNew.Size = new System.Drawing.Size(49, 38);
            this.btnAddNew.Stroke = true;
            this.btnAddNew.StrokeColor = System.Drawing.Color.Black;
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "ADD New";
            this.btnAddNew.Transparency = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveNew.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSaveNew.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveNew.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveNew.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveNew.ForeColor = System.Drawing.Color.Black;
            this.btnSaveNew.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveNew.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveNew.Location = new System.Drawing.Point(58, 3);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Radius = 5;
            this.btnSaveNew.Size = new System.Drawing.Size(49, 38);
            this.btnSaveNew.Stroke = true;
            this.btnSaveNew.StrokeColor = System.Drawing.Color.Black;
            this.btnSaveNew.TabIndex = 10;
            this.btnSaveNew.Text = "SAVE New";
            this.btnSaveNew.Transparency = false;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(453, 74);
            this.panel1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblActions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 62);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tblTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(235, 56);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 83);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(453, 299);
            this.panel3.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grpNotes, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBookCode, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBookTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblInfo, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(441, 287);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNotes);
            this.grpNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNotes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNotes.Location = new System.Drawing.Point(3, 103);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Padding = new System.Windows.Forms.Padding(5);
            this.grpNotes.Size = new System.Drawing.Size(435, 68);
            this.grpNotes.TabIndex = 12;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = " Book Notes (Optional): ";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(5, 24);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(10);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(425, 39);
            this.txtNotes.TabIndex = 13;
            // 
            // txtBookCode
            // 
            this.txtBookCode.BackColor = System.Drawing.Color.Transparent;
            this.txtBookCode.Background = System.Drawing.Color.White;
            this.txtBookCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBookCode.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCode.ForeColor = System.Drawing.Color.Black;
            this.txtBookCode.IsSearch = false;
            this.txtBookCode.Location = new System.Drawing.Point(5, 55);
            this.txtBookCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Placeholder = "Code of the Book";
            this.txtBookCode.ShowIcon = false;
            this.txtBookCode.Size = new System.Drawing.Size(431, 40);
            this.txtBookCode.TabIndex = 13;
            this.txtBookCode.Text = "Code of the Book";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 174);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(20, 27);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = ".";
            // 
            // splitMain
            // 
            this.splitMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(5, 5);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.grpBookResults);
            this.splitMain.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitMain.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitMain.Size = new System.Drawing.Size(717, 397);
            this.splitMain.SplitterDistance = 242;
            this.splitMain.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(459, 385);
            this.tableLayoutPanel3.TabIndex = 16;
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
            this.jsFeedback.Location = new System.Drawing.Point(5, 352);
            this.jsFeedback.Name = "jsFeedback";
            this.jsFeedback.Size = new System.Drawing.Size(717, 50);
            this.jsFeedback.TabIndex = 4;
            this.jsFeedback.Text = "mBible Feedback";
            this.jsFeedback.Visible = false;
            // 
            // CcBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 407);
            this.Controls.Add(this.jsFeedback);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CcBookList";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Books List";
            this.Load += new System.EventHandler(this.CcBookList_Load);
            this.grpBookResults.ResumeLayout(false);
            this.tblTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBookResults;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.ListBox lstBookids;
        private JacksiroCtrl.JsButton btnUpdate;
        private JacksiroCtrl.JsButton btnDelete;
        private System.Windows.Forms.Label lblActions;
        private JacksiroCtrl.JsTextBox txtBookTitle;
        private System.Windows.Forms.TableLayoutPanel tblTop;
        private System.Windows.Forms.SplitContainer splitMain;
        private JacksiroCtrl.JsButton btnAddNew;
        private JacksiroCtrl.JsButton btnSaveNew;
        private JacksiroCtrl.JsTextBox txtBookCode;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblInfo;
        private JacksiroCtrl.JsFeedback jsFeedback;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}