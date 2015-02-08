using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    public class ArtPage
    {
        //http://www.x-art.com/ajax_process.php?action=allvideos&page=4&catname=&order=recent
        //recent

        public ArtPage()
        {
            wc = new System.Net.WebClient();
        }

        private bool _isNeedDownloadCover;

        public bool IsDownloadCoverPicture
        {
            get { return _isNeedDownloadCover; }
            set { _isNeedDownloadCover = value; }
        }

        System.Net.WebClient wc;

        CoverProcessor cp;

        public List<ArtMovie> GetVideoPage(int p)
        {
            var html = wc.DownloadString("http://www.x-art.com/ajax_process.php?action=allvideos&page=" + p + "&catname=&order=recent");

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var nodes = doc.DocumentNode.SelectNodes("//a[@class='image']");

            List<ArtMovie> list = new List<ArtMovie>();
            if (nodes == null)
            {
                return list;
            }
            foreach (var item in nodes)
            {
                var title = item.SelectSingleNode(".//b").InnerText;
                //var desc = item.SelectSingleNode(".//p").InnerText;
                var desc = item.SelectSingleNode(".//span[@class='blurb']").InnerText;
                var linker = item.Attributes["href"].Value.ToString();
                var image = item.ChildNodes["img"].Attributes["src"].Value.ToString();

                ArtMovie m = new ArtMovie()
                {
                    Title = title,
                    Url = linker,
                    Description = desc,
                    CoverLink = image,
                    Type = "Video"
                };

                if (this._isNeedDownloadCover)
                {
                    if (this.cp == null)
                    {
                        this.cp = new CoverProcessor("Covers");
                    }
                    m.CoverFile = cp.save(image, title + ".jpg");
                }
                list.Add(m);
            }
            return list;
        }

        public List<ArtMovie> GetAllUpdatePage(int p)
        {
            var html = wc.DownloadString("http://www.x-art.com/ajax_process.php?action=allupdates&page="+p+"&catname=&order=recent");

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var nodes = doc.DocumentNode.SelectNodes("//td");

            List<ArtMovie> list = new List<ArtMovie>();
            if (nodes == null)
            {
                return list;
            }
            foreach (var item in nodes)
            {
                var title = item.SelectSingleNode(".//b").InnerText;
                //var desc = item.SelectSingleNode(".//p").InnerText;
                var desc = item.SelectSingleNode(".//span[@class='blurb']").InnerText;
                var linker = item.SelectSingleNode(".//a").Attributes["href"].Value.ToString();
                var image = item.SelectSingleNode(".//img").Attributes["src"].Value.ToString();
                var publishDate = item.SelectNodes(".//span[@class='title']")[1].InnerText;
                var tpe = item.SelectNodes(".//span[@class='title']")[2].InnerText;

                ArtMovie m = new ArtMovie()
                {
                    Title = title,
                    Url = linker,
                    Description = desc,
                    CoverLink = image,
                    PublishDate = publishDate,
                    Type = tpe
                };

                if (this._isNeedDownloadCover)
                {
                    if (this.cp == null)
                    {
                        this.cp = new CoverProcessor("Covers");
                    }
                    m.CoverFile = cp.save(image, title + ".jpg");
                }
                list.Add(m);
            }
            return list;
        }

        public List<ArtModel> GetAllModels()
        {
            var html = wc.DownloadString("http://www.x-art.com/models/index.php?sort=recent&newest=1");

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var nodes = doc.DocumentNode.SelectNodes("//a[@class='image']");

            List<ArtModel> list = new List<ArtModel>();
            if (nodes == null)
            {
                return list;
            }
            foreach (var item in nodes)
            {

                var name = item.SelectSingleNode(".//span[@class='title']").InnerText;
                var ageAndCountry = item.SelectSingleNode(".//span[@class='title'][2]").InnerText;
                var country = ageAndCountry.Substring(ageAndCountry.IndexOf(":") + 1).Trim();
                var age = ageAndCountry.Substring(0,ageAndCountry.IndexOf(":")).Replace("Age","").Trim();
                
                var rate = "";
                var url = item.SelectSingleNode(".//img[@src]").Attributes["src"].Value.ToString();

                ArtModel mo = new ArtModel()
                {
                    Name = name,
                    Age = age,
                    Country = country,
                    Rate = rate,
                    PictrueUrl =url
                };

                if (this._isNeedDownloadCover)
                {
                    if (this.cp == null)
                    {
                        this.cp = new CoverProcessor("Models");
                    }
                    mo.PictureFile = cp.save(url, name + ".jpg");
                }
                list.Add(mo);
            }
            return list;
        }

    }
}
