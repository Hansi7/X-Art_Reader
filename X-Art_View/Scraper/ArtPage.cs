using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    public class ArtPage:IMovieScraper
    {
        //http://www.x-art.com/ajax_process.php?action=allvideos&page=4&catname=&order=recent
        //recent

        public ArtPage()
        {
            wc = new System.Net.WebClient();
            this.DisplayName = "X-Art";
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
            var html = wc.DownloadString("http://www.x-art.com/index.php?show=videos&pref=items&page=" + p + "&catname=All&order=recent");

            string[] sep = new string[] { "<!--------------------------------------- ITEM -->", "<!--------------------------------------- finItem -->" };
            var itemHtml = html.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            List<string> item12 = new List<string>();
            for (int i = 0; i < itemHtml.Length; i++)
            {
                itemHtml[i] = itemHtml[i].Replace("\\n", "");
                itemHtml[i] = itemHtml[i].Replace("\\", "");
                itemHtml[i] = itemHtml[i].Trim();
                if (itemHtml[i] != "")
                {
                    item12.Add(itemHtml[i]);
                }
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            List<ArtMovie> list = new List<ArtMovie>();
            for (int i = 1; i < item12.Count - 1; i++)
            {
                doc.LoadHtml(item12[i]);

                if (doc.DocumentNode.SelectSingleNode("//h1") == null)
                {
                    continue;
                }

                var title = doc.DocumentNode.SelectSingleNode("//h1").InnerText;
                //var desc = item.SelectSingleNode(".//p").InnerText;
                
                var descNullable = doc.DocumentNode.SelectSingleNode("//p");
                string desc = "";
                if (descNullable != null)
                {
                    desc = descNullable.InnerText;
                }
                var linker = doc.DocumentNode.SelectSingleNode("//a").Attributes["href"].Value;
                var image = doc.DocumentNode.SelectSingleNode("//img").Attributes["src"].Value;

                var publishDate = doc.DocumentNode.SelectSingleNode("//h2").InnerText.Trim();
                var tpe = doc.DocumentNode.SelectSingleNode("//h2[1]").InnerText.Trim();

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
                OnCompleteOneItem(m);
                list.Add(m);

            }
            return list;
        }
        public List<ArtMovie> GetAllUpdate(int p)
        {
            var html = wc.DownloadString("http://www.x-art.com/index.php?show=galleries&pref=items&page=" + p + "&catname=all&order=recent");

            string[] sep = new string[] { "<!--------------------------------------- ITEM -->", "<!--------------------------------------- finItem -->" };
            var itemHtml = html.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            List<string> item12 = new List<string>();
            for (int i = 0; i < itemHtml.Length; i++)
            {
                itemHtml[i] = itemHtml[i].Replace("\\n", "");
                itemHtml[i] = itemHtml[i].Replace("\\", "");
                itemHtml[i] = itemHtml[i].Trim();
                if (itemHtml[i] != "")
                {
                    item12.Add(itemHtml[i]);
                }
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            List<ArtMovie> list = new List<ArtMovie>();
            for (int i = 1; i < item12.Count - 1; i++)
            {
                doc.LoadHtml(item12[i]);

                var title = doc.DocumentNode.SelectSingleNode("//h1").InnerText;
                //var desc = item.SelectSingleNode(".//p").InnerText;

                var descNullable = doc.DocumentNode.SelectSingleNode("//p");
                string desc="";
                if (descNullable != null)
                {
                    desc = descNullable.InnerText;
                }
                var linker = doc.DocumentNode.SelectSingleNode("//a").Attributes["href"].Value;
                var image = doc.DocumentNode.SelectSingleNode("//img").Attributes[0].Value;
                System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("http://.*?jpg");
                var matches = reg.Matches(image);

                if (matches.Count>0)
                {
                    image = matches[0].ToString();
                }
                var publishDate = doc.DocumentNode.SelectSingleNode("//h2").InnerText.Trim();
                var tpe = doc.DocumentNode.SelectSingleNode("//h2[1]").InnerText.Trim();

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
                OnCompleteOneItem(m);
                list.Add(m);

            }
            return list;
        }
        public List<ArtModel> GetAllModels()
        {
            var urlModel = "http://www.x-art.com/index.php?show=model&pref=items&page=######&order=recent&catname=";

            List<ArtModel> list = new List<ArtModel>();

            var sep = new string[] { "<!--------------------------------------- ITEM -->", "<!--------------------------------------- finItem -->" };
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            for (int i = 1; i < 13; i++)
            {
                var u = urlModel.Replace("######", i.ToString());
                var html = wc.DownloadString(u);
                var itemHtml = html.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                List<string> items = new List<string>();
                Console.WriteLine(itemHtml.Length + " html分段");
                for (int j = 0; j < itemHtml.Length; j++)
                {
                    itemHtml[j] = itemHtml[j].Trim().Replace("\\n", "");
                    itemHtml[j] = itemHtml[j].Trim().Replace("\\r", "");
                    itemHtml[j] = itemHtml[j].Replace("\\", "");
                    itemHtml[j] = itemHtml[j].Trim();
                    if (itemHtml[j] != "")
                    {
                        items.Add(itemHtml[j]);
                    }
                }


                for (int k = 1; k < items.Count; k++)
                {
                    doc.LoadHtml(items[k]);
                    if (doc.DocumentNode.SelectSingleNode("//h1") == null)
                    {
                        continue;
                    }

                    var name = doc.DocumentNode.SelectSingleNode("//h1").InnerText;
                    var country = doc.DocumentNode.SelectNodes("//h2")[1].InnerText;
                    var age = doc.DocumentNode.SelectSingleNode("//h2").InnerText;

                    var rate = "";
                    var url = doc.DocumentNode.SelectSingleNode("//a").Attributes["href"].Value;
                    var picturnUrl = doc.DocumentNode.SelectSingleNode("//img").Attributes["src"].Value;
                    ArtModel mo = new ArtModel()
                    {
                        Name = name,
                        Age = age,
                        Country = country,
                        Rate = rate,
                        PictrueUrl = picturnUrl,
                        ModelURL = url
                    };

                    if (this._isNeedDownloadCover)
                    {
                        if (this.cp == null)
                        {
                            this.cp = new CoverProcessor("Models");
                        }
                        mo.PictureFile = cp.save(mo.PictrueUrl, name + ".jpg");
                    }
                    OnCompleteOneItem(mo);
                    list.Add(mo);
                }

            }


            return list;
        }
        public event EventHandler<OneCompleteEventArg> CompleteOneItem;
        protected virtual void OnCompleteOneItem(object something)
        {
            if (this.CompleteOneItem != null)
            {
                this.CompleteOneItem(this, new OneCompleteEventArg(something));
            }
        }
        /// <summary>
        /// NotSupported For this Class
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public List<ArtMovie> GetPicturePage(int page)
        {
            throw new NotSupportedException();
        }
        public bool IsDownloadExtraPicture{ get; set; }
        public string DisplayName
        {
            get;
            set;
        }
    }
}
