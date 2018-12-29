using System;

namespace Structural.Bridge.RealWorld
{

    //implementation
    public interface IColor
    {
        void applyColor();
    }

    //Concrete implementor 1
    public class RedColor : IColor
    {
        public void applyColor()
        {
            Console.WriteLine("Applied red color");
        }
    }

    //Concrete implementor 2
    public class GreenColor : IColor
    {
        public void applyColor()
        {
            Console.WriteLine("Applied Green color");
        }
    }

    //Abstraction
    public abstract class Shape
    {
        protected IColor color;
        public Shape(IColor color)
        {
            this.color = color;
        }

        public abstract void Paint();
    }

    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color)
        {
        }

        public override void Paint()
        {
            Console.WriteLine("inside triangle");
            this.color.applyColor();
        }
    }

    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }

        public override void Paint()
        {
            Console.WriteLine("inside circle");
            this.color.applyColor();
        }
    }
}
