namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private static object obj = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (Singleton.instance == null)
                {
                    lock (obj)
                    {
                        if (Singleton.instance == null)
                        {
                            Singleton.instance = new Singleton();
                        }
                    }
                }

                return Singleton.instance;
            }
        }
    }
}
