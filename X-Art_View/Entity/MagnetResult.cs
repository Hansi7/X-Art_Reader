using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    public class MagnetResult
    {
        public string Title { get; set; }
        public string Size { get; set; }
        public string MagLink { get; set; }
        public override string ToString()
        {
            return Title +" " +  Size + "\r\n" + MagLink;
        }
    }
}
