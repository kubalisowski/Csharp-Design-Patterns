using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /// ABSTRACTION ///
            // Class Program is a 'driver' class for Abstracted
            Child child = new Child();
            Console.WriteLine(child.SayAbstract("I am abstract string method."));
            child.VoidAbstract();
            child.NonAbstract();

            // Variable class
            ChildVar var = new ChildVar();
            var.abstractedVariable = "I am derived abstracted variable";
            Console.WriteLine(var.abstractedVariable);
            ///////////////////
            
        }
    }
}
