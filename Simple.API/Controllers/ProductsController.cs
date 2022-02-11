using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simple.API.Model;
using Simple.API.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_productService.GetAll());
        }
        [HttpGet]
        [Route("GetById")]
        public JsonResult Get(int Id)
        {
            return new JsonResult(_productService.GetByID(Id));
        }

        // POST: ProductsController/Create
        [HttpPost]
        public JsonResult Create(ProductViewModel product)
        {
            return new JsonResult(_productService.Add(product));
        }
        [HttpDelete]
        public JsonResult Delete(int Id)
        {
            return new JsonResult(_productService.Delete(Id));
        }

        [HttpPut]
        public JsonResult Edite(ProductViewModel product)
        {
            return new JsonResult(_productService.Edite(product));
        }       
    }
}
