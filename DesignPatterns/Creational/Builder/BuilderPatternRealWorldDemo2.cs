using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.Builder.RealWorld
{
    public interface ISmartPhone
    {
        void SetTouchScreen();
        void SetBattery();
        void SetMotherboard();
    }

    public class AppleIPhone : ISmartPhone
    {
        public void SetBattery()
        {
            // set high performance battery
        }

        public void SetMotherboard()
        {
            // set high spec mother board
        }

        public void SetTouchScreen()
        {
            // set water resistance touch screen
        }
    }

    public class RedmiPhone : ISmartPhone
    {
        public void SetBattery()
        {
            // set normal performance battery
        }

        public void SetMotherboard()
        {
            // set normal spec mother board
        }

        public void SetTouchScreen()
        {
            // set only gorilla glass touch screen
        }
    }

    public interface ISmartPhoneBuilder
    {
        void AddBattery();
        void AddMotherboard();
        void AddTouchScreen();

        ISmartPhone GetSmartPhone();
    }

    public class AppleIPhoneBuilder : ISmartPhoneBuilder
    {
        ISmartPhone appleIPhone = new AppleIPhone();
        public void AddBattery()
        {
            appleIPhone.SetBattery();
        }

        public void AddMotherboard()
        {
            appleIPhone.SetMotherboard();
        }

        public void AddTouchScreen()
        {
            appleIPhone.SetTouchScreen();
        }

        public ISmartPhone GetSmartPhone()
        {
            return appleIPhone;
        }
    }

    public class RedmiSmartPhoneBuilder : ISmartPhoneBuilder
    {
        ISmartPhone redmiPhone = new RedmiPhone();
        public void AddBattery()
        {
            redmiPhone.SetBattery();
        }

        public void AddMotherboard()
        {
            redmiPhone.SetMotherboard();
        }

        public void AddTouchScreen()
        {
            redmiPhone.SetTouchScreen();
        }

        public ISmartPhone GetSmartPhone()
        {
            return redmiPhone;
        }
    }

    public class SmartPhoneDirector
    {
        ISmartPhoneBuilder smartPhoneBuilder;
        public SmartPhoneDirector(ISmartPhoneBuilder smartPhoneBuilder)
        {
            this.smartPhoneBuilder = smartPhoneBuilder;
        }

        public void ConstructSmartPhone()
        {
            this.smartPhoneBuilder.AddBattery();
            this.smartPhoneBuilder.AddMotherboard();
            this.smartPhoneBuilder.AddTouchScreen();
        }

        public ISmartPhone GetSmartPhone()
        {
            return this.smartPhoneBuilder.GetSmartPhone();
        }
    }
}
