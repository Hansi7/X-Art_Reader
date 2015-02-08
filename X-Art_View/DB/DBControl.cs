using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace X_Art_View.DB
{
    public class DBControl
    {
        public DBControl()
        { 
            
        }
        string connectString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\art.accdb";
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\art.accdb");
        public void CloseConn()
        {
            conn.Close();
            
        }
        public bool Insert(ArtMovie m)
        {
            using (OleDbCommand comm = new OleDbCommand("insert into x (title,referurl,coverurl,coverurl2,coverfile,coverfile2,ismovie,localpath,datepublish,tag) values(@t, @r,@c,@c2,@cf,@cf2,@i,@local,@date,@tag) ",conn))
            {
                comm.Parameters.Add("@t", OleDbType.VarWChar).Value =m.Title;
                comm.Parameters.Add("@r", OleDbType.VarWChar).Value =m.Url;
                comm.Parameters.Add("@c", OleDbType.VarWChar).Value = m.CoverLink;
                comm.Parameters.Add("@c2", OleDbType.VarWChar).Value = m.CoverLink2;
                comm.Parameters.Add("@cf", OleDbType.VarWChar).Value = m.CoverFile;
                comm.Parameters.Add("@cf2", OleDbType.VarWChar).Value = m.CoverFile2;
                if (m.Type.IndexOf("mages")!=-1)
                {
                    comm.Parameters.Add("@i", OleDbType.Boolean).Value = false;
                }
                else
                {
                    comm.Parameters.Add("@i", OleDbType.Boolean).Value = true;
                }
                comm.Parameters.Add("@local", OleDbType.VarWChar).Value = "";
                comm.Parameters.Add("@date", OleDbType.Date).Value = DateTime.Parse(m.PublishDate);
                comm.Parameters.Add("@tag", OleDbType.VarWChar).Value = "";
                if (conn.State== System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                
                if (comm.ExecuteNonQuery()>0)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
        }
        
    }
}
