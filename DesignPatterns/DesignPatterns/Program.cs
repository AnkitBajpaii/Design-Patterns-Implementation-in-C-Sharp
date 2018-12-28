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

using Structural.Adapter;
using Structural.AdapterRealWorldDemo;

namespace DesignPatterns
{
    class Program
    {
        #region Creationtional Patterns

        #region Factory Pattern

        static void StandardFactoryPatternStructure()
        {
            //Creating Objects by Factory Pattern
            Creator creator = new ConcreteCreator();

            Creational.Factory.IProduct productA = creator.FactoryMethod("A");
            productA.SomeMethod();

            Creational.Factory.IProduct productB = creator.FactoryMethod("B");
            productB.SomeMethod();
        }

        static void FactoryPatternRealWorldDemo1()
        {
            Creational.Factory.IVehicleFactory factory = new ConcreteVehicleFactory();

            IVehicle scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IVehicle bike = factory.GetVehicle("Bike");
            bike.Drive(20);
        }

        static void FactoryPatternRealWorldDemo2()
        {
            ILoggerFactory loggerFactory = new LoggerFactory();
            ILogger logger = loggerFactory.GetLogger("console");
            logger.Log("some message");

            logger = loggerFactory.GetLogger("file");
            logger.Log("some message");


        }

        #endregion

        #region Abstract Factory Pattern

        static void StandardAbstractFactoryPatternStructure()
        {
            IAbstractFactory product1Factory = new ConcreteFactory1();

            IAbstractProductA productA = product1Factory.CreateATypeProduct("1");
            IAbstractProductB productB = product1Factory.CreateBTypeProduct("1");         
            productA.DisplayProductDetails();
            productB.DisplayProductDetails();

            // Can also do like this. Provides shorter and more readable syntax
            ProductClient client = new ProductClient(product1Factory, "1");
            client.DisplayProductDetails();

            IAbstractFactory product2Factory = new ConcreteFactory2();

            productA = product2Factory.CreateATypeProduct("2");
            productB = product2Factory.CreateBTypeProduct("2");
            productA.DisplayProductDetails();
            productB.DisplayProductDetails();

            // Can also do like this. Provides shorter and more readable syntax
            client = new ProductClient(product2Factory, "2");
            client.DisplayProductDetails();
        }

        static void AbstractFactoryPatternRealWorldDemo1()
        {
            Creational.AbstractFactoryRealWorld.IVehicleFactory hondaFactory = new HondaFactory();
            VehicleClient hondaClient = new VehicleClient(hondaFactory, "male");
            hondaClient.DisplayProductDetails();

            Console.WriteLine();

            Creational.AbstractFactoryRealWorld.IVehicleFactory heroFactory = new HeroFactory();
            VehicleClient heroClient = new VehicleClient(heroFactory, "female");
            heroClient.DisplayProductDetails();
        }

        static void AbstractFactoryPatternRealWorldDemo2()
        {
            GUIClient guiClient = new GUIClient(new WinUIFactory());
            guiClient.GetButton().Click();
            guiClient.GetCheckBox().Check();

            guiClient = new GUIClient(new MacUIFactory());
            guiClient.GetButton().Click();
            guiClient.GetCheckBox().Check();
        }

        static void AbstractFactoryPatternRealWorldDemo3()
        {
            AnimalWorld animalWorld = new AnimalWorld(new IndianFactory());
            animalWorld.RunFoodChain();

            animalWorld = new AnimalWorld(new AmericanFactory());
            animalWorld.RunFoodChain();
        }

        #endregion

        #region Builder Pattern

        static void StandardBuilderPatternStructure()
        {
            var director = new Director(new ConcreteBuilder());
            director.Construct();
            Creational.Builder.IProduct product = director.GetProduct();            
        }

        static void BuilderPatternRealWorldDemo1()
        {
            var vehicleCreator = new VehicleDirector(new HondaBuilder());
            vehicleCreator.ConstructVehicle();
            Vehicle hondaVehicle = vehicleCreator.GetVehicle();
            hondaVehicle.ShowInfo();

            vehicleCreator = new VehicleDirector(new HeroBuilder());
            vehicleCreator.ConstructVehicle();
            Vehicle heroVehicle = vehicleCreator.GetVehicle();
            heroVehicle.ShowInfo();
        }

        static void BuilderPatternRealWorldDemo2()
        {
            var smartPhoneDirector = new SmartPhoneDirector(new AppleIPhoneBuilder());
            smartPhoneDirector.ConstructSmartPhone();
            ISmartPhone smartPhone = smartPhoneDirector.GetSmartPhone();

            smartPhoneDirector = new SmartPhoneDirector(new RedmiSmartPhoneBuilder());
            smartPhoneDirector.ConstructSmartPhone();
            smartPhone = smartPhoneDirector.GetSmartPhone();
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
            Creational.Singleton.SingletonPatternLazyThreadSafeWithDoubleCheckLock Instance_1 = SingletonPatternLazyThreadSafeWithDoubleCheckLock.Instance;
            Creational.Singleton.SingletonPatternLazyThreadSafeWithDoubleCheckLock Instance_2 = SingletonPatternLazyThreadSafeWithDoubleCheckLock.Instance;
            if (Instance_1 == Instance_2)
                Console.WriteLine("These are Singleton instance");
            else
                Console.WriteLine("Singleton implementation failed.");
        }
        #endregion

        #endregion

        #region StructurlPatterns

        #region Adapter Pattern

        public static void StandardAdapterPattern()
        {
            Structural.Adapter.Client client = new Structural.Adapter.Client(new Adapter());
            client.MakeRequest();
        }

        public static void RealWorldAdapterPattern()
        {
            ThirdPartyBillingSystem billingSystem = new ThirdPartyBillingSystem(new EmployeeAdapter());
            billingSystem.ShowEmployeeList();
        }

        #endregion

        #endregion

        static void Main(string[] args)
        {
            // Un-Comment the below patterns to see output

            #region Creationtional Patterns
            #region Factory Pattern
            //StandardFactoryPatternStructure();
            //FactoryPatternRealWorldDemo1();
            //FactoryPatternRealWorldDemo2();
            #endregion

            #region Abstract Factory Pattern
            //StandardAbstractFactoryPatternStructure();
            //AbstractFactoryPatternRealWorldDemo1();
            //AbstractFactoryPatternRealWorldDemo2();
            #endregion

            #region Builder Pattern
            //StandardBuilderPatternStructure();
            //BuilderPatternRealWorldDemo1();
            //BuilderPatternRealWorldDemo2();
            #endregion

            #region Prototype Pattern            
            //PrototypePatternRealWorldDemo();
            #endregion

            #region Singleton Pattern
            //SingletonPatternDemo();
            #endregion
            #endregion

            #region Structural Patterns

            #region AdapterPattern
            //StandardAdapterPattern();
            //RealWorldAdapterPattern();
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
