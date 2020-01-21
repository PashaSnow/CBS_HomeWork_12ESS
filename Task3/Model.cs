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

        public string TimerValue()
        {
            timer++;
            return  timer/60 + " min " + timer%60 + "sec";
        }
    }
}
