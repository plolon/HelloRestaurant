using Hello.Services.ProductAPI.DTOs;
using Hello.Web.Models;

namespace Hello.Web.Services.Interfaces
{
    public interface IGenericService :IDisposable
    {
        ResponseDto Response { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
