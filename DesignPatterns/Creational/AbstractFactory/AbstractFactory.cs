using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.AbstractFactory
{
    public abstract class AbstractProductA
    {
        public virtual void DisplayProductADetails()
        {
            Console.WriteLine("Default Details of Product A");
        }
    }

    public abstract class AbstractProductB
    {
        public virtual void DisplayProductBDetails()
        {
            Console.WriteLine("Default Details of Product B");
        }
    }

    public class ProductA1 : AbstractProductA
    {
        public override void DisplayProductADetails()
        {
            Console.WriteLine("In Product A1");
        }
    }

    public class ProductA2 : AbstractProductA
    {

    }

    public class ProductB1 : AbstractProductB
    {
        public override void DisplayProductBDetails()
        {
            Console.WriteLine("In Product B1");
        }
    }

    public class ProductB2 : AbstractProductB
    {

    }

    public interface IAbstractFactory
    {
        AbstractProductA CreateProductA();

        AbstractProductB CreateProductB();
    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public class Client
    {
        public AbstractProductA _abstractProductA;
        public AbstractProductB _abstractProductB;

        public Client(IAbstractFactory _abstractFactory)
        {
            _abstractProductA = _abstractFactory.CreateProductA();
            _abstractProductB = _abstractFactory.CreateProductB(); 
        }
    }


}
