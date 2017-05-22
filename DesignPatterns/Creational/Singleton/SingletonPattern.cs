using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creational.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static object _syncRoot = new object();

        //For global access
        public static Singleton Instance
        {
            get 
            {
                if (_instance == null)
                {
                    // for thread synchronization
                    lock (_syncRoot)
                    {
                        if(_instance == null)
                            _instance = new Singleton();
                    }
                }

                return _instance; 
            }
        }

        private Singleton()
        {

        }
    }
}
