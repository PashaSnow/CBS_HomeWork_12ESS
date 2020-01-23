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

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this); // не забуваємо створити силку на себе
        }

        private EventHandler addEV;
        private EventHandler subEV;
        private EventHandler mulEV;
        private EventHandler divEV;

        public event EventHandler AddEV
        {
            add { addEV += value; }
            remove { addEV -= value; }
        }
        public event EventHandler SubEV
        {
            add { subEV += value; }
            remove { subEV -= value; }
        }
        public event EventHandler MulEV
        {
            add { mulEV += value; }
            remove { mulEV -= value; }
        }
        public event EventHandler DivEV
        {
            add { divEV += value; }
            remove { divEV -= value; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            addEV.Invoke(sender, e);
        }

        private void mulButton_Click(object sender, RoutedEventArgs e)
        {
            mulEV.Invoke(sender, e);
        }

        private void subButton_Click(object sender, RoutedEventArgs e)
        {
            subEV.Invoke(sender, e);
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            divEV.Invoke(sender, e);
        }
    }
}
