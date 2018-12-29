namespace Creational.Singleton.Standard
{
    public sealed class SingletonPatternLazyAndNonThreadSafe
    {
        private static SingletonPatternLazyAndNonThreadSafe instance = null;

        private SingletonPatternLazyAndNonThreadSafe()
        {

        } 

        public static SingletonPatternLazyAndNonThreadSafe Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonPatternLazyAndNonThreadSafe();
                }

                return instance;
            }
        }
    }
}
