using System;
using System.Collections.Generic;

namespace Creational.Builder
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public List<string> Accessories { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Body: {0}", Body);
            Console.WriteLine("Transmission: {0}", Transmission);
            Console.WriteLine("Accessories:");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }

    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();
        void SetAccessories();

        Vehicle GetVehicle();
    }

    public class HeroBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
        }

        public void SetBody()
        {
            objVehicle.Body = "Plastic";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void SetModel()
        {
            objVehicle.Model = "Hero";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "120 km/hr";
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }

    public class HondaBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void SetModel()
        {
            objVehicle.Model = "Honda";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "125 Km/hr";
        }

        public void SetBody()
        {
            objVehicle.Body = "Metal";
        }

        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
            objVehicle.Accessories.Add("Helmet");
            objVehicle.Accessories.Add("Ladies Foot Rest");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }

    //Director class
    public class VehicleDirector
    {
        IVehicleBuilder builder;
        public VehicleDirector(IVehicleBuilder _builder)
        {
            builder = _builder;
        }

        public void ConstructVehicle()
        {
            builder.SetAccessories();
            builder.SetBody();
            builder.SetEngine();
            builder.SetModel();
            builder.SetTransmission();
        }

        public Vehicle GetVehicle()
        {
            return builder.GetVehicle();
        }

    }
}
