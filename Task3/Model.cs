using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Model
    {
        private int timer;

        public int Timer { get => timer; set => timer = value; }

        public string TimerValue()
        {
            Timer++;
            return  Timer/60 + " min " + Timer%60 + "sec";
        }
    }
}
