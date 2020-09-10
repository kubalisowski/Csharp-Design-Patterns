using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    /// <summary>
    /// https://www.c-sharpcorner.com/article/facade-design-pattern-using-c-sharp/
    /// </summary>
    //The shopkeeper is a façade for all the items in the shop.
    //Online travel portal is a façade for their customers for different holiday/travel packages.
    //Customer care is a façade for their customers for different services. 
    // INTERFACE
    public interface IPizza
    {
        void GetVegPizza();
        void GetNonVegPizza();
    }
    public interface IBread
    {
        void GetGarlicBread();
        void GetCheesyGarlicBread();
    }
    // PROVIDERS
    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza.");
        }
        public void GetVegPizza()
        {
            Console.WriteLine("Getting Veg Pizza.");
        }
        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings.");
        }
    }
    public class BreadProvider : IBread
    {
        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
        }
        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
        }
    }
    // FACADE
    public class RestaurantFacade
    {
        private IPizza _PizzaProvider;
        private IBread _BreadProvider;
        public RestaurantFacade()
        {
            _PizzaProvider = new PizzaProvider();
            _BreadProvider = new BreadProvider();
        }
        public void GetNonVegPizza()
        {
            _PizzaProvider.GetNonVegPizza();
        }
        public void GetVegPizza()
        {
            _PizzaProvider.GetVegPizza();
        }
        public void GetGarlicBread()
        {
            _BreadProvider.GetGarlicBread();
        }
        public void GetCheesyGarlicBread()
        {
            _BreadProvider.GetCheesyGarlicBread();
        }
    }
}
