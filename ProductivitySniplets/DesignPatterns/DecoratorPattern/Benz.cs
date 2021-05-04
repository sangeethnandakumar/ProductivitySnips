using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public sealed class Benz : ICar
    {
        public double GetPrice()
        {
            return 12000000;
        }
    }
}