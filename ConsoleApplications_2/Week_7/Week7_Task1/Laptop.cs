using System;
using System.Collections.Generic;
using System.Text;

namespace Week7_Task1
{
    public class Laptop : Product
    {
        private int _ram;
        private string _cpu;
        private string _videoCard;

        public int Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }

        public string Cpu
        {
            get { return _cpu; }
            set { _cpu = value; }
        }

        public string VideoCard
        {
            get { return _videoCard; }
            set { _videoCard = value; }
        }


    }
}
