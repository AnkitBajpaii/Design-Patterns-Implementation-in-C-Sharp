using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.Factory
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod(string type);
    }
}
