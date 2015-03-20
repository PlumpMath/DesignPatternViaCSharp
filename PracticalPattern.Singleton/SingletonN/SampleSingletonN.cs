namespace XiaolouT.Learning.PracticalPattern.Singleton.SingletonN
{
    public sealed class SampleSingletonN : IWorkItem
    {
        private const int MaxInstance = 2;
        private Status status = Status.Free;
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        public void DeActivate()
        {
            status = Status.Free;
        }

        private static readonly WorkItemCollection<SampleSingletonN> collection = new WorkItemCollection<SampleSingletonN>(MaxInstance);

        private SampleSingletonN() { }

        public static SampleSingletonN Instance
        {
            get
            {
                var instance = collection.GetWorkItem();
                if (instance == null)
                {
                    if (!collection.CouldAddNewInstance)
                    {
                        return null;
                    }
                }
                else
                {
                    instance.Status = Status.Busy;
                    return instance;
                }
                return null;
            }
        }
    }
}
