namespace Creational.Singleton.Standard
{
    public sealed class SingletonPatternFullyLazy
    {
        public static SingletonPatternFullyLazy Instance { get { return Nested.instance; } }

        private class Nested
        {

            internal static readonly SingletonPatternFullyLazy instance = new SingletonPatternFullyLazy();
        }
    }
}
