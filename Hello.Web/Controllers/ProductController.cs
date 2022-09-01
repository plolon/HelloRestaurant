using Hello.Web.DTOs;
using Hello.Web.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hello.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        // GET: ProductController
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDto> products = new();
            var response = await productService.GetAllProductsAsync<ResponseDto>();
            if (response != null && response.Success)
            {
                products = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));
            }
            return View(products);
        }

        // GET: ProductController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductDto model)
        {
            try
            {
                var response = await productService.CreateProductAsync<ResponseDto>(model);
                if (response != null && response.Success)
                {
                    return RedirectToAction("ProductIndex");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }

        // GET: ProductController/Edit/5
        public async Task<IActionResult> Edit(int productId)
        {
            var response = await productService.GetProductByIdAsync<ResponseDto>(productId);
            if(response != null && response.Success)
            {
                ProductDto model = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));
                return View(model);
            }
            return NotFound();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductDto model)
        {
            try
            {
                var response = await productService.UpdateProductAsync<ResponseDto>(model);
                if (response != null && response.Success)
                {
                    return RedirectToAction("ProductIndex");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View(model);
        }
        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int productId)
        {
            try
            {
                var response = await productService.DeleteProductAsync<ResponseDto>(productId);
                if (response != null && response.Success)
                {
                    return RedirectToAction("ProductIndex");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View();
        }
    }
}
