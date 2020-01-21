﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Task3
{
    class Presenter
    {
        MainWindow main = null;
        DispatcherTimer timer = null;
        Model model = null;

        public Presenter(MainWindow mainWindow)
        {
            this.main = mainWindow;
            this.model = new Model();
            main.MyEventStart += new EventHandler(MyTimerStart);
            main.MyEventStop += new EventHandler(MyTimerStop);
            main.MyEventReset += MyTimerReset;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0); // встановлення інтервалу
            timer.Tick += TickHendler;
        }




        #region Hendlers
        // потрібно передавати object і System.EventArgs
        private void MyTimerStart(object sender, System.EventArgs e)
        {
            // main.textBoxTimer.Text = "Start button";
            timer.Start();
        }

        private void MyTimerStop(object sender, System.EventArgs e)
        {

            timer.Stop();
        }

        //
        private void MyTimerReset(object sender, EventArgs e)
        {
            timer.Stop();
            main.textBoxTimer.Clear();
            
        }
        private void TickHendler(object sender, EventArgs e)
        {
            main.textBoxTimer.Text = model.TimerValue();
        }

        #endregion
    }
}
