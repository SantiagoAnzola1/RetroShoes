using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using WebAppV2.Models;
using WebAppV2.Repository;
using System.Data.SqlClient;
using System.Xml.Linq;
//using WebMatrix.WebData.dll;
//using System.Web.Optimization;
//using System.Web.ApplicationServices;
//using System.Web.Security;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace WebAppV2.Controllers
{
    public class MarcasController : Controller
    {
        [Area("Products")]
        //private readonly ILogger<MarcasController> _logger;

        //MarcasController(ILogger<MarcasController> logger)
        //{
        //    _logger = logger;
        //}
        public  IActionResult Index()
        {

            return View("Views/Home/Index.cshtml"); 
        }

        public async Task<IActionResult> Adidas()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
        }

        public async Task<IActionResult> Nike()
        {

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
            
        }
        public async Task<IActionResult> Puma()
        {

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
            
        }
        public async Task<IActionResult> UnderArmour()
        {

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
            
        }
        public async Task<IActionResult> Fila()
        {

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
            
        }
        public async Task<IActionResult> Reebok()
        {

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
            
        }
        public async Task<IActionResult> Vans()
        {

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
            
        }
        public async Task<IActionResult> Converse()
        {

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
            
        }
        public async Task<IActionResult> NewBalance()
        {

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
            
        }


        
    }
}