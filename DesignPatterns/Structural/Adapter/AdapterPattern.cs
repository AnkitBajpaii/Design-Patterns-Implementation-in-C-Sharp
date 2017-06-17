using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Structural.Adapter
{
    public interface ITarget
    {
        void MethodA();
    }

    public class Adapter : Adaptee, ITarget
    {
        public void MethodA()
        {
            Console.WriteLine("Request handled by Adapter class. Adapter is now communicating with Adaptee..");
            Thread.Sleep(2000);
            MethodB();
        }
    }

    public class Adaptee
    {
        public void MethodB()
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

            _target.MethodA();
        }
    }
}