using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Finisar.SQLite;
using System.Threading.Tasks;

namespace mBible
{
   
    public class AppDatabase
    {
        SQLiteConnection sConn;
        SQLiteCommand sCmd;
        SQLiteDataAdapter sAdapter = null;
        DataSet dS = null;
        DataTable dT = new DataTable();
        SQLiteDataReader reader;
        DataRowCollection dRowCol;

        public AppDatabase()
        {
            sConn = new SQLiteConnection("Data Source=mBible.db;New=False;Version=3");
            sConn.Open();
        }

        public DataRowCollection getList(string CommandText)
        {
            dS = new DataSet();
            sAdapter = new SQLiteDataAdapter(CommandText, sConn);
            sAdapter.Fill(dS);
            dRowCol = dS.Tables[0].Rows;
            sqlClose();
            return dRowCol;
        }
        public SQLiteDataReader getSingle(string CommandText)
        {
            sCmd = new SQLiteCommand(CommandText, sConn);
            reader = sCmd.ExecuteReader();
            return reader;
        }

        public bool addNewSong(string book, string number, string title, string content, string key, string notes, string author)
        {
            bool result = false;
            try
            {
                sCmd = new SQLiteCommand("INSERT INTO songs " +
                "(book, number, title, content, key, notes, author, created) VALUES('" +
                book + "', '" + number + "', '" + title + "', '" + content + "', '" +
                key + "', '" + notes + "', '" + author + "', '" + todate() + "')", sConn);
                sCmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
         
        public bool editSong(int songid, string book, string number, string title, string content, string key, string notes, string author)
        {
            bool result = false;
            try
            {
                sCmd = new SQLiteCommand("UPDATES songs SET book='" + book + "', number='" +
                    number + "', title='" + title + "', content='" + content + "', key='" + key + 
                    "', notes='" + notes + "', author='" + author + "', updated='" + todate() + 
                    "' WHERE songid=" + songid, sConn);
                sCmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool addNewBook(string title, string code, string content)
        {
            bool result = false;
            try
            {
                sCmd = new SQLiteCommand("INSERT INTO books " +
                "(title, code, content, created) VALUES('" +
                title + "', '" + code + "', '" + content + "', '" + "', '" + todate() + "')", sConn);
                sCmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool editBook(string bookid, string title, string code, string content)
        {
            bool result = false;
            try
            {
                sCmd = new SQLiteCommand("UPDATES songs SET title='" + title + "', code='" +
                    code + "', content='" + content + "', updated='" + todate() +
                    "' WHERE bookid=" + bookid, sConn);
                sCmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public void songsUpdate(string code, int songs)
        {
            try
            {
                sCmd = new SQLiteCommand("UPDATES books SET songs='" + songs.ToString() + "', updated='" +
                    todate() + "' WHERE code=" + code, sConn);
                sCmd.ExecuteNonQuery();
            }
            catch (Exception) { }
        }
        public string todate()
        {
            return DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
        }

        public void sqlClose()
        {
            sConn.Close();
        }

    }
}
