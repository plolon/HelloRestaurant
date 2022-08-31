using static Hello.Web.Models.SD;

namespace Hello.Web.Models
{
    public class ApiRequest
    {
        public ApiMethod ApiMethod { get; set; }
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }

    public static class SD
    {
        public static string ProductAPIBase { get; set; }
        public enum ApiMethod
        {
            GET,
            POST,
            PUT,
            DELETE,
        }
    }
}
