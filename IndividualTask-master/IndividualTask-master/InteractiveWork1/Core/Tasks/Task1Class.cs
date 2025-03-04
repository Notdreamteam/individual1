using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveWork1.Core.Tasks
{
    public class Task1Class
    {
        public string FindPrice(int price)
        {
            if (price >= 4000 && price <= 6000) return $"{price - (price * 0.05)}";
            else if (price > 6000 && price <= 10000) return $"{price - (price * 0.1)}";
            else return $"{price}";
        }
    }
}
