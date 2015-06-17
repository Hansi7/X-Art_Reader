using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    public class CookiesWebClient : System.Net.WebClient
    {
        public System.Net.CookieContainer CookieContainer;
        public CookiesWebClient()
        {
            this.CookieContainer = new System.Net.CookieContainer();
        }
        protected override System.Net.WebRequest GetWebRequest(Uri address)
        {
            System.Net.WebRequest request = base.GetWebRequest(address);
            if (request is System.Net.HttpWebRequest)
            {
                System.Net.HttpWebRequest httpRequest = request as System.Net.HttpWebRequest;
                httpRequest.Headers.AllKeys.Count();
                httpRequest.UserAgent = "User-Agent:Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36";
                httpRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                httpRequest.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                httpRequest.CookieContainer = CookieContainer;
            }
            return request;
        }
        /// <summary>
        /// 重新编写的DownloadString,支持gzip数据流，写死了默认UTF8编码。
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public new string DownloadString(string address)
        {
            if (address == null)
                throw new ArgumentNullException("address");
            return this.DownloadString(new Uri(address));
        }

        public new string DownloadString(Uri address)
        {
            var stream = this.OpenRead(address);

            if (this.ResponseHeaders.AllKeys.Contains("Content-Encoding"))
            {
                if (this.ResponseHeaders["Content-Encoding"] == "gzip")
                {
                    using (System.IO.MemoryStream ms_output = new System.IO.MemoryStream())
                    {
                        using (System.IO.Compression.GZipStream gzip = new System.IO.Compression.GZipStream(stream, System.IO.Compression.CompressionMode.Decompress))
                        {
                            gzip.CopyTo(ms_output);
                            ms_output.Position = 0;
                            System.IO.StreamReader sr = new System.IO.StreamReader(ms_output, Encoding.UTF8);
                            var html = sr.ReadToEnd();
                            return html;
                        }
                    }
                }
            }

            return base.DownloadString(address);
        }
    }
}
