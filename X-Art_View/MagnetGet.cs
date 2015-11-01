using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace X_Art_View
{
    public class MagnetGet
    {
        CookiesWebClient wc = new CookiesWebClient();
        public List<MagnetResult> GetMagLink_Kat_cr(string keyWord)
        {
            HtmlDocument doc = new HtmlDocument();
            List<MagnetResult> result = new List<MagnetResult>();
            doc.LoadHtml(wc.DownloadString("http://kat.cr/usearch/"+ keyWord));
            var nodes1 = doc.DocumentNode.SelectNodes("//tr[@class='odd']");
            var nodes2 = doc.DocumentNode.SelectNodes("//tr[@class='even']");
            Console.WriteLine(nodes1.Count);
            Console.WriteLine(nodes2.Count);
            var nodesTotal = nodes1.Union(nodes2);
            foreach (var item in nodesTotal)
            {
                var name = item.SelectSingleNode(".//a[@class='cellMainLink']").InnerText;
                var link = item.SelectSingleNode(".//a[@title='Torrent magnet link']").Attributes["href"].Value;
                var size = item.SelectSingleNode(".//td[@class='nobr center']").InnerText;

                MagnetResult r = new MagnetResult()
                {
                    Title = name,
                    MagLink = link,
                    Size = size.Replace("&nbsp;","")
                };
                result.Add(r);
            }
            return result;
        }
        public List<MagnetResult> GetMagLink_Extratorrent_cc(string keyWord)
        {
            HtmlDocument doc = new HtmlDocument();
            List<MagnetResult> result = new List<MagnetResult>();
            List<string> trHtml = new List<string>();
            doc.LoadHtml(wc.DownloadString("http://extratorrent.cc/search/?new=1&x=0&y=0&search=" + keyWord));
            //var ddd =  doc.DocumentNode.SelectSingleNode("//table");
            var nodes1 = doc.DocumentNode.SelectNodes("//table[@class='tl']/tr[@class='tlr']");
            var nodes2 = doc.DocumentNode.SelectNodes("//table[@class='tl']/tr[@class='tlz']");

            foreach (var item in nodes1)
            {
                trHtml.Add(item.OuterHtml);
            }
            foreach (var item in nodes2)
            {
                trHtml.Add(item.OuterHtml);
            }
            var fn = System.DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".txt";

            for (int i = 0; i < trHtml.Count; i++)
            {
                System.IO.File.AppendAllText(fn, trHtml[i] + "\r\n");
                
            }
            //System.Diagnostics.Process.Start(fn);

            foreach (var item in trHtml)
            {
                doc.LoadHtml(item);


                var name = doc.DocumentNode.SelectSingleNode("//td[@class='tli']/a").InnerText;
                var itemlink = doc.DocumentNode.SelectSingleNode("//td[@class='tli']/a").Attributes["href"].Value;
                var size = doc.DocumentNode.SelectSingleNode("//td[@class='tli']").NextSibling.InnerText;
                System.Net.WebClient wc2 = new System.Net.WebClient();
                var itemHtml =  wc2.DownloadString("http://extratorrent.cc" + itemlink);
                doc.LoadHtml(itemHtml);
                var link = doc.DocumentNode.SelectSingleNode("//a[@title='Magnet link']").Attributes["href"].Value;
                MagnetResult r = new MagnetResult()
                {
                    Title = name,
                    MagLink = link,
                    Size = size.Replace("&nbsp;","")
                };
                result.Add(r);
            }
            return result;
        }
    }
}
