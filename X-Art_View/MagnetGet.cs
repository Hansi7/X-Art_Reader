using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Art_View
{
    public class MagnetGet
    {
        public MagnetGet()
        { 
            //to do ...
        }
        public event EventHandler GetDone;
        protected virtual void raiseGetDoneEvent()
        {
            if (this.GetDone!=null)
            {
                GetDone(this, new EventArgs());
            }
        }
    }
}
