using MakeYourDiet.Interfaces;
using MakeYourDiet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MakeYourDiet.Controllers
{
    [Authorize]
    public class ProductController : BaseApiController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductList()
        {
            var productList = await _productService.GetAllProducts();
            if (productList == null) return NotFound();

            return Ok(productList);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<Product>> GetProductById(int productId)
        {
            var product = await _productService.GetProductById(productId);

            if (product == null) return BadRequest("Couldn't find product");

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(Product product)
        {
            var isProductCreated = await _productService.CreateProduct(product);

            if (!isProductCreated) return BadRequest("Couldn' create product");

            return Ok(isProductCreated);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProdcut(Product product)
        {
            if (product == null) return BadRequest("Product dosen't exist");

            var isProductCreated = await _productService.UpdateProduct(product);
            
            if (!isProductCreated) return BadRequest("Couldn't update product");

            return Ok(isProductCreated);
        }

        [HttpDelete("{productId}")]
        public async Task<ActionResult> DeleteProduct(int productId)
        {
            var isProductCreated = await _productService.DeleteProduct(productId);

            if (!isProductCreated) return BadRequest("Couldn't delete product");

            return Ok(isProductCreated);
        }
    }
}