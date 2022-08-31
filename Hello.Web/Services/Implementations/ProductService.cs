using Hello.Web.DTOs;
using Hello.Web.Models;
using Hello.Web.Services.Interfaces;
using static Hello.Web.Models.SD;

namespace Hello.Web.Services.Implementations
{
    public class ProductService : GenericService, IProductService
    {
        private readonly IHttpClientFactory httpClient;

        public ProductService(IHttpClientFactory httpClient) : base(httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiMethod = ApiMethod.POST,
                Data = productDto,
                Url = ProductAPIBase + "/api/product",
                AccessToken = ""
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiMethod = ApiMethod.DELETE,
                Url = ProductAPIBase + $"/api/product/{id}",
                AccessToken = ""
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiMethod = ApiMethod.GET,
                Url = ProductAPIBase + "/api/product",
                AccessToken = ""
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int id)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiMethod = ApiMethod.GET,
                Url = ProductAPIBase + $"/api/product/{id}",
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                ApiMethod = ApiMethod.PUT,
                Data = productDto,
                Url = ProductAPIBase + "/api/product",
                AccessToken = ""
            });
        }
    }
}
