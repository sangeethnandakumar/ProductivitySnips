using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public sealed class BMW : ICar
    {
        public double GetPrice()
        {
            return 1500000;
        }
    }
}