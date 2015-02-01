using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    [Serializable]
    public class ArtMovie
    {
        public string  Type { get; set; }
        public string  Url { get; set; }
        public string  Title { get; set; }
        public string CoverFile { get; set; }
        public string CoverLink { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Title + "\t" + Url + "\t" + CoverLink + "\t" + CoverFile + "\t" + Type;
        }
    }
}
