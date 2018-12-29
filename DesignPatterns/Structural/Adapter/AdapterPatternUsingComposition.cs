using System;

namespace Structural.Adapter.Standard.Composition
{
    public interface ITarget
    {
        void Request();
    }

    public class Adaptor : ITarget
    {
        IAdaptee adaptee;
        public Adaptor(IAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            Console.WriteLine("Adaptor will use adaptee to serve domain specific request");
            this.adaptee.SpecificRequest();
        }
    }

    public interface IAdaptee
    {
        void SpecificRequest();
    }

    public class Adaptee : IAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("specific request served from adaptee");
        }
    }
}
