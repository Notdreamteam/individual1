using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveWork1.Core.Tasks
{
    public class Task5Class
    {
        private double _x;
        private double _y;

        public Task5Class(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public string Exp()
        {
            if ((_x < 0) && (_y > 0)) return "Точка А лежит в первой четверти";
            else return "Точка А не лежит в первой четверти";
        }
    }
}
