using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow; // поміщаємо силку з вікна
            this.mainWindow.AddEV += AddEV_Click;
            this.mainWindow.SubEV += SubEV_Click;
            this.mainWindow.MulEV += MulEV_Click;
            this.mainWindow.DivEV += DivEV_Click;
        }

        private void DivEV_Click(object sender, EventArgs e)
        {
            mainWindow.resultValueTB.Text = model.Div(Convert.ToDouble(mainWindow.inputValueTB1.Text), Convert.ToDouble(mainWindow.inputValueTB2.Text));
        }

        private void MulEV_Click(object sender, EventArgs e)
        {
            mainWindow.resultValueTB.Text = model.Mul(Convert.ToDouble(mainWindow.inputValueTB1.Text), Convert.ToDouble(mainWindow.inputValueTB2.Text));
        }

        private void SubEV_Click(object sender, EventArgs e)
        {
            mainWindow.resultValueTB.Text = model.Sub(Convert.ToDouble(mainWindow.inputValueTB1.Text), Convert.ToDouble(mainWindow.inputValueTB2.Text));
        }

        private void AddEV_Click(object sender, EventArgs e)
        {
            mainWindow.resultValueTB.Text =  model.Add(Convert.ToDouble(mainWindow.inputValueTB1.Text), Convert.ToDouble(mainWindow.inputValueTB2.Text));
        }
    }
}
