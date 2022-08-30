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
        public async Task<IEnumerable<ProductDto>> Get()
        {
            var products = await productRepository.GetAll();
            return mapper.Map<IEnumerable<ProductDto>>(products);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ProductDto> Get(int id)
        {
            var product = await productRepository.GetById(id);
            return mapper.Map<ProductDto>(product);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ProductDto> Post([FromBody] ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            await productRepository.Create(product);
            return productDto;
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public async Task<ProductDto> Put([FromBody] ProductDto productDto)
        {
            var product = mapper.Map<Product>(productDto);
            await productRepository.Update(product);
            return productDto;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await productRepository.Delete(id);
        }
    }
}
