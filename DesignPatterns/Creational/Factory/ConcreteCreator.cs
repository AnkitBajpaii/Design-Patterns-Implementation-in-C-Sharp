using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.Factory
{
    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod(string type)
        {
            IProduct product = null;
            if (type.Equals("ConcreteProductA"))
            {
                product = new ConcreteProductA();
            }

            else if (type.Equals("ConcreteProductB"))
            {
                product = new ConcreteProductB();
            }

            else if (type.Equals("ConcreteProductC"))
            {
                product = new ConcreteProductC();
            }

            return product;
        }
    }
}
