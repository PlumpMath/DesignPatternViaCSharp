
namespace XiaolouT.Learning.PracticalPattern.Common
{
    public interface IObjectBuilder
    {
        T BuildUp<T>(object[] args);

        T BuildUp<T>() where T : new();

        T BuildUp<T>(string typeName);

        T BuildUp<T>(string typeName, object[] args);
    }
}
