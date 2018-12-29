using System;

namespace Structural.Bridge.RealWorld
{
    //implementator
    public interface IDataServiceBridge
    {
        void Send(string msg);
    }

    //implementation
    public class WebService : IDataServiceBridge
    {
        public void Send(string msg)
        {
            Console.WriteLine("send data using a web service");
        }
    }

    //implementation
    public class WCFService : IDataServiceBridge
    {
        public void Send(string msg)
        {
            Console.WriteLine("send data using a WCF service");
        }
    }

    //implementation
    public class ThirdPartyAPIService : IDataServiceBridge
    {
        public void Send(string msg)
        {
            Console.WriteLine("send data using a third party api service");
        }
    }

    public abstract class SendData
    {
        protected IDataServiceBridge serviceBridge;
        public SendData(IDataServiceBridge serviceBridge)
        {
            this.serviceBridge = serviceBridge;
        }
        public abstract void Send(string msg);
    }

    public class SendEmail : SendData
    {
        public SendEmail(IDataServiceBridge serviceBridge) : base(serviceBridge)
        {
        }

        public override void Send(string msg)
        {
            this.serviceBridge.Send(msg);
        }
    }

    public class SendSMS : SendData
    {
        public SendSMS(IDataServiceBridge serviceBridge) : base(serviceBridge)
        {
        }

        public override void Send(string msg)
        {
            this.serviceBridge.Send(msg);
        }
    }
}
