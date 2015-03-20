using System.Web;

namespace RedirectDemo
{
    /// <summary>
    /// Summary description for TestHandler
    /// </summary>
    public class TestHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.StatusCode = 307;
            context.Response.RedirectLocation = "TargetHandler.ashx";
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}