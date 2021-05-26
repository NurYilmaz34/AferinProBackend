using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//bu olay attribute, javada annotation
    public class ProductsController : ControllerBase
    {
        //Loosly coupled = gevşek bağlılık
        //yani bir bağımlılığı var ama soyut bi bağlılık bu zayıf
        //yaniii manager'ım bigün değişirse bişey olmaz demek bu, çünkü direk ona değil onu ve onun gibileri tutan interface ile iletişimdeyim
        //IOC Container=inversion of control=bellekte new'leme yaptığım yer
        
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
