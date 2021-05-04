using DesignPatterns.AdapterPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.FactoryPattern;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //BUILDER PATTERN:
            //If you have a class with many options and a big constructor. Use builder pattern
            var burger = BurgerBuilder.Init(100)
                                    .WithCheese()
                                    .WithBacon()
                                    .Build();

            //ADAPTER PATTERN:
            //An adapter pattern is used to combine 2 different classes
            //Scenerio: EmployeeManager can only return results in CSV, But we need in pipe seperated format
            IEmployeeManager adaptedInstance = new EmployeeAdapter();
            var pipeSeperated = adaptedInstance.GetEmployess();

            //FACADE PATTERN:
            //Facade pattern can be used for simplified entrys to sub systems (Many internal functions)
            var shoppingfacade = new ShoppingFacade();
            shoppingfacade.BuyItem();

            //DECORATOR PATTERN:
            //Usefull to extend new functions to a class without inheriting (or if sealed)
            var car = new BMW();
            var discountedPrice = new DiscountCalculator(car).GetDiscountedPrice();

            //FACTORY PATTERN:
            //Factory pattern helps build objects so client no need to know all concreate classes
            IInvoice invoice1 = InvoiceFactory.GetInvoice(1);
            IInvoice invoice2 = InvoiceFactory.GetInvoice(2);
        }
    }
}