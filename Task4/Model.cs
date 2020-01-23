using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Model
    {
        public string Add(double val1 = 0, double val2 = 0)
        {
            return $"{val1+val2}";
        }
        public string Sub(double val1 = 0, double val2 = 0)
        {
            return (val1 - val2).ToString();
        }
        public string Mul(double val1 = 0, double val2 = 0)
        {
            return (val1 * val2).ToString();
        }
        public string Div(double val1 = 0, double val2 = 1)
        {
            if (val2 == 0)
                return "На ноль делить нельзя";
            return Convert.ToString(val1 / val2);
        }
    }
}
