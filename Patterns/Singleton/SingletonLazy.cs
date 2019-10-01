using System;

namespace Patterns.Singleton
{
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> lazyInstance = new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy() { }

        public static SingletonLazy Instance { get { return lazyInstance.Value; } }
    }
}
