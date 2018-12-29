using Creational.Factory.RealWorld;
using Creational.Factory.Standard;
using Creational.AbstractFactory.Standard;
using Creational.AbstractFactory.RealWorld;
using Creational.Builder.Standard;
using Creational.Builder.RealWorld;
using Creational.Prototype.RealWorld;
using Creational.Singleton.Standard;

using System;
using Structural.Adapter.Standard.ClassAdaptor;
using Structural.Adapter.RealWorld;
using Structural.Bridge.Standard;
using Structural.Bridge.RealWorld;
using Structural.Composite.RealWorld;

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

            Creational.Factory.Standard.IProduct productA = creator.FactoryMethod("A");
            productA.SomeMethod();

            Creational.Factory.Standard.IProduct productB = creator.FactoryMethod("B");
            productB.SomeMethod();
        }

        static void FactoryPatternRealWorldDemo1()
        {
            Creational.Factory.RealWorld.IVehicleFactory factory = new ConcreteVehicleFactory();

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
            Creational.AbstractFactory.RealWorld.IVehicleFactory hondaFactory = new HondaFactory();
            VehicleClient hondaClient = new VehicleClient(hondaFactory, "male");
            hondaClient.DisplayProductDetails();

            Console.WriteLine();

            Creational.AbstractFactory.RealWorld.IVehicleFactory heroFactory = new HeroFactory();
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
            Creational.Builder.Standard.IProduct product = director.GetProduct();
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
            SingletonPatternLazyThreadSafeWithDoubleCheckLock Instance_1 = SingletonPatternLazyThreadSafeWithDoubleCheckLock.Instance;
            SingletonPatternLazyThreadSafeWithDoubleCheckLock Instance_2 = SingletonPatternLazyThreadSafeWithDoubleCheckLock.Instance;
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
            Client client = new Client(new Adapter());
            client.MakeRequest();
        }

        public static void RealWorldAdapterPattern()
        {
            ThirdPartyBillingSystem billingSystem = new ThirdPartyBillingSystem(new EmployeeAdapter());
            billingSystem.ShowEmployeeList();
        }

        #endregion

        #region BridgePattern

        static void BridgePatternStandard()
        {
            Abstraction _abstraction = new RefinedAbstraction(new ConcreteImplementor1());
            _abstraction.Operation();
        }

        static void BridgePatternRealWorld1()
        {
            AdvancedTVRemoteControl _remoteControl = new AdvancedTVRemoteControl(new SamsungTV());
            _remoteControl.powerOn();
            _remoteControl.setChannel(3);
            _remoteControl.nextChannel();
            _remoteControl.prevChannel();
            _remoteControl.powerOff();

            _remoteControl = new AdvancedTVRemoteControl(new SonyTV());
            _remoteControl.powerOn();
            _remoteControl.setChannel(3);
            _remoteControl.nextChannel();
            _remoteControl.prevChannel();
            _remoteControl.powerOff();
        }

        static void BridgePatternRealWorld2()
        {
            Shape _shape = new Triangle(new RedColor());
            _shape.Paint();

            _shape = new Triangle(new GreenColor());
            _shape.Paint();

            _shape = new Circle(new RedColor());
            _shape.Paint();

        }

        static void BridgePatternRealWorld3()
        {
            SendData _sendDataAbstraction = new SendEmail(new WebService());
            _sendDataAbstraction.Send("some message");

            _sendDataAbstraction = new SendSMS(new WebService());
            _sendDataAbstraction.Send("some message");

            _sendDataAbstraction = new SendEmail(new WCFService());
            _sendDataAbstraction.Send("some message");

            _sendDataAbstraction = new SendEmail(new ThirdPartyAPIService());
            _sendDataAbstraction.Send("some message");

        }

        #endregion

        #region

        static void CompositePatternStandard()
        {

        }

        static void CompositePatternRealWorld()
        {
            IFileComponent leafFile1 = new LeafFile("file 1"),
                leafFile2 = new LeafFile("file 2"),
                leafFile3 = new LeafFile("file 3"),
                leafFile4 = new LeafFile("file 4");

            Directory directoryA = new Directory("FolderA"),
                directoryB = new Directory("FolderB"),
                directoryC = new Directory("FolderC");

            directoryA.Add(leafFile1);
            directoryA.Add(directoryB);
            directoryA.Add(leafFile2);

            directoryB.Add(leafFile3);
            directoryB.Add(leafFile4);
            directoryB.Add(directoryC);

            directoryA.PrintName();
            directoryB.PrintName();
        }

        #endregion

        #endregion

        static void Main(string[] args)
        {
            // Invoke the function

            Console.ReadLine();
        }
    }
}
