using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    [Serializable]
    public class ArtMovie
    {
        private string _type="";

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string  Url { get; set; }
        public string  Title { get; set; }

        private string _cf ="";

        public string CoverFile
        {
            get { return _cf; }
            set { _cf = value; }
        }

        private string _cf2 ="";

        public string CoverFile2
        {
            get { return _cf2; }
            set { _cf2 = value; }
        }

        private string _cl="";

        public string CoverLink
        {
            get { return _cl; }
            set { _cl = value; }
        }


        private string _cl2="";

        public string CoverLink2
        {
            get { return _cl2; }
            set { _cl2 = value; }
        }


        private string _description = "";

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _publishDate="";

        public string PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }


        public override string ToString()
        {
            return Title + "\t" + Url + "\t" + CoverLink + "\t" + CoverFile + "\t" + Type;
        }
    }
}
