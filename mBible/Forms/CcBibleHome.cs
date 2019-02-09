using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mBible
{
    public partial class CcBibleHome : Form
    {
        int tabcount = 0;
        AppFunctions vsbf = new AppFunctions();
        AppSettings settings = new AppSettings();
        public int opentabs = 0;
        string vsbTitle = "";
        
        public CcBibleHome()
        { 
            InitializeComponent();
            vsbLoading.Dock = DockStyle.Fill;
            tmrMain.Enabled = true;
        }

        private void loadFeedback(string fbmessage, bool positive = true, bool timed = false, float interval = 1000)
        {
            jsFeedback.Interval = interval == 0 ? interval : jsFeedback.Interval;
            jsFeedback.IsPositive = positive;
            jsFeedback.IsTimed = timed;
            jsFeedback.Text = fbmessage;
            jsFeedback.Visible = true;
        }
        private void showNewTab()
        {
            Form cform;
            cform = new CcBibleSearch();
            tabcount = tabcount + 1;
            opentabs = opentabs + 1;
            cform.Text = "Search Tab " + tabcount;
            tabParent.TabPages.Add(cform);
        }

        
        private void CcBibleHome_Load(object sender, EventArgs e)
        {
            showNewTab();
            vsbLoading.Visible = false;
        }

        public void editAsong()
        {
            
        }

        private void menuItemNewSong_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNewtab_Click(object sender, EventArgs e)
        {
            showNewTab();
        }

        private void menuItemEditSong_Click(object sender, EventArgs e)
        {
            editAsong();
        }

        private void menuItemNewTab_Click(object sender, EventArgs e)
        {
            showNewTab();
        }

        private void menuItemPreferences_Click(object sender, EventArgs e)
        {
            Form sform;
            sform = new EeSettings();
            tabParent.TabPages.Add(sform);
        }

        private void tabParent_Load(object sender, EventArgs e)
        {

        }

        public void updateTabCount()
        {
            opentabs = tabParent.TabPages.Count;
            
        }

        private void menuItemWindow_Click(object sender, EventArgs e)
        {
            //int i;
            menuItemWindow.DropDownItems.Clear();
            /*
             * WinMenu.Items.Clear()
             For i As Integer = 0 To Items.Count - 1
            WinMenu.Items.Add(Items(i).MenuItem)
            AddHandler Items(i).MenuItem.Click, AddressOf MenuClick
        Next
             */
            /*for (i = 0; i < tabParent.TabPages.Count-1; i++ )
            {
                //.DropDownItems.Add(tabParent.TabPages(i).);
               
            }
            menuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewSong,
            this.menuItemExit
            });*/
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            vsbTitle = "mBible v" + settings.VsbVersion + " © " + DateTime.Today.Year + " " + settings.AppUser + " | " + vsbf.dateToday();
            this.Text = vsbTitle;
            vsbLoading.Text = vsbTitle;
        }

        private void menuItemOpenBooks_Click(object sender, EventArgs e)
        {
            Form bform;
            bform = new CcBookList();
            tabParent.TabPages.Add(bform);
        }

        private void CcBibleHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabParent.TabPages.Count >= 2)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close mBible?", "Just a Minute ...", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    closeUpActions();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            } 
            else
            {
                closeUpActions();
            }
            
        }

        private void closeUpActions()
        {
            Application.Exit();

        }

    }
}
