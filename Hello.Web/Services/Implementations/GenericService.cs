using Hello.Services.ProductAPI.DTOs;
using Hello.Web.Models;
using Hello.Web.Services.Interfaces;
using Newtonsoft.Json;
using System.Text;
using static Hello.Web.Models.SD;

namespace Hello.Web.Services.Implementations
{
    public class GenericService : IGenericService
    {
        public ResponseDto Response { get; set; }
        public IHttpClientFactory httpClient { get; set; }

        public GenericService(IHttpClientFactory httpClient)
        {
            this.Response = new ResponseDto();
            this.httpClient = httpClient;
        }

        public async Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("HelloAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                client.DefaultRequestHeaders.Clear();
                if (apiRequest.Data != null)
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8, "application/json");
                HttpResponseMessage apiResponse = null;
                switch (apiRequest.ApiMethod)
                {
                    case ApiMethod.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case ApiMethod.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case ApiMethod.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }
                apiResponse = await client.SendAsync(message);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseDto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDto;
            }
            catch (Exception ex)
            {
                var dto = new ResponseDto
                {

                    Message = "Error",
                    ErrorMessages = new List<string> { Convert.ToString(ex.Message) },
                    Success = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var apiResponseDto = JsonConvert.DeserializeObject<T>(res);
                return apiResponseDto;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
