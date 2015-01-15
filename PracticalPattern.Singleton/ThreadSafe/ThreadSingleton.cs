using System;

namespace XiaolouT.Learning.PracticalPattern.Singleton.ThreadSafe
{
    public sealed class ThreadSingleton
    {
        private ThreadSingleton() { }

        [ThreadStatic]
        private static ThreadSingleton instance;

        public static ThreadSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThreadSingleton();
                }
                return instance;
            }
        }

    }
}
