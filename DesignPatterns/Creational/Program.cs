using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Creational.Factory;
using Creational.AbstractFactory;

namespace Creational
{
    class Program
    {
        static void FactoryPatternImplementation()
        {
            //Creating Objects by Factory Pattern
            Creator creator = new ConcreteCreator();
            IProduct productA = creator.FactoryMethod("ConcreteProductA");
            productA.Display();
            IProduct productB = creator.FactoryMethod("ConcreteProductB");
            productB.Display();
            IProduct productC = creator.FactoryMethod("ConcreteProductC");
            productC.Display();
        }

        static void AbstractFactoryPatternImplementation()
        {
            IAbstractFactory _abstractFactory1 = new ConcreteFactory1();
            Client _client1 = new Client(_abstractFactory1);

            AbstractProductA _productA1 = _client1._abstractProductA;
            _productA1.DisplayProductADetails();

            AbstractProductB _productB1 = _client1._abstractProductB;
            _productB1.DisplayProductBDetails();

            IAbstractFactory _abstractFactory2 = new ConcreteFactory2();
            Client _client2 = new Client(_abstractFactory2);

            AbstractProductA _productA2 = _client2._abstractProductA;
            _productA2.DisplayProductADetails();

            AbstractProductB _productB2 = _client2._abstractProductB;
            _productB2.DisplayProductBDetails();
        }

        static void Main(string[] args)
        {
            FactoryPatternImplementation();

            AbstractFactoryPatternImplementation();

            Console.ReadLine();
        }
    }
}
