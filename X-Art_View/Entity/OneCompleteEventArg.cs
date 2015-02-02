using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    public class OneCompleteEventArg:EventArgs
    {

        private object _obj;

        public object Tag
        {
            get { return _obj; }
            set { _obj = value; }
        }

        public OneCompleteEventArg(object obj)
        {
            this._obj = obj;
        }

    }
}
