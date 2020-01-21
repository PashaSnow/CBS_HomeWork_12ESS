using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Presenter
    {
        // view у нас статична значить силку знайдем і так
        // private Program view;
        private Model model;

        public Presenter()
        {
            this.model = new Model();
            Program.Event += EvenMeth;
        }

        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        // аргумент передадуть через делегат
        public string EvenMeth(string str)
        {
            return model.Logic(str);
        }
    }
}