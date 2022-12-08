using HW_14__InventoryAPI.Models;
using HW_14__InventoryAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW_14__InventoryAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        ActionWithProductService actionService;

        public ProductController(ActionWithProductService action)
        {
            this.actionService = action;
        }

        [HttpGet]
        public ActionResult SortByType(string type)
        {
            return Ok(actionService.SortByType(type));
        }

        [HttpGet]
        public ActionResult ViewAllProducts() 
        { 
            return Ok(actionService.ViewAllProducts());
        }

        [HttpGet]
        public ActionResult CountInventorySum()
        {
            return Ok(actionService.CountInvSum());
        }

        [HttpPost]
        public ActionResult AddProduct(ProductModel product)
        {
            actionService.AddProductToList(product);
            return Created($"Created {product.Name}", product);
        }
    }
}
