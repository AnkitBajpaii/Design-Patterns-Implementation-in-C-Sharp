using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structural.Decorator.RealWorld
{
   public interface IHouse
    {
        string MakeHouse();
    }
   
    public class SimpleHouse : IHouse
    {
        public string MakeHouse()
        {
            return "Simple House";
        }
    }

    public abstract class AbstractHouseDecorator : IHouse
    {
        IHouse house;
        public AbstractHouseDecorator(IHouse house)
        {
            this.house = house;
        }

        public virtual string MakeHouse()
        {
            return house.MakeHouse();
        }
    }

    public class ColorDecorator : AbstractHouseDecorator
    {
        public ColorDecorator(IHouse house) : base(house)
        {
        }

        public override string MakeHouse()
        {
            return base.MakeHouse() + AddColors();
        }

        private string AddColors()
        {
            return " + Added Colors";
        }
    }

    public class LightsDecorator : AbstractHouseDecorator
    {
        public LightsDecorator(IHouse house) : base(house)
        {
        }

        public override string MakeHouse()
        {
            return base.MakeHouse() + AddLights();
        }

        private string AddLights()
        {
            return " + Added Lights";
        }
    }
}
