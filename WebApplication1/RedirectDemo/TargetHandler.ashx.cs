using System.IO;
using System.Web;
using System.Web.Script.Serialization;

namespace RedirectDemo
{
    /// <summary>
    /// Summary description for TargetHandler
    /// </summary>
    public class TargetHandler : IHttpHandler
    {

        public class Input
        {
             public  string Value { get; set; }
        }

        public void ProcessRequest(HttpContext context)
        {

            var input = Deserialize<Input>(context);
            context.Response.AddHeader("Content-Type", "application/json");
            string message;
            if (input!=null)
            {
                message = "You typed '" + input.Value + "'";
            }
            else
            {
                message = "The data is lost";
            }

            context.Response.Write(new JavaScriptSerializer().Serialize(new { message = message }));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public T Deserialize<T>(HttpContext context)
        {
            //read the json string
            string jsonData = new StreamReader(context.Request.InputStream).ReadToEnd();

            //cast to specified objectType
            var obj = new JavaScriptSerializer().Deserialize<T>(jsonData);

            //return the object
            return obj;
        }
    }
}