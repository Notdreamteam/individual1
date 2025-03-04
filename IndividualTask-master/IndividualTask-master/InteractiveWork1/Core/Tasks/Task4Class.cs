using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveWork1.Core.Tasks
{
    public class Task4Class
    {
        private double _a;
        private double _b;

        public Task4Class(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public string Print()
        {
            if ((Math.Pow(_a, 2) + Math.Pow(_b, 2)) > (Math.Pow(_a + _b, 2))) return "Сумма квадратов больше";
            else if ((Math.Pow(_a, 2) + Math.Pow(_b, 2)) == (Math.Pow(_a + _b, 2))) return "Оба равны";
            else return "Квадрат суммы больше";
        }
    }
}
