using System;

namespace Creational.Singleton
{
    public sealed class SingletonUsingBuiltInLazyType
    {
        private static readonly Lazy<SingletonUsingBuiltInLazyType> lazy = new Lazy<SingletonUsingBuiltInLazyType>(() => new SingletonUsingBuiltInLazyType());

        public static SingletonUsingBuiltInLazyType Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        private SingletonUsingBuiltInLazyType()
        {

        }
    }
}
