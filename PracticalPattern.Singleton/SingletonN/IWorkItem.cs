namespace XiaolouT.Learning.PracticalPattern.Singleton.SingletonN
{
    public interface IWorkItem
    {
        Status Status { get; set; }
        void DeActivate();
    }

}
