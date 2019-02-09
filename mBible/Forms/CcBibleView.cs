using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Finisar.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mBible
{
    public partial class CcBibleView : Form
    {
        string sqlQuery;
        AppDatabase appDB;
        SQLiteDataReader reader;
        DataRowCollection dRowCol;
        private AppFunctions vsbf = new AppFunctions();
        private AppSettings settings = new AppSettings();
        public static CcBibleHome Form;
        int previewsize = 0;

        public CcBibleView()
        {
            InitializeComponent();            
            loadBooks();
        }

        private void CcBibleView_Resize(object sender, EventArgs e)
        {
            //InitializeComponent();
            //loadBooks();
        }

        private void loadFeedback(string fbmessage, bool positive = true, bool timed = false, float interval = 1000)
        {
            jsFeedback.Interval = interval == 0 ? interval : jsFeedback.Interval;
            jsFeedback.IsPositive = positive;
            jsFeedback.IsTimed = timed;
            jsFeedback.Text = fbmessage;
            jsFeedback.Visible = true;
        }

        private void CcBibleView_Load(object sender, EventArgs e)
        {
            btnSearchAll.IsOn = settings.SearchAllBooks;
            tsbtnBold.Checked = settings.FontBoldPreview;
            previewsize = settings.FontSizePreview;

            try { lstSongResults.Font = new Font(settings.FontTypeGeneral, settings.FontSizeGeneral, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); } 
            catch (Exception) { }
            try { txtSongContent.Font = new Font(settings.FontTypePreview, settings.FontSizePreview, settings.FontBoldPreview ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); } 
            catch (Exception) { }

        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            settings.SearchAllBooks = btnSearchAll.IsOn;
            seachForSongs(txtSearch.Text, btnSearchAll.IsOn);
        }
                
        private void grpCriteria_Enter(object sender, EventArgs e)
        {
            if (btnSearchAll.IsOn) btnSearchAll.IsOn = false;
            else btnSearchAll.IsOn = true;
            settings.SearchAllBooks = btnSearchAll.IsOn;
            seachForSongs(txtSearch.Text, btnSearchAll.IsOn);
        }
        
        private void lblSearchAll_Enter(object sender, EventArgs e)
        {
            if (btnSearchAll.IsOn) btnSearchAll.IsOn = false;
            else btnSearchAll.IsOn = true;
            settings.SearchAllBooks = btnSearchAll.IsOn;
            seachForSongs(txtSearch.Text, btnSearchAll.IsOn);
        }
        private void lblSearchAll_Click(object sender, EventArgs e)
        {
            if (btnSearchAll.IsOn) btnSearchAll.IsOn = false;
            else btnSearchAll.IsOn = true;
            settings.SearchAllBooks = btnSearchAll.IsOn;
            seachForSongs(txtSearch.Text, btnSearchAll.IsOn);
        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBookcodes.SelectedIndex = cmbBooks.SelectedIndex;
        }

        private void lstBookcodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBookSongs(lstBookcodes.Text);
        }

        private void lstSongResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSongids.SelectedIndex = lstSongResults.SelectedIndex;
        }

        private void lstSongids_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSingleSong(Int32.Parse(lstSongids.Text));
        }
        public void loadBooks()
        {
            try
            {
                cmbBooks.Items.Clear();
                lstBookcodes.Items.Clear();
                sqlQuery = "SELECT * FROM books WHERE state=1;";
                appDB = new AppDatabase();
                dRowCol = appDB.getList(sqlQuery);
                
                foreach (DataRow row in dRowCol)
                {
                    cmbBooks.Items.Add(row["title"] + " (" + row["songs"] + ")");
                    lstBookcodes.Items.Add(row["code"]);
                    cmbBooks.SelectedIndex = 0;
                    lstBookcodes.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry, books listing failed: " + ex.Message, false);
            }
        }

        public void loadBookSongs(string code)
        {
            try
            {
                lstSongResults.Items.Clear();
                lstSongids.Items.Clear();
                
                sqlQuery = "SELECT songid, number, title FROM songs WHERE book='" + code + "';";
                appDB = new AppDatabase();
                dRowCol = appDB.getList(sqlQuery);
                
                foreach (DataRow row in dRowCol)
                {
                    lstSongResults.Items.Add(row["number"] + "# " + row["title"]);
                    lstSongids.Items.Add(row["songid"]);
                    lstSongResults.SelectedIndex = 0;
                    lstSongids.SelectedIndex = 0;
                }
                grpSongResults.Text = lstSongResults.Items.Count + " " + lstBookcodes.Text + " songs found";
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry, songs listing failed: " + ex.Message, false);
            }
        }
        
        
        
        public void loadSingleSong(int songid)
        {
            try
            {
                txtSongContent.Clear();
                sqlQuery = "SELECT * FROM songs WHERE songid=" + songid + ";";
                appDB = new AppDatabase();
                reader = appDB.getSingle(sqlQuery);
                while (reader.Read())
                {
                    txtSongContent.Text = vsbf.songRender(reader["content"].ToString());
                }
                appDB.sqlClose();
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry song viewing failed: " + ex.Message, false, true);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    //if (txtSearch.ContainsFocus) 
                        seachForSongs(txtSearch.Text, btnSearchAll.IsOn);
                    break;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
        }

        private void tsbtnProject_Click(object sender, EventArgs e)
        {
            //settings.setValue("current_song", lstSongids.Text);
            settings.CurrentSong = Int32.Parse(lstSongids.Text);
            DdProject project = new DdProject();
            project.Show();
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            settings.SelectedBook = cmbBooks.SelectedIndex;
            settings.SelectedSong = Int32.Parse(lstSongids.Text);
            //DdSongEdit editsong = new DdSongEdit();
            //editsong.Show();
        }

        private void tsbtnLast_Click(object sender, EventArgs e)
        {
            try
            {
                lstSongResults.SelectedIndex = lstSongResults.SelectedIndex - 1;
            }
            catch (Exception)
            {
                loadFeedback("Oops! Sorry, there no song before the current song ...", false, true);
            }
        }

        private void tsbtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                lstSongResults.SelectedIndex = lstSongResults.SelectedIndex + 1;
            }
            catch (Exception)
            {
                loadFeedback("Oops! Sorry, there no song after the current song ...", false, true);
            }
        }

        private void tsbtnSmaller_Click(object sender, EventArgs e)
        {
            if (previewsize >= 10)
            {
                try
                {
                    previewsize = previewsize - 2;
                    settings.FontSizePreview = previewsize;
                    txtSongContent.Font = new Font(settings.FontTypePreview, settings.FontSizePreview, settings.FontBoldPreview ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
                catch (Exception)
                {
                    loadFeedback("Oops! Sorry, the font can't get smaller than the current font size ...", false, true);
                }
            }
        }

        private void tsbtnBigger_Click(object sender, EventArgs e)
        {
            if (previewsize <= 50)
            {
                try
                {
                    previewsize = previewsize + 2;
                    settings.FontSizePreview = previewsize;
                    txtSongContent.Font = new Font(settings.FontTypePreview, settings.FontSizePreview, settings.FontBoldPreview ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
                catch (Exception)
                {
                    loadFeedback("Oops! Sorry, the font can't get bigger than the current font size ...", false, true);
                }
            }
        }

        private void tsbtnFont_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnBold_Click(object sender, EventArgs e)
        {
            try
            {
                if (tsbtnBold.Checked == true)
                {
                    settings.FontBoldPreview = false;
                    tsbtnBold.Checked = false;
                }
                else if (tsbtnBold.Checked == false)
                {
                    settings.FontBoldPreview = true;
                    tsbtnBold.Checked = true;
                }
                txtSongContent.Font = new Font(settings.FontTypePreview, settings.FontSizePreview, tsbtnBold.Checked ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            }
            catch (Exception)
            {
                loadFeedback("Oops! Sorry, an unknown error has occured ...");
            }
        }
        private void tsbtnCopy_Click(object sender, EventArgs e)
        {
            txtSongContent.Copy();
            //txtSongContent.SelectedText;
        }

        private void tsbtnSelect_Click(object sender, EventArgs e)
        {
            txtSongContent.SelectAll();
        }

        private void tsbtnPrint_Click(object sender, EventArgs e)
        {
            loadFeedback("Oops! Sorry, that feature will be available in the next update ...");
        }

                
        private void CcBibleView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //opentabs = opentabs - 1;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength >= 1) btnClear.Visible = true;
            else btnClear.Visible = false;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    try
                    {
                        seachForSongs(txtSearch.Text, btnSearchAll.IsOn);
                    }
                    catch (Exception)
                    {
                        //do nothing at all
                    }
                    break;
            }
        }
        public void seachForSongs(string searchstr, bool criteria)
        {
            if (txtSearch.Text != "Search for Songs")
            {
                try
                {
                    lstSongResults.Items.Clear();
                    lstSongids.Items.Clear();

                    string searchcriteria = "";
                    if (!criteria) searchcriteria = " AND book='" + lstBookcodes.Text + "'";

                    if (searchstr.Length < 5)
                    {
                        sqlQuery = "SELECT songid, number, title FROM songs " +
                            "WHERE number=" + int.Parse(searchstr) + searchcriteria + ";";
                    }
                    else
                    {
                        sqlQuery = "SELECT songid, number, title FROM songs " +
                            "WHERE title LIKE '%" + searchstr + "%' " + searchcriteria +
                            "OR content LIKE '%" + searchstr + searchcriteria + "%';";
                    }

                    appDB = new AppDatabase();
                    dRowCol = appDB.getList(sqlQuery);

                    foreach (DataRow row in dRowCol)
                    {
                        lstSongResults.Items.Add(row["number"] + "# " + row["title"]);
                        lstSongids.Items.Add(row["songid"]);
                        lstSongResults.SelectedIndex = 0;
                        lstSongids.SelectedIndex = 0;
                    }
                    grpSongResults.Text = lstSongResults.Items.Count + " songs found with '" + searchstr + "'";
                }
                catch (Exception ex)
                {
                    loadFeedback("Oops! Sorry, songs searching has failed due to the error: " + ex.Message, false);
                }
            }

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.SelectAll();
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

    }
}
