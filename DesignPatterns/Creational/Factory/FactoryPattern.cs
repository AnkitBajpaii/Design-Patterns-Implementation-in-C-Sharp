using System;

namespace Creational.Factory
{
    public interface IProduct
    {
        void SomeMethod();
    }

    public class ConcreteProductA : IProduct
    {
        public void SomeMethod()
        {
            Console.WriteLine("ConcreteProductA");
        }
    }

    public class ConcreteProductB : IProduct
    {
        public void SomeMethod()
        {
            Console.WriteLine("ConcreteProductB");
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
            if (type.Equals("A"))
            {
                product = new ConcreteProductA();
            }

            else if (type.Equals("B"))
            {
                product = new ConcreteProductB();
            }

            return product;
        }
    }
}
