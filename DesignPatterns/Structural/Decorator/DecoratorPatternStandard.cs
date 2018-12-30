using System;

namespace Structural.Decorator.Standard
{
    public interface IComponent
    {
        void Operation1();
    }

    public class ConcreteComponent : IComponent
    {
        public void Operation1()
        {
            Console.WriteLine("Basic operation");
        }
    }

    public abstract class AbstractDecorator : IComponent
    {
        protected IComponent component;
        public AbstractDecorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation1()
        {
            this.component.Operation1();            
        }
    }

    public class ConcreteDecorator : AbstractDecorator
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
        }

        public override void Operation1()
        {
            base.Operation1();
            this.AdvanceOperation();            
        }

        public void AdvanceOperation()
        {
            this.component.Operation1();
            Console.WriteLine("Advance operation");
        }
    }
}
