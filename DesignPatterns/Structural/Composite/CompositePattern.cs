using System;
using System.Collections.Generic;

namespace Structural.Composite.Standard
{
    public interface IComponent
    {
        void Operation1();
        void Operation2();
    }

    public class Leaf : IComponent
    {
        public void Operation1()
        {
            Console.WriteLine("Operation 1");
        }

        public void Operation2()
        {
            Console.WriteLine("Operation 2");
        }
    }

    public class Composite : IComponent
    {
        List<IComponent> components = new List<IComponent>();

        public void Operation1()
        {
            Console.WriteLine("Operation 1");
        }

        public void Operation2()
        {
            Console.WriteLine("Operation 2");
        }

        public void Add(IComponent component)
        {
            components.Add(component);
        }
    }
}
