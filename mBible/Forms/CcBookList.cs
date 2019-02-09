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
    public partial class CcBookList : Form
    {
        string sqlQuery;
        AppDatabase appDB;
        SQLiteDataReader reader;
        DataRowCollection dRowCol;
        private AppFunctions vsbf = new AppFunctions();
        private AppSettings settings = new AppSettings();
        public CcBookList()
        {
            InitializeComponent();
            
        }

        private void CcBookList_Load(object sender, EventArgs e)
        {
            loadBooks();
        }

        private void loadFeedback(string fbmessage, bool positive = true, bool timed = false, float interval = 1000)
        {
            jsFeedback.Interval = interval == 0 ? interval : jsFeedback.Interval;
            jsFeedback.IsPositive = positive;
            jsFeedback.IsTimed = timed;
            jsFeedback.Text = fbmessage;
            jsFeedback.Visible = true;
        }

        public void loadBooks()
        {
            try
            {
                lstBooks.Items.Clear();
                lstBookids.Items.Clear();
                sqlQuery = "SELECT * FROM books;";
                appDB = new AppDatabase();
                dRowCol = appDB.getList(sqlQuery);

                foreach (DataRow row in dRowCol)
                {
                    lstBooks.Items.Add(row["title"] + " (" + row["songs"] + ")");
                    lstBookids.Items.Add(row["bookid"]);
                    lstBooks.SelectedIndex = 0;
                    lstBookids.SelectedIndex = 0;
                }
                grpBookResults.Text = lstBooks.Items.Count + " books exist currently";
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry, books listing failed: " + ex.Message, false);
            }
        }
        
        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBookids.SelectedIndex = lstBooks.SelectedIndex;
        }

        private void lstBookids_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBookDetails(lstBookids.Text);
        }

        public void loadBookDetails(string songid)
        {
            try
            {
                txtNotes.Clear();
                sqlQuery = "SELECT * FROM books WHERE bookid=" + songid + ";";
                appDB = new AppDatabase();
                reader = appDB.getSingle(sqlQuery);
                while (reader.Read())
                {
                    txtBookTitle.Text = reader["title"].ToString();
                    txtBookCode.Text = reader["code"].ToString();
                    txtNotes.Text = reader["notes"].ToString();
                    lblInfo.Text = reader["songs"].ToString() + " songs";
                }
                appDB.sqlClose();
            }
            catch (Exception ex)
            {
                loadFeedback("Oops! Sorry book viewing failed: " + ex.Message, false, true);
            }
        }

        private void clearFields()
        {
            txtBookCode.box.Clear();
            txtBookTitle.box.Clear();
            txtNotes.Clear();
            lblInfo.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            appDB = new AppDatabase();
            bool newbook = appDB.addNewBook(txtBookTitle.Text, txtBookCode.Text, txtNotes.Text);
            if (newbook)
            {
                loadFeedback("A new book has been added successfully!", true, true);
                loadBooks();
            }
            clearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            appDB = new AppDatabase();
            bool editbook = appDB.editBook(lstBookids.Text, txtBookTitle.Text, txtBookCode.Text, txtNotes.Text);
            if (editbook)
            {
                loadFeedback("A new book has been added successfully!", true, true);
                loadBooks();
            }
            loadBooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loadFeedback("Are you sure you want to delete this book?", true);
            loadBooks();
        }

    }
}
