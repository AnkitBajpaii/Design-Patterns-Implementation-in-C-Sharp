namespace Creational.Singleton.Standard
{
    class SingletonPatternEagerInstantiationThreadSafe
    {
        private static readonly SingletonPatternEagerInstantiationThreadSafe instance = null;
       
        static SingletonPatternEagerInstantiationThreadSafe()
        {
            instance = new SingletonPatternEagerInstantiationThreadSafe();
        }

        private SingletonPatternEagerInstantiationThreadSafe()
        {
        }

        public static SingletonPatternEagerInstantiationThreadSafe Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
