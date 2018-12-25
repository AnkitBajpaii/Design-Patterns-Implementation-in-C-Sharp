using System;

namespace Creational.AbstractFactory
{
    public interface IButton
    {
        void CreateButton();
    }

    public class WinButton : IButton
    {
        public void CreateButton()
        {
            Console.WriteLine("Window button created");
        }
    }

    public class MacButton : IButton
    {
        public void CreateButton()
        {
            Console.WriteLine("Mac button created");
        }
    }

    public interface ICheckBox
    {
        void CreateCheckBox();
    }

    public class WinCheckBox : ICheckBox
    {
        public void CreateCheckBox()
        {
            Console.WriteLine("Windows check box created");
        }
    }

    public class MacCheckBox : ICheckBox
    {
        public void CreateCheckBox()
        {
            Console.WriteLine("Mac check box created");
        }
    }

    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }

    // Concrete factories produce a family of products that belong to a single variant
    public class WinUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }

    // Concrete factories produce a family of products that belong to a single variant
    public class MacUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
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
            button = factory.CreateButton();
            checkBox = factory.CreateCheckBox();
        }

        public void CreateUIElements()
        {
            button.CreateButton();
            checkBox.CreateCheckBox();
        }
    }
}
