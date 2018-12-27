using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.AbstractFactory
{
    public interface IHerbivore
    {

    }

    public interface ICarnivore
    {
        void Eats(IHerbivore h);
    }

    public interface IContinentFactory
    {
        IHerbivore CreateHerbivore();
        ICarnivore CreateCarnivore();
    }

    public class IndianFactory : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Cow();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    public class AmericanFactory : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    public class Cow : IHerbivore
    {

    }

    public class Bison : IHerbivore
    {

    }

    public class Lion : ICarnivore
    {
        public void Eats(IHerbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    public class Wolf : ICarnivore
    {
        public void Eats(IHerbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    public class AnimalWorld
    {
        private IHerbivore herbivore;
        private ICarnivore carnivore;

        public AnimalWorld(IContinentFactory continentFactory)
        {
            this.herbivore = continentFactory.CreateHerbivore();
            this.carnivore = continentFactory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            this.carnivore.Eats(this.herbivore);
        }
    }
}
