using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveWork1.Core.Tasks
{
    public class Task3Class
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }

        public Task3Class(bool a, bool b, bool c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool ExpA()
        {
            return (A || !A && B) || C;
        }

        public bool ExpB()
        {
            return !A || A && (B || C);
        }

        public bool ExpC()
        {
            return (A || B && !C) && C;
        }
    }
}
