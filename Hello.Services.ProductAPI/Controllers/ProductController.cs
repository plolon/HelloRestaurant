using AutoMapper;
using Hello.Services.ProductAPI.DTOs;
using Hello.Services.ProductAPI.Models;
using Hello.Services.ProductAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hello.Services.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public ProductController(IMapper mapper, IProductRepository productRepository)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            try
            {
                var products = await productRepository.GetAll();
                var productsDto = mapper.Map<IEnumerable<ProductDto>>(products);
                return HandleResponse.GetSuccessResponse(productsDto, "");
            }
            catch (Exception ex)
            {
                return ex.GetFailedResponse();
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            try
            {
                var product = await productRepository.GetById(id);
                var productDto = mapper.Map<ProductDto>(product);
                return HandleResponse.GetSuccessResponse(productDto, "");
            }
            catch (Exception ex)
            {
                return ex.GetFailedResponse();
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ResponseDto> Post([FromBody] ProductDto productDto)
        {
            try
            {
                var product = mapper.Map<Product>(productDto);
                await productRepository.Create(product);
                return HandleResponse.GetSuccessResponse(productDto, "");
            }
            catch (Exception ex)
            {
                return ex.GetFailedResponse();
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public async Task<ResponseDto> Put([FromBody] ProductDto productDto)
        {
            try
            {
                var product = mapper.Map<Product>(productDto);
                await productRepository.Update(product);
                return HandleResponse.GetSuccessResponse(productDto, "");
            }
            catch (Exception ex)
            {
                return ex.GetFailedResponse();
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            try
            {
                await productRepository.Delete(id);
                return HandleResponse.GetSuccessResponse(true, "");
            }
            catch (Exception ex)
            {
                return ex.GetFailedResponse();
            }
        }
    }
}
