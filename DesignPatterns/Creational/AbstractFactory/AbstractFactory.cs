using System;

namespace Creational.AbstractFactory
{
    public interface IAbstractProductA
    {
        void DisplayProductDetails();
    }

    public class ConcreteProductA1 : IAbstractProductA
    {
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product A1 details");
        }
    }

    public class ConcreteProductA2 : IAbstractProductA
    {
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product A2 details");
        }
    }

    public interface IAbstractProductB
    {
        void DisplayProductDetails();
    }

    public class ConcreteProductB1 : IAbstractProductB
    {
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product B1 details");
        }
    }

    public class ConcreteProductB2 : IAbstractProductB
    {
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product B2 details");
        }
    }

    public interface IAbstractFactory
    {
        IAbstractProductA CreateATypeProduct(string type);
        IAbstractProductB CreateBTypeProduct(string type);
    }

    // Concrete factories produce a family of products that belong to a single variant
    public class Product1Factory : IAbstractFactory
    {
        public IAbstractProductA CreateATypeProduct(string type)
        {
            if(type == "1")
                return new ConcreteProductA1();
            if (type == "2")
                return new ConcreteProductA2();

            return null;
        }

        public IAbstractProductB CreateBTypeProduct(string type)
        {
            if (type == "1")
                return new ConcreteProductB1();
            if (type == "2")
                return new ConcreteProductB2();

            return null;            
        }
    }

    // Concrete factories produce a family of products that belong to a single variant
    public class Product2Factory : IAbstractFactory
    {
        public IAbstractProductA CreateATypeProduct(string type)
        {
            if (type == "1")
                return new ConcreteProductA1();
            if (type == "2")
                return new ConcreteProductA2();

            return null;
        }

        public IAbstractProductB CreateBTypeProduct(string type)
        {
            if (type == "1")
                return new ConcreteProductB1();
            if (type == "2")
                return new ConcreteProductB2();

            return null;
        }
    }

    /* one more level of abstraction. This may not be required  */
    public class ProductClient
    {
        IAbstractProductA productA;
        IAbstractProductB productB;

        public ProductClient(IAbstractFactory factory, string type)
        {
            productA = factory.CreateATypeProduct(type);
            productB = factory.CreateBTypeProduct(type);
        }

        public void DisplayProductDetails()
        {
            productA.DisplayProductDetails();
            productB.DisplayProductDetails();
        }
    }
}
