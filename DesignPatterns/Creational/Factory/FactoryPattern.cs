using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.Factory
{
    public interface IProduct
    {
        void Display();
    }

    public class ConcreteProductA : IProduct
    {
        public void Display()
        {
            Console.WriteLine("ConcreteProductA");
        }
    }

    public class ConcreteProductB : IProduct
    {
        public void Display()
        {
            Console.WriteLine("ConcreteProductB");
        }
    }

    public class ConcreteProductC : IProduct
    {
        public void Display()
        {
            Console.WriteLine("ConcreteProductC");
        }
    }

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod(string type);
    }
    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod(string type)
        {
            IProduct product = null;
            if (type.Equals("ConcreteProductA"))
            {
                product = new ConcreteProductA();
            }

            else if (type.Equals("ConcreteProductB"))
            {
                product = new ConcreteProductB();
            }

            else if (type.Equals("ConcreteProductC"))
            {
                product = new ConcreteProductC();
            }

            return product;
        }
    }
}
