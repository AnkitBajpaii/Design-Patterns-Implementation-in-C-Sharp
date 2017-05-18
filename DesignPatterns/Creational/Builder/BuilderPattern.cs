using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Respecting the dependency inversion principle
namespace Creational.Builder
{
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

        public ConcreteBuilder(IProduct product)
        {
            _product = product;
        }
        public void BuildPart1()
        {
            _product.Part1 = "Builded Part 1";
        }

        public void BuildPart2()
        {
            _product.Part2 = "Builded Part 2";
        }

        public void BuildPart3()
        {
            _product.Part3 = "Builded Part 3";
        }

        public IProduct GetProduct()
        {
            return _product;
        }
    }

    public interface IProduct
    {
        string Part1 { get; set; }
        string Part2 { get; set; }
        string Part3 { get; set; }

        void ShowInfo();
    }

    public class Product : IProduct
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Part 1 " + Part1);
            Console.WriteLine("Part 2 " + Part2);
            Console.WriteLine("Part 3 " + Part3);
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
