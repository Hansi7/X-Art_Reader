using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.OleDb;
using System.Data.SQLite;

namespace X_Art_View.DB
{
    public class DBControl
    {
        public DBControl()
        {
            DBConfig.DatabaseFile = System.AppDomain.CurrentDomain.BaseDirectory + "Art.db";
        }
        public void Insert(ArtMovie m)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic["title"] = m.Title;
            dic["referurl"] = m.Url;
            dic["coverurl"] = m.CoverLink;
            dic["coverurl2"] = m.CoverLink2;
            dic["coverfile"] = m.CoverFile;
            dic["coverfile2"] = m.CoverFile2;
            dic["ismovie"] = m.Type.IndexOf("mages") != -1 ? true : false;
            dic["localpath"] = "";
            dic["datepublish"] = m.PublishDate;
            dic["tag"] = "";

            #region OLD 旧的方法
            using (SQLiteConnection conn = new SQLiteConnection(DBConfig.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.Insert("X", dic);
                    conn.Close();
                }
            }
            #endregion
        }

        public void InsertMany(List<ArtMovie> arts)
        {
            using (SQLiteConnection conn = new SQLiteConnection(DBConfig.DataSource))
            {
                conn.Open();
                var trans = conn.BeginTransaction();

                SQLiteCommand cmd = new SQLiteCommand();
                SQLiteHelper sh = new SQLiteHelper(cmd);
                    foreach (var m in arts)
                    {
                        Dictionary<string, object> dic = new Dictionary<string, object>();
                        dic["title"] = m.Title;
                        dic["referurl"] = m.Url;
                        dic["coverurl"] = m.CoverLink;
                        dic["coverurl2"] = m.CoverLink2;
                        dic["coverfile"] = m.CoverFile;
                        dic["coverfile2"] = m.CoverFile2;
                        dic["ismovie"] = m.Type.IndexOf("mages") != -1 ? true : false;
                        dic["localpath"] = "";
                        dic["datepublish"] = m.PublishDate;
                        dic["tag"] = "";
                        cmd.Connection = conn;
                        
                        sh.Insert("X", dic);
                    }
                
                trans.Commit();
                conn.Close();
            }
        }

        public void CreateDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DBConfig.DataSource))
            {
                SQLiteConnection.CreateFile(DBConfig.DatabaseFile);
                //System.Data.SQLite.SQLiteConnectionStringBuilder connstr = new System.Data.SQLite.SQLiteConnectionStringBuilder();
                //connstr.DataSource = DBConfig.DataSource;
                ////connstr.Password = "admin";//设置密码，SQLite ADO.NET实现了数据库密码保护
                //conn.ConnectionString = connstr.ToString();
                conn.Open();
                //创建表
                System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand();
                cmd.Connection = conn;
                System.Data.SQLite.SQLiteHelper help = new SQLiteHelper(cmd);
                SQLiteTable table = new SQLiteTable("X");
                table.Columns.Add(new SQLiteColumn("ID", ColType.Integer, true, true, true, null));
                table.Columns.Add(new SQLiteColumn("Title", ColType.Text));
                table.Columns.Add(new SQLiteColumn("ReferURL", ColType.Text));
                table.Columns.Add(new SQLiteColumn("CoverURL", ColType.Text));
                table.Columns.Add(new SQLiteColumn("CoverURL2", ColType.Text));
                table.Columns.Add(new SQLiteColumn("CoverFile", ColType.Text));
                table.Columns.Add(new SQLiteColumn("CoverFile2", ColType.Text));
                table.Columns.Add(new SQLiteColumn("IsMovie", ColType.Boolean));
                table.Columns.Add(new SQLiteColumn("LocalPath", ColType.Text));
                table.Columns.Add(new SQLiteColumn("DatePublish", ColType.Text));
                table.Columns.Add(new SQLiteColumn("Tag", ColType.Text));

                help.CreateTable(table);

                conn.Close();
            }
        }


    }
}
