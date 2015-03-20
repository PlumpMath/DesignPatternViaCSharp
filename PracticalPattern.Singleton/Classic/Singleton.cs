namespace XiaolouT.Learning.PracticalPattern.Singleton.DoubleCheck
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static readonly object locker = new object();
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }

                }
                return instance;
            }
        }
    }
}
