using System;
using System.Threading;

// Category: Class Adaptor
namespace Structural.Adapter.Standard.ClassAdaptor
{
    public interface ITarget
    {
        void request();
    }

    public class Adapter : Adaptee, ITarget
    {
        public void request()
        {
            Console.WriteLine("Request handled by Adapter class. Adapter is now communicating with Adaptee..");
            Thread.Sleep(2000);
            SpecificRequest();
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Method B in Adaptee is called");
        }
    }
    public class Client
    {
        private ITarget _target;

        public Client(ITarget target)
        {
            _target = target;
        }
        public void MakeRequest()
        {
            Console.WriteLine("Making request from Client to Adapter...");

            //Artificial latency
            Thread.Sleep(2000);

            _target.request();
        }
    }
}