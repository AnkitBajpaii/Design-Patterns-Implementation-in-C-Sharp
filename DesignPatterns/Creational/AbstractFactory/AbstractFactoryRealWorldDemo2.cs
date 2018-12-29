using System;

namespace Creational.AbstractFactory.RealWorld
{
    public interface IButton
    {
        void Click();
    }

    public class WinButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Window button clicked");
        }
    }

    public class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("Mac button clicked");
        }
    }

    public interface ICheckBox
    {
        void Check();
    }

    public class WinCheckBox : ICheckBox
    {
        public void Check()
        {
            Console.WriteLine("Windows check box checked");
        }
    }

    public class MacCheckBox : ICheckBox
    {
        public void Check()
        {
            Console.WriteLine("Mac check box checked");
        }
    }

    public interface IGUIFactory
    {
        IButton GetButton();
        ICheckBox GetCheckBox();
    }

    // Concrete factories produce a family of products that belong to a single variant
    public class WinUIFactory : IGUIFactory
    {
        //windows family button
        public IButton GetButton()
        {
            return new WinButton();
        }

        //windows family checkbox
        public ICheckBox GetCheckBox()
        {
            return new WinCheckBox();
        }
    }

    // Concrete factories produce a family of products that belong to a single variant
    public class MacUIFactory : IGUIFactory
    {
        //mac family button
        public IButton GetButton()
        {
            return new MacButton();
        }

        //mac family checkbox
        public ICheckBox GetCheckBox()
        {
            return new MacCheckBox();
        }
    }

    public class GUIClient
    {
        IButton button;
        ICheckBox checkBox;

        public GUIClient(IGUIFactory factory)
        {
            button = factory.GetButton();
            checkBox = factory.GetCheckBox();
        }

        public IButton GetButton()
        {
            return button;
        }

        public ICheckBox GetCheckBox()
        {
            return checkBox;
        }
    }
}
