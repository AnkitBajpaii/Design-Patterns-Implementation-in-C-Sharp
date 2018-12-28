namespace Creational.Singleton
{
    public class SingletonPatternLazyThreadSafeWithSingleLock
    {
        private static SingletonPatternLazyThreadSafeWithSingleLock instance = null;
        private static readonly object _syncRoot = new object();

        private SingletonPatternLazyThreadSafeWithSingleLock()
        {

        }

        public static SingletonPatternLazyThreadSafeWithSingleLock Instance
        {
            get
            {
                lock(_syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new SingletonPatternLazyThreadSafeWithSingleLock();
                    }
                }

                return instance;
            }
        }
    }
}
