using System;

namespace Structural.Bridge.RealWorld
{
    //implementor
    public interface ITV
    {
        void powerOn();
        void powerOff();
        void changeChannel(int channel);
        int getChannel();
    }

    //concrete implementor
    public class SamsungTV : ITV
    {
        int channel = 1;
        public void changeChannel(int channel)
        {
            this.channel = channel;
            //Samsung tv specific code
            Console.WriteLine("Channel changed for samsung tv");
        }

        public void powerOff()
        {
            //Samsung tv specific code
            Console.WriteLine("samsung tv switched off");
        }

        public void powerOn()
        {
            //Samsung tv specific code
            Console.WriteLine("samsung tv switched on");
        }

        public int getChannel()
        {
            return this.channel;
        }
    }

    //concrete implementor
    public class SonyTV : ITV
    {
        int channel;
        public void changeChannel(int channel)
        {
            this.channel = channel;
            //Sony tv specific code
            Console.WriteLine("Channel changed for sony tv");
        }

        public void powerOff()
        {
            //Sony tv specific code
            Console.WriteLine("sony tv switched off");
        }

        public void powerOn()
        {
            //Sony tv specific code
            Console.WriteLine("sony tv switched on");
        }

        public int getChannel()
        {
            return this.channel;
        }
    }

    //abstraction
    public abstract class BasicTVRemoteControl
    {
        ITV _tv;
        public BasicTVRemoteControl(ITV tv)
        {
            this._tv = tv;
        }

        public void powerOff()
        {
            this._tv.powerOff();
        }

        public void powerOn()
        {
            this._tv.powerOn();
        }

        public void setChannel(int channel)
        {
            this._tv.changeChannel(channel);
        }

        protected int getChannel()
        {
            return this._tv.getChannel();
        }
    }

    public class AdvancedTVRemoteControl : BasicTVRemoteControl
    {
        public AdvancedTVRemoteControl(ITV tv) : base(tv)
        {
        }

        public void nextChannel()
        {
            var channel = this.getChannel();
            channel++;
            this.setChannel(channel);
        }
        public void prevChannel()
        {
            var channel = this.getChannel();
            channel--;
            this.setChannel(channel);
        }
    }
}
