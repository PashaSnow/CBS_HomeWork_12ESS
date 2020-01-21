using System;

// Presenter

namespace MVP
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.MyEvent += new EventHandler(mainWindow_myEvent); // 
        }

        /// <summary>
        /// метод віне же хендлер, підписався в конструкторі
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mainWindow_myEvent(object sender, System.EventArgs e)
        {
            string variable = model.Logic(this.mainWindow.textBOX.Text);

            this.mainWindow.textBOX.Text = variable;
        }
    }
}
