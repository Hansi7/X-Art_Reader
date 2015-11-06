using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View.DB
{
    class DBConfig
    {
        public static string DatabaseFile = "";
        public static string DataSource
        {
            get
            {
                return string.Format("data source={0}", DatabaseFile);
            }
        }

    }
}
