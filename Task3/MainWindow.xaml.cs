using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private EventHandler myEventStart = null;
        private EventHandler myEventStop = null;
        private EventHandler myEventReset = null;


        #region Events
        public event EventHandler MyEventStart
        {
            add { myEventStart += value; }
            remove { myEventStart -= value; }
        }

        public event EventHandler MyEventStop
        {
            add { myEventStop += value; }
            remove { myEventStop -= value; }
        }

        public event EventHandler MyEventReset
        {
            add { myEventReset += value; }
            remove { myEventReset -= value; }
        } 
        #endregion

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            myEventStart.Invoke(sender, e);
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            myEventStop.Invoke(sender, e);
        }

        private void buttonReser_Click(object sender, RoutedEventArgs e)
        {
            myEventReset.Invoke(sender, e);
        }
    }
}
