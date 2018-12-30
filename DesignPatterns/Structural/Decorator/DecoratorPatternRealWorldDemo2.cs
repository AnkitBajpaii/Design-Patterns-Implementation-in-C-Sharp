using System;

namespace Structural.Decorator.RealWorld
{
    public interface ICoffee
    {
        double GetCost();
        string GetIngredients();
    }

    public class Coffee : ICoffee
    {
        public double GetCost()
        {
            return 1;
        }

        public string GetIngredients()
        {
            return "Simple Coffee";
        }
    }

    public abstract class CoffeeDecorator : ICoffee
    {
        ICoffee coffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual double GetCost()
        {
            return coffee.GetCost();
        }

        public virtual string GetIngredients()
        {
            return coffee.GetIngredients();
        }
    }

    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }
        public override double GetCost()
        {
            return base.GetCost() + 0.5;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + "," + AddMilk();
        }

        string AddMilk()
        {
            return " Added Milk";
        }
    }

    public class ChocolateDecorator : CoffeeDecorator
    {
        public ChocolateDecorator(ICoffee coffee) : base(coffee)
        {
        }
        public override double GetCost()
        {
            return base.GetCost() + 10;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + "," + AddChocolate();
        }

        string AddChocolate()
        {
            return " Added Chocolate";
        }
    }
}
