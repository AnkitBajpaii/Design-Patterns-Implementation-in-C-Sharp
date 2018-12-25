using System;

namespace Creational.AbstractFactoryRealWorld
{
    //Abstract types

    public interface IBike
    {
        string Name { get; set; }
    }

    public class SportsBike : IBike
    {
        public string Name { get; set; }

        public SportsBike(string name)
        {
            Name = name;
        }

    }

    public class RegularBike : IBike
    {
        public string Name { get; set; }

        public RegularBike(string name)
        {
            Name = name;
        }
    }

    public interface IScooter
    {
        string Name { get; set; }
    }

    public class Scooty : IScooter
    {
        public string Name { get; set; }

        public Scooty(string name)
        {
            Name = name;
        }

    }

    public class RegularScooter : IScooter
    {
        public string Name { get; set; }
        public RegularScooter(string name)
        {
            Name = name;
        }


    }

    //abstract factory
    public interface IVehicleFactory
    {
        IBike GetBike(string type);
        IScooter GetScooter(string type);
    }

    // Concrete factories produce a family of products that belong to a single variant
    public class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(string type)
        {
            string Name = "Honda " + type + " bike";
            if (type.Equals("Sports"))
                return new SportsBike(Name);
            if (type.Equals("Regular"))
                return new RegularBike(Name);

            throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", type));
        }

        public IScooter GetScooter(string type)
        {
            string Name = "Honda " + type + " scooter";
            if (type.Equals("Sports"))
                return new Scooty(Name + " Scooty");
            if (type.Equals("Regular"))
                return new RegularScooter(Name);

            throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", type));
        }
    }

    // Concrete factories produce a family of products that belong to a single variant
    public class HeroFactory : IVehicleFactory
    {

        public IBike GetBike(string type)
        {
            string Name = "Hero " + type + " bike";
            if (type.Equals("Sports"))
                return new SportsBike(Name);
            if (type.Equals("Regular"))
                return new RegularBike(Name);

            throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", type));
        }

        public IScooter GetScooter(string type)
        {
            string Name = "Hero " + type + " scooter";
            if (type.Equals("Sports"))
                return new Scooty(Name + " Scooty");
            if (type.Equals("Regular"))
                return new RegularScooter(Name);

            throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", type));
        }
    }

    public class VehicleClient
    {
        IBike _bike;
        IScooter _scooter;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            _bike = factory.GetBike(type);
            _scooter = factory.GetScooter(type);
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine("Bike : " + _bike.Name);
            Console.WriteLine("Scooter : " + _scooter.Name);
        }
    }
}
