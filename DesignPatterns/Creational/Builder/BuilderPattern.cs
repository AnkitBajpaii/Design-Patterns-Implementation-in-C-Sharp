using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.Builder
{
    public interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();

        Product GetProduct();
    }

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

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

        public Product GetProduct()
        {
            return _product;
        }
    }

    public class Product
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

        public Product GetProduct()
        {
            return builder.GetProduct();
        }
    }
}
