using System;
using System.Windows;

// View

namespace MVP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private event EventHandler myEvent = null;

        public event EventHandler MyEvent
        {
            add { myEvent += value; }
            remove { myEvent += value; }
        }

        /// <summary>
        /// сама подія, з якою зваязаний метод що викликае івент на якому вже є якась подія
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyButtonClick(object sender, RoutedEventArgs e)
        {
            if (myEvent == null)
                myEvent.Invoke(sender, e);
            else
            {
                Console.WriteLine("myEvent == null");
            }
        }
    }
}
