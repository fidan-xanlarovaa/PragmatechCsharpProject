using System;
using System.Collections.Generic;
using System.Text;

namespace Week7_Task1
{
    public class Tv : Product
    {
        private bool _smartTv;
        private int _inch;
        private bool _hdmi;

        public bool SmartTv
        {
            get { return _smartTv; }
            set { _smartTv = value; }
        }

        public int Inch
        {
            get { return _inch; ; }
            set { _inch = value; }
        }

        public bool Hdmi
        {
            get { return _hdmi; }
            set { _hdmi = value; }
        }


    }
}
