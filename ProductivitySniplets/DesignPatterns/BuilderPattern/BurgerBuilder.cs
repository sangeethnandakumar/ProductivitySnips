using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BurgerBuilder
    {
        private int cookingSpeed = 0;
        private Burger _burger = new Burger();

        public Burger Build() => _burger;

        private BurgerBuilder(int cookingSpeed)
        {
            this.cookingSpeed = cookingSpeed;
        }

        public static BurgerBuilder Init(int cookingSpeed)
        {
            return new BurgerBuilder(10);
        }

        public BurgerBuilder WithPatties(int num)
        {
            _burger.NumPatties = num;
            return this;
        }

        public BurgerBuilder WithCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public BurgerBuilder WithBacon()
        {
            _burger.Bacon = true;
            return this;
        }
    }
}