using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace X_Art_View
{
    public class MagnetGet
    {
        public MagnetGet()
        {
            Source = MagnetSource.KickAssTo;
        }
        SourceDB DB = new SourceDB();
        CookiesWebClient wc = new CookiesWebClient();

        public string TryToFind(string keyWord)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(wc.DownloadString(DB.Table.Rows[0][1]+ keyWord));
            doc.DocumentNode.SelectNodes("//tr[@class='odd'] or tr[@class='even']");//这没有完成
            return string.Empty;
        }

        public MagnetSource Source { get; set; }


        public event EventHandler GetDone;
        protected virtual void raiseGetDoneEvent()
        {
            if (this.GetDone != null)
            {
                GetDone(this, new EventArgs());
            }
        }

    }
    public enum MagnetSource
    {
        KickAssTo = 1,
        Extratorrent = 2,
    }

    public class SourceDB
    {
        System.Data.DataTable dt = new System.Data.DataTable();
        public System.Data.DataTable Table
        {
            get { return dt; }
            set { dt = value; }
        }
        public SourceDB()
        {
            System.Data.DataColumn[] columns = new System.Data.DataColumn[5];
            columns[0] = new System.Data.DataColumn("Name");//网站标识，并非Xpath
            columns[1] = new System.Data.DataColumn("URL");//网站地址，后面加关键字就是搜索了，并非Xpath
            columns[2] = new System.Data.DataColumn("XList");//应用此XPath获得列表
            columns[3] = new System.Data.DataColumn("XItem");//应用此XPath获得某条目
            columns[4] = new System.Data.DataColumn("XLink");//应用此XPath获得某链接

            dt.Columns.AddRange(columns);

            dt.Rows.Add("kickass", "http://kat.cr/usearch/", "xixix", "fffff", "55555");
            dt.Rows.Add("extraTo", "http://extratorrent.cc/search/?new=1&x=0&y=0&search=", "xxxx", "xxxx", "xxxx");



        }


    }

}
