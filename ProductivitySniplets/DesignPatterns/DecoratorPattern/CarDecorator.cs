using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class CarDecorator : ICar
    {
        private readonly ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public double GetPrice()
        {
            return car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}