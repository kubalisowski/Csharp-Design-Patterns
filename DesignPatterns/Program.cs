using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ABSTRACTION ///
            // Class Program is a 'driver' class for Abstracted
            //Child child = new Child();
            //Console.WriteLine(child.SayAbstract("I am abstract string method."));
            //child.VoidAbstract();
            //child.NonAbstract();

            //// Variable class
            //ChildVar var = new ChildVar();
            //var.abstractedVariable = "I am derived abstracted variable";
            //Console.WriteLine(var.abstractedVariable);
            ///////////////////

            /// FACTORY METHOD ///
            //CardFactory factory = null;
            //Console.Write("Enter the card type you would like to visit: ");
            //string card = Console.ReadLine();

            //switch (card.ToLower())
            //{
            //    case "moneyback":
            //        factory = new MoneyBackFactory(50000, 0);
            //        break;
            //    case "titanium":
            //        factory = new TitaniumFactory(100000, 500);
            //        break;
            //    case "platinum":
            //        factory = new PlatinumFactory(500000, 1000);
            //        break;
            //    default:
            //        break;
            //}

            //CreditCard creditCard = factory.GetCreditCard();
            //Console.WriteLine("\nYour card details are below : \n");
            //Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
            //    creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            //Console.ReadKey();
            /////////////////////

            /// FACADE ///
            Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
            /////////////

        }
    }
}
