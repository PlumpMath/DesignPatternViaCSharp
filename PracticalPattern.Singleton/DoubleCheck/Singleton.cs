namespace XiaolouT.Learning.PracticalPattern.Singleton.ThreadSafe
{
    public sealed class Singleton
    {
        private static Singleton instance = new Singleton();
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
