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
    public class FiltrosController : Controller
    {
        public Product productById;
        [Area("Filtros")]
        //private readonly ILogger<MarcasController> _logger;

        //MarcasController(ILogger<MarcasController> logger)
        //{
        //    _logger = logger;
        //}
        
        public IActionResult Index()
        {

            return View("Views/Home/Index.cshtml");
        }
        //public IActionResult Hofertas()
        //{
            
        //    return View("Views/Filtros/Hombres/Hofertas.cshtml");
        //}
        public async Task<IActionResult> Hombres ()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Hombre";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
        }
        public async Task<IActionResult> Hofertas ()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Hombre";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Hombres/Hofertas.cshtml", oProducts);
        }
        public async Task<IActionResult> HmasVendidos ()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Hombre";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Hombres/HmasVendidos.cshtml", oProducts);
        }
        public async Task<IActionResult> Hnuevo ()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Hombre";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Hombres/Hnuevo.cshtml", oProducts);
        }




        public async Task<IActionResult> Mujeres ()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductByGeneroRequestAsync("Mujer");

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
        }
        public async Task<IActionResult> Mofertas()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Mujer";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Mujeres/Mofertas.cshtml", oProducts);
        }
        public async Task<IActionResult> MmasVendidos()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Mujer";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Mujeres/MmasVendidos.cshtml", oProducts);
        }
        public async Task<IActionResult> Mnuevo()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Mujer";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Mujeres/Mnuevo.cshtml", oProducts);
        }



        public async Task<IActionResult> Ninos ()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductByGeneroRequestAsync("Niño");

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
        }
        public async Task<IActionResult> Nofertas()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Niño";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Ninos/Nofertas.cshtml", oProducts);
        }
        public async Task<IActionResult> NmasVendidos()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Niño";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Ninos/NmasVendidos.cshtml", oProducts);
        }
        public async Task<IActionResult> Nnuevo()
        {
            ProductApi repository = new ProductApi();
            String result = "";
            string a = "Niño";
            result = await repository.GetProductByGeneroRequestAsync(a);

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View("Views/Filtros/Ninos/Nnuevo.cshtml", oProducts);
        }
        
        public async Task<IActionResult> GetProductById(int id)
        {
            ProductApi repository = new ProductApi();
            String result="";
            result = await repository.GetProductByIdRequestAsync(id);
            Product oProducts = new Product();
            oProducts =(Product)JsonConvert.DeserializeObject(result, typeof(Product));
            productById = oProducts;
            return RedirectToAction("Index");

        }

    }
}