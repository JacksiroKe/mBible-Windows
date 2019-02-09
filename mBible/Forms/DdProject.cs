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
    public partial class DdProject : Form
    {
        bool isbold;
        string[] songstanzas;
        string sqlQuery, songtext, fontxt;
        int fontsize = 0, stanzas = 0, cur_stz = 0, fontno = 1;
        AppDatabase appDB;
        SQLiteDataReader reader;
        private AppFunctions vsbf = new AppFunctions();
        private AppSettings settings = new AppSettings();
        
        public DdProject()
        {
            InitializeComponent();
            fontsize = settings.FontSizeProject;
            fontno = vsbf.fontNo(settings.FontTypeProject);
            fontxt = settings.FontTypeProject;
            isbold = settings.FontBoldProject;
        }

        private void DdProject_Load(object sender, EventArgs e)
        {
            
            try { lblSongTitle.Font = new Font(settings.FontTypeGeneral, settings.FontSizeGeneral + 3, settings.FontBoldGeneral ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
            catch (Exception) { }
            try { lblSongLabel.Font = new Font(settings.FontTypeGeneral, settings.FontSizeGeneral - 3, settings.FontBoldGeneral ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
            catch (Exception) { }
            try { lblSongno.Font = new Font(settings.FontTypeGeneral, settings.FontSizeGeneral - 3, settings.FontBoldGeneral ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
            catch (Exception) { }
            try { lblVerse.Font = new Font(settings.FontTypeGeneral, settings.FontSizeGeneral - 3, settings.FontBoldGeneral ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
            catch (Exception) { }
            try { lblSongText.Font = new Font(fontxt, fontsize, isbold ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
            catch (Exception) { }

            //grpMain.Text = "mBible v1.2.5.2 © " + DateTime.Today.Year + " " + settings.AppUser + " | " + vsbf.dateToday();
            //tmrMain.Enabled = true;
            loadSingleSong(settings.CurrentSong);
        }


        private void txtCommandLineActive()
        {

        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            //grpMain.Text = "mBible v0.1.23 © " + DateTime.Today.Year + " Jack Siro | " +
             //   vsbf.dateToday() + " " + vsbf.timeNow();
            txtCommandLine.Select();
        }

        public void loadSingleSong(int songid)
        {
            try
            {
                cur_stz = 0;
                sqlQuery = "SELECT * FROM songs WHERE songid=" + songid + ";";
                appDB = new AppDatabase();
                reader = appDB.getSingle(sqlQuery);
                while (reader.Read())
                {
                    lblSongno.Text = "#" + reader["number"].ToString();
                    lblSongTitle.Text = vsbf.textRender(reader["title"].ToString());
                    songtext = reader["content"].ToString();
                }
                appDB.sqlClose();
                songstanzas = songtext.Split('`');
                stanzas = songstanzas.Length;
                lblSongText.Text = vsbf.songRender(songstanzas[cur_stz]);
            }
            catch (Exception ex)
            {
                lblSongTitle.Text = "Song projection failed";
                lblSongText.Text = "Oops! Song projection failed due to: " + ex.Message;
            }
        }

        private void txtCommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    try
                    {
                        cur_stz = cur_stz - 1;
                        lblSongText.Text = vsbf.songRender(songstanzas[cur_stz]);
                    }
                    catch (Exception)
                    {
                        cur_stz = 0;
                        lineTop.BackColor = Color.Red;
                        tmrLinerr.Enabled = true;
                    }
                    break;
                case Keys.Down:
                    try
                    {
                        cur_stz = cur_stz + 1;
                        lblSongText.Text = vsbf.songRender(songstanzas[cur_stz]);
                    }
                    catch (Exception)
                    {
                        cur_stz = songstanzas.Length;
                        lineDown.BackColor = Color.Red;
                        tmrLinerr.Enabled = true;
                    }
                    break;
                case Keys.Subtract:
                    if (fontsize >= 10)
                    {
                        try
                        {
                            fontsize = fontsize - 3;
                            settings.FontSizeProject = fontsize;
                            lblSongText.Font = new Font(settings.FontTypeProject, settings.FontSizeProject, settings.FontBoldProject ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                        }
                        catch (Exception) { }
                    }
                    break;

                case Keys.Add:
                    if (fontsize >= 50)
                    {
                        try
                        {
                            fontsize = fontsize + 3;
                            settings.FontSizeProject = fontsize;
                            lblSongText.Font = new Font(settings.FontTypeProject, settings.FontSizeProject, settings.FontBoldProject ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                        }
                        catch (Exception) { }
                    }
                    break;

                case Keys.Left:

                    break;

                case Keys.Right:

                    break;

                case Keys.Home:

                    break;

                case Keys.End:

                    break;

                case Keys.Oemcomma:
                    if (fontsize >= 10)
                    {
                        try
                        {
                            fontsize = fontsize - 2;
                            settings.FontSizeProject = fontsize;
                            try { lblSongText.Font = new Font(fontxt, fontsize, settings.FontBoldProject ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
                            catch (Exception) { }
                        }
                        catch (Exception) { }
                    }
                    break;

                case Keys.OemPeriod:
                    if (fontsize <= 90)
                    {
                        try
                        {
                            fontsize = fontsize + 2;
                            settings.FontSizeProject = fontsize;
                            try { lblSongText.Font = new Font(fontxt, fontsize, settings.FontBoldProject ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
                            catch (Exception) { }
                        }
                        catch (Exception) { }
                    }
                    break;

                case Keys.Z:
                    if (fontno >= 0)
                    {
                        try
                        {
                            fontno = fontno - 1;
                            settings.FontTypeProject = vsbf.fonTxt(fontno);
                            try { lblSongText.Font = new Font(fontxt, fontsize, settings.FontBoldProject ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
                            catch (Exception) { }
                        }
                        catch (Exception) { }
                    }
                    break;

                case Keys.X:
                    if (fontno <= 11)
                    {
                        try
                        {
                            fontno = fontno + 1;
                            settings.FontTypeProject = vsbf.fonTxt(fontno);
                            try { lblSongText.Font = new Font(fontxt, fontsize, isbold ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
                            catch (Exception) { }
                        }
                        catch (Exception) { }
                    }
                    break;

                case Keys.C:

                    break;

                case Keys.V:

                    break;

                case Keys.B:
                    try
                    {
                        if (isbold == true)
                        {
                            settings.FontBoldProject = false;
                            isbold = false;
                        }
                        else if (isbold == false)
                        {
                            settings.FontBoldProject = true;
                            isbold = true;
                        }
                        try { lblSongText.Font = new Font(fontxt, fontsize, isbold ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))); }
                        catch (Exception) { }
                    }
                    catch (Exception) { }
                    break;

                case Keys.Escape:
                    Close();
                    break;
            }
        }
      
        private void tblMain_Paint(object sender, PaintEventArgs e)
        {
            txtCommandLineActive();
        }

        private void lblSongLabel_Click(object sender, EventArgs e)
        {
            txtCommandLineActive();
        }

        private void lblSongno_Click(object sender, EventArgs e)
        {
            txtCommandLineActive();
        }

        private void tblBottom_Paint(object sender, PaintEventArgs e)
        {
            txtCommandLineActive();
        }

        private void lblSongText_Click(object sender, EventArgs e)
        {
            txtCommandLineActive();
        }

        private void lblVerse_Click(object sender, EventArgs e)
        {
            txtCommandLineActive();
        }

        private void lblSongTitle_Click(object sender, EventArgs e)
        {
            txtCommandLineActive();
        }

        private void lineTop_Click(object sender, EventArgs e)
        {
            txtCommandLineActive();
        }

        private void lineDown_Click(object sender, EventArgs e)
        {
            txtCommandLineActive();
        }

        private void grpMain_Enter(object sender, EventArgs e)
        {
            txtCommandLineActive();
        }

        private void tmrLinerr_Tick(object sender, EventArgs e)
        {
            lineTop.BackColor = Color.White;
            lineDown.BackColor = Color.White;
            tmrLinerr.Enabled = false;
        }


    }
}
