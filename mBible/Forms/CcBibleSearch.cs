using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Finisar.SQLite;
using EasyTabs;

namespace mBible
{
    public partial class CcBibleSearch : Form
    {
        string sqlQuery;
        AppDatabase appDB;
        SQLiteDataReader reader;
        DataRowCollection dRowCol;
        private AppFunctions vsbf = new AppFunctions();
        private AppSettings settings = new AppSettings();
        public static CcBibleHome Form;
        int previewsize = 0;

        public CcBibleSearch()
        {
            InitializeComponent();
            loadOldTestament();
            loadNewTestament();
        }
        public void loadOldTestament()
        {
            try
            {
                lstOldtt.Items.Clear();
                lstOldTestament.Items.Clear();
                sqlQuery = "SELECT * FROM books WHERE testament=1;";
                appDB = new AppDatabase();
                dRowCol = appDB.getList(sqlQuery);

                foreach (DataRow row in dRowCol)
                {
                    lstOldtt.Items.Add(row["title"] + " (" + row["code"] + ")");
                    lstOldTestament.Items.Add(row["title"]);
                    lstOldtt.SelectedIndex = 0;
                    lstOldTestament.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry, books listing failed: " + ex.Message, false);
            }
        }
        public void loadNewTestament()
        {
            try
            {
                lstNewtt.Items.Clear();
                lstNewTestament.Items.Clear();
                sqlQuery = "SELECT * FROM books WHERE testament=2;";
                appDB = new AppDatabase();
                dRowCol = appDB.getList(sqlQuery);

                foreach (DataRow row in dRowCol)
                {
                    lstNewtt.Items.Add(row["title"] + " (" + row["code"] + ")");
                    lstNewTestament.Items.Add(row["title"]);
                    lstNewtt.SelectedIndex = 0;
                    lstNewTestament.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry, books listing failed: " + ex.Message, false);
            }
        }
        
        private void loadFeedback(string fbmessage, bool positive = true, bool timed = false, float interval = 1000)
        {
            jsFeedback.Interval = interval == 0 ? interval : jsFeedback.Interval;
            jsFeedback.IsPositive = positive;
            jsFeedback.IsTimed = timed;
            jsFeedback.Text = fbmessage;
            jsFeedback.Visible = true;
        }

        private void tsbtnSettings_Click(object sender, EventArgs e)
        {
            AppStart.tabbedApp.Tabs.Add(new TitleBarTab(AppStart.tabbedApp)
            {
                Content = new EeSettings { Text = "Manage Preferences" }
            });
            AppStart.tabbedApp.SelectedTabIndex = 0;
        }

        // OLD TESTAMENT FUNCTIONS
        private void lstOldtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOldTestament.SelectedIndex = lstOldtt.SelectedIndex;
            txtChaptersOld.Value = 1;
            txtVersesOld.Value = 1;
            lblOldTestament.Text = lstOldTestament.Text + " " + txtChaptersOld.Value.ToString() +
                ":" + txtVersesOld.Value.ToString();
        }

        private void txtChaptersOld_ValueChanged(object sender, EventArgs e)
        {
            lblOldTestament.Text = lstOldTestament.Text + " " + txtChaptersOld.Value.ToString() + 
                ":" + txtVersesOld.Value.ToString();
        }

        private void txtVersesOld_ValueChanged(object sender, EventArgs e)
        {
            lblOldTestament.Text = lstOldTestament.Text + " " + txtChaptersOld.Value.ToString() +
                ":" + txtVersesOld.Value.ToString();
        }
        private void lblOldTestament_TextChanged(object sender, EventArgs e)
        {
            btnOldTestament.Enabled = true;
        }
        private void btnOldTestament_Click(object sender, EventArgs e)
        {
            tsbtnBook.Text = lstOldTestament.Text;
            tsbtnChapter.Text = txtChaptersOld.Value.ToString();
            tsbtnVerse.Text = txtVersesOld.Value.ToString();
        }


        // NEW TESTAMENT FUNCTIONS
        private void lstNewtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNewTestament.SelectedIndex = lstNewtt.SelectedIndex;
            txtChaptersNew.Value = 1;
            txtVersesNew.Value = 1;
            lblNewTestament.Text = lstNewTestament.Text + " " + txtChaptersNew.Value.ToString() +
                ":" + txtVersesNew.Value.ToString();
        }

        private void txtChaptersNew_ValueChanged(object sender, EventArgs e)
        {
            lblNewTestament.Text = lstNewTestament.Text + " " + txtChaptersNew.Value.ToString() +
               ":" + txtVersesNew.Value.ToString();
        }

        private void txtVersesNew_ValueChanged(object sender, EventArgs e)
        {
            lblNewTestament.Text = lstNewTestament.Text + " " + txtChaptersNew.Value.ToString() +
               ":" + txtVersesNew.Value.ToString();
        }

        private void lblNewTestament_TextChanged(object sender, EventArgs e)
        {
            btnNewTestament.Enabled = true;
        }

        private void btnNewTestament_Click(object sender, EventArgs e)
        {
            tsbtnBook.Text = lstNewTestament.Text;
            tsbtnChapter.Text = txtChaptersNew.Value.ToString();
            tsbtnVerse.Text = txtVersesNew.Value.ToString();
        }

    }
}
