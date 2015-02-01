using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    [Serializable]
    public class ArtModel
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Country { get; set; }
        public string Rate { get; set; }
        public string PictrueUrl { get; set; }
        public string PictureFile { get; set; }

        public override string ToString()
        {
            return Name + "\t" + Age + "\t" + Country + "\t" + Rate;
        }
    }
}
