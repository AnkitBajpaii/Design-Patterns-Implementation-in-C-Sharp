//Respecting the dependency inversion principle

namespace Creational.Builder
{
    public interface IProduct
    {
        void SetPart1();
        void SetPart2();
        void SetPart3();
    }

    public class Product : IProduct
    {
        string part1;
        string part2;
        string part3;

        public void SetPart1()
        {
            this.part1 = "part1 is ready";
        }

        public void SetPart2()
        {
            this.part2 = "part2 is ready";
        }

        public void SetPart3()
        {
            this.part3 = "part3 is ready";
        }
    }

    public interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();

        IProduct GetProduct();
    }

    public class ConcreteBuilder : IBuilder
    {
        private IProduct _product;

        public ConcreteBuilder()
        {
            _product = new Product();
        }
        public void BuildPart1()
        {
            _product.SetPart1();
        }

        public void BuildPart2()
        {
            _product.SetPart2();
        }

        public void BuildPart3()
        {
            _product.SetPart3();
        }

        public IProduct GetProduct()
        {
            return _product;
        }
    }

    public class Director
    {
        IBuilder builder;

        public Director(IBuilder _builder)
        {
            builder = _builder;
        }

        public void Construct()
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
        }

        public IProduct GetProduct()
        {
            return builder.GetProduct();
        }
    }
}
