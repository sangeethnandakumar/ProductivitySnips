using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class DiscountCalculator : CarDecorator
    {
        public DiscountCalculator(ICar car) : base(car)
        {
        }

        public override double GetDiscountedPrice()
        {
            return 0.8 * base.GetPrice();
        }
    }
}