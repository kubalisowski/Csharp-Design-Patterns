using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    // Base class
    public abstract class Abstraction
    {
        // Abstract method
        public abstract void VoidAbstract();
        public abstract string SayAbstract(string message);

        //Non-Abstract
        public void NonAbstract() 
        {
            Console.WriteLine("I am not abstract void method.");
        }
    }

    // Child (deriver) class
    // must deriver abstract methods
    public class Child : Abstraction
    {
        public override void VoidAbstract()
        {
            Console.WriteLine("I am abstract void method.");
        }

        public override string SayAbstract(string message)
        {
            return message;
        }
    }

    // Variable abstract class
    public abstract class Var
    {
        // PROTECTED: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
        protected string _var;
        public abstract string abstractedVariable
        {
            get;
            set;
        }
    }

    public class ChildVar : Var
    {
        public override string abstractedVariable
        {
            get
            {
                return _var;
            }
            set
            {
                _var = value;
            }
        }
    }
}
