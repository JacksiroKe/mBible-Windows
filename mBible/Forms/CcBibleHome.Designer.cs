namespace mBible
{
    partial class CcBibleHome
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
            System.Windows.Forms.ToolStripProfessionalRenderer toolStripProfessionalRenderer1 = new System.Windows.Forms.ToolStripProfessionalRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CcBibleHome));
            this.menuMainTop = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewSong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditSong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveSong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTabProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAnimateIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUntab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRemoveTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuickSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdvancedSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSearchHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSearchSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKiswahili = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSwitchModes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemResetSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.noftabs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTechnicalSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.tabParent = new Jacksiro.MdiTab.TabControl();
            this.btnNewtab = new System.Windows.Forms.Button();
            this.vsbLoading = new JacksiroCtrl.JsButton();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.jsFeedback = new JacksiroCtrl.JsFeedback();
            this.menuMainTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainTop
            // 
            this.menuMainTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuMainTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMainTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemEdit,
            this.menuItemView,
            this.menuItemSearch,
            this.menuItemLanguage,
            this.menuItemSettings,
            this.menuItemWindow,
            this.menuItemHelp});
            this.menuMainTop.Location = new System.Drawing.Point(0, 0);
            this.menuMainTop.Name = "menuMainTop";
            this.menuMainTop.Size = new System.Drawing.Size(698, 24);
            this.menuMainTop.TabIndex = 5;
            this.menuMainTop.Text = "MenuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.AccessibleName = "";
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewSong,
            this.menuItemEditSong,
            this.menuItemSaveSong,
            this.menuItemOpenBooks,
            this.LineToolStripMenuItem,
            this.menuItemHistory,
            this.LineToolStripMenuItem1,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(40, 20);
            this.menuItemFile.Text = "&FILE";
            // 
            // menuItemNewSong
            // 
            this.menuItemNewSong.Name = "menuItemNewSong";
            this.menuItemNewSong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemNewSong.Size = new System.Drawing.Size(206, 22);
            this.menuItemNewSong.Text = "New &Song";
            this.menuItemNewSong.Click += new System.EventHandler(this.menuItemNewSong_Click);
            // 
            // menuItemEditSong
            // 
            this.menuItemEditSong.Name = "menuItemEditSong";
            this.menuItemEditSong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuItemEditSong.Size = new System.Drawing.Size(206, 22);
            this.menuItemEditSong.Text = "Edit Song";
            this.menuItemEditSong.Click += new System.EventHandler(this.menuItemEditSong_Click);
            // 
            // menuItemSaveSong
            // 
            this.menuItemSaveSong.Name = "menuItemSaveSong";
            this.menuItemSaveSong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSaveSong.Size = new System.Drawing.Size(206, 22);
            this.menuItemSaveSong.Text = "Save Song";
            // 
            // menuItemOpenBooks
            // 
            this.menuItemOpenBooks.Name = "menuItemOpenBooks";
            this.menuItemOpenBooks.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuItemOpenBooks.Size = new System.Drawing.Size(206, 22);
            this.menuItemOpenBooks.Text = "Open &Songbooks";
            this.menuItemOpenBooks.Click += new System.EventHandler(this.menuItemOpenBooks_Click);
            // 
            // LineToolStripMenuItem
            // 
            this.LineToolStripMenuItem.Name = "LineToolStripMenuItem";
            this.LineToolStripMenuItem.Size = new System.Drawing.Size(203, 6);
            // 
            // menuItemHistory
            // 
            this.menuItemHistory.Name = "menuItemHistory";
            this.menuItemHistory.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuItemHistory.Size = new System.Drawing.Size(206, 22);
            this.menuItemHistory.Text = "View &History";
            // 
            // LineToolStripMenuItem1
            // 
            this.LineToolStripMenuItem1.Name = "LineToolStripMenuItem1";
            this.LineToolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemExit.Size = new System.Drawing.Size(206, 22);
            this.menuItemExit.Text = "Exit";
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUndo,
            this.menuItemRedo,
            this.LineToolStripMenuItem2,
            this.menuItemCut,
            this.menuItemCopy,
            this.menuItemPaste,
            this.menuItemDelete,
            this.LineToolStripMenuItem3,
            this.menuItemSelectAll});
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(43, 20);
            this.menuItemEdit.Text = "&EDIT";
            // 
            // menuItemUndo
            // 
            this.menuItemUndo.Name = "menuItemUndo";
            this.menuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuItemUndo.Size = new System.Drawing.Size(164, 22);
            this.menuItemUndo.Text = "Undo";
            // 
            // menuItemRedo
            // 
            this.menuItemRedo.Name = "menuItemRedo";
            this.menuItemRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuItemRedo.Size = new System.Drawing.Size(164, 22);
            this.menuItemRedo.Text = "Redo";
            // 
            // LineToolStripMenuItem2
            // 
            this.LineToolStripMenuItem2.Name = "LineToolStripMenuItem2";
            this.LineToolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // menuItemCut
            // 
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItemCut.Size = new System.Drawing.Size(164, 22);
            this.menuItemCut.Text = "Cut";
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuItemCopy.Size = new System.Drawing.Size(164, 22);
            this.menuItemCopy.Text = "Copy";
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Name = "menuItemPaste";
            this.menuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItemPaste.Size = new System.Drawing.Size(164, 22);
            this.menuItemPaste.Text = "Paste";
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItemDelete.Size = new System.Drawing.Size(164, 22);
            this.menuItemDelete.Text = "Delete";
            // 
            // LineToolStripMenuItem3
            // 
            this.LineToolStripMenuItem3.Name = "LineToolStripMenuItem3";
            this.LineToolStripMenuItem3.Size = new System.Drawing.Size(161, 6);
            // 
            // menuItemSelectAll
            // 
            this.menuItemSelectAll.Name = "menuItemSelectAll";
            this.menuItemSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuItemSelectAll.Size = new System.Drawing.Size(164, 22);
            this.menuItemSelectAll.Text = "Select All";
            // 
            // menuItemView
            // 
            this.menuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewTab,
            this.menuItemTabProperties,
            this.menuItemAnimateIcon,
            this.menuItemUntab,
            this.menuItemRemoveTab});
            this.menuItemView.Name = "menuItemView";
            this.menuItemView.Size = new System.Drawing.Size(46, 20);
            this.menuItemView.Text = "&VIEW";
            // 
            // menuItemNewTab
            // 
            this.menuItemNewTab.Name = "menuItemNewTab";
            this.menuItemNewTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuItemNewTab.Size = new System.Drawing.Size(206, 22);
            this.menuItemNewTab.Text = "New Preview Tab";
            this.menuItemNewTab.Click += new System.EventHandler(this.menuItemNewTab_Click);
            // 
            // menuItemTabProperties
            // 
            this.menuItemTabProperties.Name = "menuItemTabProperties";
            this.menuItemTabProperties.Size = new System.Drawing.Size(206, 22);
            this.menuItemTabProperties.Text = "Change Properties";
            // 
            // menuItemAnimateIcon
            // 
            this.menuItemAnimateIcon.Name = "menuItemAnimateIcon";
            this.menuItemAnimateIcon.Size = new System.Drawing.Size(206, 22);
            this.menuItemAnimateIcon.Text = "Animate Icon";
            // 
            // menuItemUntab
            // 
            this.menuItemUntab.Name = "menuItemUntab";
            this.menuItemUntab.Size = new System.Drawing.Size(206, 22);
            this.menuItemUntab.Text = "Untab ";
            // 
            // menuItemRemoveTab
            // 
            this.menuItemRemoveTab.Name = "menuItemRemoveTab";
            this.menuItemRemoveTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuItemRemoveTab.Size = new System.Drawing.Size(206, 22);
            this.menuItemRemoveTab.Text = "Remove Tab";
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemQuickSearch,
            this.menuItemAdvancedSearch,
            this.LineToolStripMenuItem4,
            this.menuItemSearchHistory,
            this.menuItemSearchSettings});
            this.menuItemSearch.Name = "menuItemSearch";
            this.menuItemSearch.Size = new System.Drawing.Size(63, 20);
            this.menuItemSearch.Text = "&SEARCH";
            // 
            // menuItemQuickSearch
            // 
            this.menuItemQuickSearch.Name = "menuItemQuickSearch";
            this.menuItemQuickSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuItemQuickSearch.Size = new System.Drawing.Size(205, 22);
            this.menuItemQuickSearch.Text = "QuickSearch";
            // 
            // menuItemAdvancedSearch
            // 
            this.menuItemAdvancedSearch.Name = "menuItemAdvancedSearch";
            this.menuItemAdvancedSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.menuItemAdvancedSearch.Size = new System.Drawing.Size(205, 22);
            this.menuItemAdvancedSearch.Text = "Advanced Search";
            // 
            // LineToolStripMenuItem4
            // 
            this.LineToolStripMenuItem4.Name = "LineToolStripMenuItem4";
            this.LineToolStripMenuItem4.Size = new System.Drawing.Size(202, 6);
            // 
            // menuItemSearchHistory
            // 
            this.menuItemSearchHistory.Name = "menuItemSearchHistory";
            this.menuItemSearchHistory.Size = new System.Drawing.Size(205, 22);
            this.menuItemSearchHistory.Text = "Search History";
            // 
            // menuItemSearchSettings
            // 
            this.menuItemSearchSettings.Name = "menuItemSearchSettings";
            this.menuItemSearchSettings.Size = new System.Drawing.Size(205, 22);
            this.menuItemSearchSettings.Text = "Search Settings";
            // 
            // menuItemLanguage
            // 
            this.menuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEnglish,
            this.menuItemKiswahili,
            this.menuItemFrench,
            this.menuItemSpanish});
            this.menuItemLanguage.Name = "menuItemLanguage";
            this.menuItemLanguage.Size = new System.Drawing.Size(80, 20);
            this.menuItemLanguage.Text = "&LANGUAGE";
            // 
            // menuItemEnglish
            // 
            this.menuItemEnglish.Name = "menuItemEnglish";
            this.menuItemEnglish.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.menuItemEnglish.Size = new System.Drawing.Size(157, 22);
            this.menuItemEnglish.Text = "English";
            // 
            // menuItemKiswahili
            // 
            this.menuItemKiswahili.Name = "menuItemKiswahili";
            this.menuItemKiswahili.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.menuItemKiswahili.Size = new System.Drawing.Size(157, 22);
            this.menuItemKiswahili.Text = "Kiswahili";
            // 
            // menuItemFrench
            // 
            this.menuItemFrench.Name = "menuItemFrench";
            this.menuItemFrench.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.menuItemFrench.Size = new System.Drawing.Size(157, 22);
            this.menuItemFrench.Text = "French";
            // 
            // menuItemSpanish
            // 
            this.menuItemSpanish.Name = "menuItemSpanish";
            this.menuItemSpanish.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.menuItemSpanish.Size = new System.Drawing.Size(157, 22);
            this.menuItemSpanish.Text = "Spanish";
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPreferences,
            this.menuItemSwitchModes,
            this.menuItemResetSettings});
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(71, 20);
            this.menuItemSettings.Text = "&SETTINGS";
            // 
            // menuItemPreferences
            // 
            this.menuItemPreferences.Name = "menuItemPreferences";
            this.menuItemPreferences.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.menuItemPreferences.Size = new System.Drawing.Size(188, 22);
            this.menuItemPreferences.Text = "Preferences";
            this.menuItemPreferences.Click += new System.EventHandler(this.menuItemPreferences_Click);
            // 
            // menuItemSwitchModes
            // 
            this.menuItemSwitchModes.Name = "menuItemSwitchModes";
            this.menuItemSwitchModes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.menuItemSwitchModes.Size = new System.Drawing.Size(188, 22);
            this.menuItemSwitchModes.Text = "Switch Modes";
            // 
            // menuItemResetSettings
            // 
            this.menuItemResetSettings.Name = "menuItemResetSettings";
            this.menuItemResetSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuItemResetSettings.Size = new System.Drawing.Size(188, 22);
            this.menuItemResetSettings.Text = "Reset Settings";
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noftabs});
            this.menuItemWindow.Name = "menuItemWindow";
            this.menuItemWindow.Size = new System.Drawing.Size(70, 20);
            this.menuItemWindow.Text = "&WINDOW";
            this.menuItemWindow.Click += new System.EventHandler(this.menuItemWindow_Click);
            // 
            // noftabs
            // 
            this.noftabs.Name = "noftabs";
            this.noftabs.Size = new System.Drawing.Size(114, 22);
            this.noftabs.Text = "noftabs";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemViewHelp,
            this.menuItemTechnicalSupport});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(47, 20);
            this.menuItemHelp.Text = "&HELP";
            // 
            // menuItemViewHelp
            // 
            this.menuItemViewHelp.Name = "menuItemViewHelp";
            this.menuItemViewHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuItemViewHelp.Size = new System.Drawing.Size(210, 22);
            this.menuItemViewHelp.Text = "How It Works";
            // 
            // menuItemTechnicalSupport
            // 
            this.menuItemTechnicalSupport.Name = "menuItemTechnicalSupport";
            this.menuItemTechnicalSupport.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuItemTechnicalSupport.Size = new System.Drawing.Size(210, 22);
            this.menuItemTechnicalSupport.Text = "Get Technical Support";
            // 
            // tabParent
            // 
            this.tabParent.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tabParent.BackColor = System.Drawing.Color.White;
            this.tabParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabParent.Location = new System.Drawing.Point(0, 24);
            toolStripProfessionalRenderer1.RoundedEdges = true;
            this.tabParent.MenuRenderer = toolStripProfessionalRenderer1;
            this.tabParent.Name = "tabParent";
            this.tabParent.Size = new System.Drawing.Size(698, 386);
            this.tabParent.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.tabParent.TabBorderEnhanced = true;
            this.tabParent.TabCloseButtonImage = null;
            this.tabParent.TabCloseButtonImageDisabled = null;
            this.tabParent.TabCloseButtonImageHot = null;
            this.tabParent.TabGlassGradient = true;
            this.tabParent.TabIndex = 10;
            this.tabParent.TabOffset = 1;
            this.tabParent.TabPlusButton = this.btnNewtab;
            this.tabParent.TabPlusImage = null;
            this.tabParent.TabPlusVisable = true;
            this.tabParent.Load += new System.EventHandler(this.tabParent_Load);
            // 
            // btnNewtab
            // 
            this.btnNewtab.Location = new System.Drawing.Point(8, 32);
            this.btnNewtab.Name = "btnNewtab";
            this.btnNewtab.Size = new System.Drawing.Size(75, 23);
            this.btnNewtab.TabIndex = 11;
            this.btnNewtab.Text = "New Tab";
            this.btnNewtab.UseVisualStyleBackColor = true;
            this.btnNewtab.Click += new System.EventHandler(this.btnNewtab_Click);
            // 
            // vsbLoading
            // 
            this.vsbLoading.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vsbLoading.Active2 = System.Drawing.Color.Black;
            this.vsbLoading.BackColor = System.Drawing.Color.Transparent;
            this.vsbLoading.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.vsbLoading.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsbLoading.ForeColor = System.Drawing.Color.White;
            this.vsbLoading.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vsbLoading.Inactive2 = System.Drawing.Color.Black;
            this.vsbLoading.Location = new System.Drawing.Point(12, 42);
            this.vsbLoading.Name = "vsbLoading";
            this.vsbLoading.Radius = 0;
            this.vsbLoading.Size = new System.Drawing.Size(441, 223);
            this.vsbLoading.Stroke = false;
            this.vsbLoading.StrokeColor = System.Drawing.Color.Gray;
            this.vsbLoading.TabIndex = 12;
            this.vsbLoading.Text = "mBible";
            this.vsbLoading.Transparency = false;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
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
            this.jsFeedback.Location = new System.Drawing.Point(0, 360);
            this.jsFeedback.Name = "jsFeedback";
            this.jsFeedback.Size = new System.Drawing.Size(698, 50);
            this.jsFeedback.TabIndex = 13;
            this.jsFeedback.Text = "mBible Feedback";
            this.jsFeedback.Visible = false;
            // 
            // CcBibleHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 410);
            this.Controls.Add(this.jsFeedback);
            this.Controls.Add(this.vsbLoading);
            this.Controls.Add(this.tabParent);
            this.Controls.Add(this.menuMainTop);
            this.Controls.Add(this.btnNewtab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CcBibleHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mBible";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CcBibleHome_FormClosing);
            this.Load += new System.EventHandler(this.CcBibleHome_Load);
            this.menuMainTop.ResumeLayout(false);
            this.menuMainTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainTop;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewSong;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditSong;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveSong;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenBooks;
        private System.Windows.Forms.ToolStripSeparator LineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemHistory;
        private System.Windows.Forms.ToolStripSeparator LineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem menuItemRedo;
        private System.Windows.Forms.ToolStripSeparator LineToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItemCut;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripSeparator LineToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuItemView;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewTab;
        private System.Windows.Forms.ToolStripMenuItem menuItemTabProperties;
        private System.Windows.Forms.ToolStripMenuItem menuItemAnimateIcon;
        private System.Windows.Forms.ToolStripMenuItem menuItemUntab;
        private System.Windows.Forms.ToolStripMenuItem menuItemRemoveTab;
        private System.Windows.Forms.ToolStripMenuItem menuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuickSearch;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdvancedSearch;
        private System.Windows.Forms.ToolStripSeparator LineToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuItemSearchHistory;
        private System.Windows.Forms.ToolStripMenuItem menuItemSearchSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuItemEnglish;
        private System.Windows.Forms.ToolStripMenuItem menuItemKiswahili;
        private System.Windows.Forms.ToolStripMenuItem menuItemFrench;
        private System.Windows.Forms.ToolStripMenuItem menuItemSpanish;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemPreferences;
        private System.Windows.Forms.ToolStripMenuItem menuItemSwitchModes;
        private System.Windows.Forms.ToolStripMenuItem menuItemResetSettings;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemTechnicalSupport;
        private Jacksiro.MdiTab.TabControl tabParent;
        private System.Windows.Forms.Button btnNewtab;
        private System.Windows.Forms.ToolStripMenuItem noftabs;
        private JacksiroCtrl.JsButton vsbLoading;
        private System.Windows.Forms.Timer tmrMain;
        private JacksiroCtrl.JsFeedback jsFeedback;

    }
}