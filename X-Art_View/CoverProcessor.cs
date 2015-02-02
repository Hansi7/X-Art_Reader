using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    internal class CoverProcessor
    {
        string bp;
        string subPath;
        public CoverProcessor(string CoverSubPath)
        {
            this.subPath = CoverSubPath;
            bp = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, CoverSubPath);
        }

        public string save(string picURL,string fileName)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            if (!System.IO.Directory.Exists(bp))
            {
                System.IO.Directory.CreateDirectory(bp);
            }
            try
            {
                if (!System.IO.File.Exists(System.IO.Path.Combine(bp, fileName)))
                {
                    wc.DownloadFile(picURL, System.IO.Path.Combine(bp, fileName));
                }
            }
            catch
            {

            }

            return System.IO.Path.Combine(subPath, fileName);
        }
    }
}
