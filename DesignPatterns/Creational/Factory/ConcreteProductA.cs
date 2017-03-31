using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.Factory
{
    public class ConcreteProductA : IProduct
    {
        public void Display()
        {
            Console.WriteLine("ConcreteProductA");
        }
    }
}
