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
using System.Globalization;

namespace WebAppV2.Controllers
{
    public class HomeController : Controller
    {
        public string UserName;
        public string UserEmail;
        public string UserPassword;
        public string UserCedula;
        public string Alerta;
        public bool isLogged;
        public Product productById;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {

            //UserAPI repository = new UserAPI();
            //String result = "";
            //result = await repository.GetUsersRequestAsync();

            //List<User> oUsers = new List<User>();
            //oUsers = (List<User>)JsonConvert.DeserializeObject(result, typeof(List<User>));
            //ViewBag.NameUser = "1193253729";


            //return View(oUsers);

            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));


            ViewBag.ProductById = null;
            return View(oProducts);
            //return View();
        }
        public async Task<IActionResult> GetProductById(string id)
        {
            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.GetProductByIdRequestAsync(Int32.Parse(id));
            Product oProduct = new Product();
            oProduct = (Product)JsonConvert.DeserializeObject(result, typeof(Product));


           
            //Console.WriteLine(ViewBag.ProductById.ProductName);
            return View("ProductDetails", oProduct);

        }
        //public async Task<IActionResult> UpdateProduct(string productName, string productId, string stock, string precio, string categoria, string imagen, string marca, string genero)
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            //string p = product.Precio.ToString().Replace(',', '.');
            //decimal precioDecimal = decimal.Parse(p, CultureInfo.InvariantCulture);
            //product.Precio = precioDecimal;
            //Product product =new Product(productName, productId, stock,precioDecimal, categoria, imagen, marca, genero);
            ProductApi repository = new ProductApi();
            String result = "";
            result = await repository.UpdateProdcutAsync(product);
            Product oProduct = new Product();
            oProduct = (Product)JsonConvert.DeserializeObject(result, typeof(Product));



            //Console.WriteLine(ViewBag.ProductById.ProductName);
            return View("ProductDetails", oProduct);

        }

        
        public IActionResult ProductDetails()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

       
        public IActionResult SignUp()
        {
            if (ViewBag.Cedula == null)
            { ViewBag.Cedula = ""; }


            ViewBag.Cedula = "" + UserCedula;
            return View();
        }
        public async Task<IActionResult> Pedido()
        {
            ProductApi re = new ProductApi();
            String res = "";
            res = await re.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(res, typeof(List<Product>));
            return View(oProducts);

            ModelState.AddModelError("validacion", "¡Sin unidades disponibles!");

            return View("Views/Pedido/Pedido.cshtml", oProducts);
           
        }

        [Authorize]
        public async Task<IActionResult> UserInfo()
        {
            UserAPI repository = new UserAPI();
            String result = "";
           
            List<User> oUsers = new List<User>();
            oUsers = (List<User>)JsonConvert.DeserializeObject(result, typeof(List<User>));

            //User oUsers = new User();
            //oUsers = JsonConvert.DeserializeObject<User>(result);

            ViewBag.NameUser = this.User.FindFirst(ClaimTypes.Name).Value; ;
            ViewBag.IdUser = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewBag.Email = this.User.FindFirst(ClaimTypes.Email).Value;
            ViewBag.Password =this.User.FindFirst("Password").Value;

            if (ViewBag.NameUser == null) 
            { ViewBag.NameUser = "";}
            else if (ViewBag.IdUser == null) 
            { ViewBag.IdUser = ""; }
            else if (ViewBag.Email == null) 
            { ViewBag.Email = ""; }
            else if (ViewBag.Password == null) 
            { ViewBag.Password = ""; }

                return View(oUsers);
        }        

        

        public IActionResult SignUpError(string UserCedula)
        {
            
            ViewBag.Cedula = "";
            return RedirectToAction("SignUp");
        }
        //public ActionResult SetUserInfo(String UserName, String Email, String Password)
        //{
        //    User user = new User();

        //    user.UserName = UserName;
        //    user.Email = Email;
        //    user.Password = Password;

        //    return View(user);
        //}
        //, string Email, string Password, string Cedula
       
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateUser(User oUser)
        {
            
             UserName = oUser.UserName;
             UserEmail = oUser.Email;
             UserPassword = oUser.Password;
             UserCedula = oUser.Cedula;
            UserAPI repository = new UserAPI();
            String result = "";
            String result1 = "";
            bool respond = Boolean.Parse(await repository.IsRegisterRequestAsync(Int32.Parse(UserCedula)));
            Console.WriteLine(respond);
            //User user = new User();
            //user.UserName = UserName;
            //user.Email = UserEmail;
            //user.Password = UserPassword;
            //user.Cedula = UserCedula;
            if (respond)
            {
               
                UserCedula = "¡Usuario invalido!";
                ViewBag.Cedula = "";
                ModelState.AddModelError("cedula", "¡El usuario con ID: " + oUser.Cedula + " Ya existe!");
                return View("SignUp");
                isLogged = false;
                //lblError.Text = "El Usuario " + tbUsuario.Text + " ya existe!";
            }
            else
            {
                
                isLogged = true;
                result1 = await repository.CreateUserRequestAsync(oUser);
                //result = await repository.GetUsersByIdRequestAsync(Int32.Parse(oUser.Cedula));
                //List<User> oUsers = new List<User>();
                //oUsers = (List<User>)JsonConvert.DeserializeObject(result, typeof(List<User>));
                //UserEmail =oUsers[0].Email;
                //UserName = oUsers[0].UserName;
                var userClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, UserName),
                    new Claim(ClaimTypes.NameIdentifier, UserCedula),
                    new Claim(ClaimTypes.Email,UserEmail),
                    new Claim("Password", UserPassword)
                };

                var principal = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(principal));
                return RedirectToAction("Index");
            }
            
            

        }
        [HttpPost]
        public async Task<ActionResult> DeleteUser(string cedula)

        {
          
            //string UserCedul = Cedula;
            UserAPI repository = new UserAPI();
            String result = "";
            result = await repository.DeleteUserRequestAsync(Int32.Parse(cedula));
            //
            return RedirectToAction("Index");

        }        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Islogged(UserLog user)

        {
          
            UserCedula = user.Cedula;
            UserPassword = user.Password;
            //string User = Cedula;
            UserAPI repository = new UserAPI();
            String result = "";
            bool respond = Boolean.Parse(await repository.IsLoggedRequestAsync(user));
            //result = await repository.GetUsersByIdRequestAsync("1111");
            //User oUsers = new User();
            //oUsers = JsonConvert.DeserializeObject<User>(result);
            if (!respond) 
            {
                UserCedula = "";
                UserPassword = "";
                ModelState.AddModelError("validacion", "¡Usuario o clave invalida!");
                return View("LogIn");
            }
            else 
            {


                result = await repository.GetUsersByIdRequestAsync(Int32.Parse(UserCedula));
                User oUsers = new User();
                oUsers = (User)JsonConvert.DeserializeObject(result, typeof(User));
                UserEmail = oUsers.Email;
                UserName = oUsers.UserName;
                var userClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, UserName),
                    new Claim(ClaimTypes.NameIdentifier, UserCedula),
                    new Claim(ClaimTypes.Email,UserEmail),
                    new Claim("Password", UserPassword)
                };

                var principal = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(principal));

                return RedirectToAction("Index");
            }
            

        }

        public async Task<ActionResult> LogOut()
        {
            UserCedula = "";
            UserPassword = "";
            UserEmail = "";
            UserName = "";
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> CreatePedido()

        {
            string[] list = new string[5] { "1", "11", "25", "29", "31" };
            //string userID= this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            foreach (var l in list)
            {
                ProductApi pa = new ProductApi();
                string r = "";
                r = await pa.GetProductByIdRequestAsync(Int32.Parse(l));
                Product oProduct = new Product();
                oProduct = (Product)JsonConvert.DeserializeObject(r, typeof(Product));

                PedidoDetalle pedido = new PedidoDetalle();
                pedido.Cantidad = 1;
                pedido.PrecioIndividual = oProduct.Precio;
                Console.WriteLine(pedido.PrecioIndividual);
                Console.WriteLine(oProduct.Precio);
                string userID = "77";
                pedido.Cedula = "80";
                pedido.ProductId = l;

                //Int32 x =  await pa.GetStockRequestAsync(l);
                Console.WriteLine("Stock: "+oProduct.Stock);
                
                if (Int32.Parse(oProduct.Stock) == 0)
                {
                  

                    ModelState.AddModelError("validacion", "¡Sin unidades disponibles!");
                    return View("Pedido");
                }
                PedidoDetalleApi repository = new PedidoDetalleApi();
                String result = "";
                result = await repository.CreatePedidoRequestAsync(pedido);
                
            }
            return RedirectToAction("Index");
            //string userID = "77";
            //PedidoDetalleApi repository = new PedidoDetalleApi();
            //String result = "";
            //result= await repository.CreatePedidosListRequestAsync(list, userID);
            //return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}