using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Creational.Factory;
using Creational.AbstractFactory;
using Creational.AbstractFactoryRealWorld;
using Creational.Builder;
using Creational.Prototype;
using Creational.Singleton;

namespace Creational
{
    class Program
    {
        #region Factory Pattern
        static void StandardFactoryPatternStructure()
        {
            //Creating Objects by Factory Pattern
            Creator creator = new ConcreteCreator();
            Creational.Factory.IProduct productA = creator.FactoryMethod("ConcreteProductA");
            productA.Display();
            Creational.Factory.IProduct productB = creator.FactoryMethod("ConcreteProductB");
            productB.Display();
            Creational.Factory.IProduct productC = creator.FactoryMethod("ConcreteProductC");
            productC.Display();
        }

        static void FactoryPatternRealWorldDemo()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

        }
        #endregion

        #region Abstract Factory Pattern
        static void StandardAbstractFactoryPatternStructure()
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

        static void AbstractFactoryPatternRealWorldDemo()
        {
            IVehicleFactory hondaFactory = new HondaFactory();
            VehicleClient hondaClient = new VehicleClient(hondaFactory, "Regular");
            hondaClient.DisplayProductDetails();

            Console.WriteLine();
            IVehicleFactory heroFactory = new HeroFactory();
            VehicleClient heroClient = new VehicleClient(heroFactory, "Sports");
            heroClient.DisplayProductDetails();
        }
        #endregion

        #region Builder Pattern
        static void StandardBuilderPatternStructure()
        {
            var director = new Director(new ConcreteBuilder(new Product()));
            director.Construct();
            Creational.Builder.IProduct product = director.GetProduct();
            product.ShowInfo();
        }

        static void BuilderPatternRealWorldDemo()
        {
            var vehicleCreator = new VehicleCreator(new HondaBuilder());
            vehicleCreator.ConstructVehicle();
            Vehicle hondaVehicle = vehicleCreator.GetVehicle();
            hondaVehicle.ShowInfo();

            vehicleCreator = new VehicleCreator(new HeroBuilder());
            vehicleCreator.ConstructVehicle();
            Vehicle heroVehicle = vehicleCreator.GetVehicle();
            heroVehicle.ShowInfo();
        }
        #endregion

        #region Prototype Pattern
        static void PrototypePatternRealWorldDemo()
        {
            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Arif"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Monu";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Sahil";
            typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());
        }
        #endregion

        #region Singleton Pattern
        static void SingletonPatternDemo()
        {
            Creational.Singleton.Singleton Instance_1 = Singleton.Singleton.Instance;
            Creational.Singleton.Singleton Instance_2 = Singleton.Singleton.Instance;
            if(Instance_1 == Instance_2)
                Console.WriteLine("These are Singleton instance");
            else
                Console.WriteLine("Singleton implementation failed.");
        }
        #endregion

        static void Main(string[] args)
        {
            // Un-Comment the below patterns to see output

            #region Factory Pattern
            //StandardFactoryPatternStructure();
            //FactoryPatternRealWorldDemo();
            #endregion

            #region Abstract Factory Pattern
            //StandardAbstractFactoryPatternStructure();
            //AbstractFactoryPatternRealWorldDemo();
            #endregion

            #region Builder Pattern
            //StandardBuilderPatternStructure();
            //BuilderPatternRealWorldDemo();
            #endregion

            #region Prototype Pattern
            //Prototype Pattern
            //PrototypePatternRealWorldDemo();
            #endregion

            #region Singleton Pattern
            SingletonPatternDemo();
            #endregion

            Console.ReadLine();
        }
    }
}
