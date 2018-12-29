using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structural.Bridge.Standard
{
    // implementor
    public interface IImplementor
    {
        void Implentation();
    }

    //concrete implementor 1
    public class ConcreteImplementor1 : IImplementor
    {
        public void Implentation()
        {
            Console.WriteLine("ConcreteImplementor1 Implementation");
        }
    }

    //concrete implementor 2
    public class ConcreteImplementor2 : IImplementor
    {
        public void Implentation()
        {
            Console.WriteLine("ConcreteImplementor2 Implementation");
        }
    }

    //Abstraction
    public abstract class Abstraction
    {
        protected IImplementor implementor;
        public Abstraction(IImplementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void Operation();
    }

    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(IImplementor implementor) : base(implementor)
        {
        }

        public override void Operation()
        {
            this.implementor.Implentation();
        }
    }
}
