using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Configuration;
using System.Web.Mvc;

namespace WebDeveloper.Angular.Helper
{
    public static class Application
    {
        public static string InitOptions(this UrlHelper helper)
        {
            var options = new
            {
                Url = new
                {
                    Site = helper.Content("~/"),
                    Api = ConfigurationManager.AppSettings["ApiUrl"]                    
                }
            };

            return JsonConvert.SerializeObject(options, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }
    }
}