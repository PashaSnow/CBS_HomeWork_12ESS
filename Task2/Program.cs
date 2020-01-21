using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public delegate string MyDel(string str);
    class Program
    {
        public static event MyDel Event;

        static void Main(string[] args)
        {
            new Presenter();
            string str = "";
            while (true)
            {
                str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    // скажем делегату от візьми цю строку і піди до метода який у тебе в списку
                    Console.WriteLine(Event.Invoke(str));
                }
            }
        }
    }
}
