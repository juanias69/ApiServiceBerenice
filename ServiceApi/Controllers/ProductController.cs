
using Entidades.Core;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Web.Http.Cors;

namespace ServiceApi.Controllers
{
    [Route("api/Product")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var obj = _productService.GetAllProducts();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            try
            {
                var obj = _productService.GetProductById(id);
                if (obj == null)
                    return BadRequest("Producto no entrado.");
                return Ok(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet("{text}")]
        public async Task<ActionResult<List<Product>>> GetByText(String text)
        {
            try
            {
                var obj = _productService.GetProductByText(text);
                if (obj == null)
                    return BadRequest("Producto no entrado.");
                return Ok(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        public async Task<ActionResult<bool>> AddProduct(Product obj)
        {
            bool res = true;

            try
            {
                _productService.AddProduct(obj);
            }
            catch (Exception ex)
            {
                res = false;
                throw ex;
            }

            return res;
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateProduct(Product obj)
        {
            bool res = true;

            try
            {
                _productService.UpdateProduct(obj);
            }
            catch (Exception ex)
            {
                res = false;
                throw ex;
            }
            return res;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteProduct(int id)
        {
            bool res = true;
            try
            {
                _productService.DeleteProduct(id);

            }
            catch (Exception ex)
            {
                res = false;
                throw ex;
            }
            return res;
        }
    }
}
