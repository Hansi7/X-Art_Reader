using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    public class HegrePage
    {
        public HegrePage()
        {


        }

        private bool _isNeedDownloadCover = false;

        public bool IsDownloadCoverPicture
        {
            get { return _isNeedDownloadCover; }
            set { _isNeedDownloadCover = value; }
        }

        private bool _isNeedDownloadBoard = false;

        public bool IsDownloadBoardPicture
        {
            get { return _isNeedDownloadBoard; }
            set { _isNeedDownloadBoard = value; }
        }

        System.Net.WebClient wc = new System.Net.WebClient();

        HtmlAgilityPack.HtmlWeb hw = new HtmlAgilityPack.HtmlWeb();

        CoverProcessor cp = null;

        public List<ArtMovie> GetGalleries(int page)
        {
            List<ArtMovie> HegreGalleries = new List<ArtMovie>();
            HtmlAgilityPack.HtmlDocument doc = hw.Load("http://www.hegre-art.com/galleries?galleries_page=" + page.ToString());

            var nodes = doc.DocumentNode.SelectNodes("//div[@class='item']");
            if (nodes == null)
            {
                return HegreGalleries;
            }
            foreach (var item in nodes)
            {
                var title = item.SelectSingleNode(".//h4").InnerText.Trim();
                title = title.Substring(title.IndexOf("\t\t\t\t\t\t")).Trim();
                var date = item.SelectSingleNode(".//h4/small").InnerText.Trim();
                var link = item.SelectSingleNode("./div/a").Attributes["href"].Value.ToString().Trim();
                var coverPicURL = item.SelectSingleNode(".//div[@class='cover-links']/a[1]").Attributes["href"].Value.ToString().Trim();
                var boardPicURL = item.SelectSingleNode(".//div[@class='cover-links']/a[2]").Attributes["href"].Value.ToString().Trim();

                ArtMovie m = new ArtMovie()
                {
                    Title = title,
                    Url = link,
                    Type = "Images",
                    CoverLink = coverPicURL,
                    CoverLink2 = boardPicURL
                };

                if (this.IsDownloadCoverPicture)
                {

                    if (this.cp == null)
                    {
                        this.cp = new CoverProcessor("HegreCovers");
                    }
                    m.CoverFile = cp.save(coverPicURL, title + ".jpg");

                }
                if (this.IsDownloadBoardPicture)
                {
                    if (this.cp == null)
                    {
                        this.cp = new CoverProcessor("HegreCovers");
                    }
                    m.CoverFile2 = cp.save(boardPicURL, title + "_Board.jpg");
                }
                OnCompleteOneItem(m.Title);
                HegreGalleries.Add(m);
            }
            return HegreGalleries;
        }

        public List<ArtMovie> GetVideos(int page)
        {
            List<ArtMovie> HegreVideos = new List<ArtMovie>();
            HtmlAgilityPack.HtmlDocument doc = hw.Load("http://www.hegre-art.com/galleries?galleries_page=" + page.ToString());

            var nodes = doc.DocumentNode.SelectNodes("//div[@class='item']");

            if (nodes == null)
            {
                return HegreVideos;
            }
            foreach (var item in nodes)
            {
                var title = item.SelectSingleNode("./div/a").Attributes["title"].Value.ToString().Trim();
                var link = item.SelectSingleNode("./div/a").Attributes["href"].Value.ToString().Trim();
                var coverPicUrl = item.SelectSingleNode(".//div[@class='cover-links']/a[1]").Attributes["href"].Value.ToString().Trim();
                var boardPicUrl = item.SelectSingleNode(".//div[@class='cover-links']/a[2]").Attributes["href"].Value.ToString().Trim();
                

                ArtMovie m = new ArtMovie()
                {
                    Title = title,
                    Url = link,
                    Type = "Videos",
                    CoverLink = coverPicUrl,
                    CoverLink2 = boardPicUrl
                };

                if (this.IsDownloadCoverPicture)
                {

                    if (this.cp == null)
                    {
                        this.cp = new CoverProcessor("HegreCovers");
                    }
                    m.CoverFile = cp.save(coverPicUrl, title + ".jpg");

                }
                if (this.IsDownloadBoardPicture)
                {
                    if (this.cp == null)
                    {
                        this.cp = new CoverProcessor("HegreCovers");
                    }
                    m.CoverFile2 = cp.save(boardPicUrl, title + "_Board.jpg");
                }
                OnCompleteOneItem(m.Title);
                HegreVideos.Add(m);
            }
            return HegreVideos;

        }

        public event EventHandler<OneCompleteEventArg> CompleteOneItem;

        protected virtual void OnCompleteOneItem(string something) 
        {
            if (this.CompleteOneItem!=null)
            {
                this.CompleteOneItem(this, new OneCompleteEventArg(something));
            }
        }
    }
}
