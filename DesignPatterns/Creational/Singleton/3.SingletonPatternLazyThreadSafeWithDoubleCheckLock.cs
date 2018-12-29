namespace Creational.Singleton.Standard
{
    public sealed class SingletonPatternLazyThreadSafeWithDoubleCheckLock
    {
        private static SingletonPatternLazyThreadSafeWithDoubleCheckLock _instance;
        private static readonly object _syncRoot = new object();

        private SingletonPatternLazyThreadSafeWithDoubleCheckLock()
        {

        }

        //For global access
        public static SingletonPatternLazyThreadSafeWithDoubleCheckLock Instance
        {
            get 
            {
                if (_instance == null)
                {
                    // for thread synchronization
                    lock (_syncRoot)
                    {
                        if(_instance == null)
                            _instance = new SingletonPatternLazyThreadSafeWithDoubleCheckLock();
                    }
                }

                return _instance; 
            }
        }
    }
}
