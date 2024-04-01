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
    public class PedidoController : Controller
    {
        [Area("Pedido")]

        public IActionResult Index()
        {

            return View("Views/Home/Index.cshtml");
        }
        [Authorize]
        public async Task<IActionResult> Pedido()
        {
            ProductApi repository = new ProductApi();
            String result = "";

            //string userID= this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            result = await repository.GetProductsRequestAsync();

            List<Product> oProducts = new List<Product>();
            oProducts = (List<Product>)JsonConvert.DeserializeObject(result, typeof(List<Product>));
            return View(oProducts);
        }
        [Authorize]
        public async Task<IActionResult> Orden()
        {
            OrdenApi repository = new OrdenApi();
            String result = "";

            string userID= this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            result = await repository.GetOrdenByCLienteIDRequestAsync(userID);

            List<Orden> oProducts = new List<Orden>();
            oProducts = (List<Orden>)JsonConvert.DeserializeObject(result, typeof(List<Orden>));
            return View(oProducts);
        }


        [HttpPost]
        public async Task<ActionResult> CreatePedido(string Direccion)

        {
            return null;
        //    string[] list = new string[5] { "2", "11", "25", "29", "31" };
        //    List <int> temp= new List<int>();
        //    List<string> temp2 = new List<string>();
        //    string direction = Direccion;
        //    string userID= this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        //    //string userID = "88";
        //    foreach (string l in list)
        //    {

        //        ProductApi pa = new ProductApi();
        //        string r = "";
        //        r = await pa.GetProductByIdRequestAsync(Int32.Parse(l));
        //        List<Product> oUsers = new List<Product>();
        //        oUsers = (List<Product>)JsonConvert.DeserializeObject(r, typeof(List<Product>));

        //        PedidoDetalle pedido = new PedidoDetalle();
        //        pedido.Cantidad = 2;
        //        pedido.PrecioIndividual = oUsers[0].Precio;
        //        Console.WriteLine(pedido.PrecioIndividual);
        //        Console.WriteLine(oUsers[0].Precio);
               
        //        pedido.Cedula = userID;
        //        pedido.ProductId = l;

        //        Int32 x = await pa.GetStockRequestAsync(l);
        //        Console.WriteLine("Stock: " + x);
        //        Console.WriteLine("Stock2: " + oUsers[0].Stock);
        //        Console.WriteLine("Stock3: " + Convert.ToInt32(oUsers[0].Stock));
                
        //        if (Convert.ToInt32(oUsers[0].Stock) == 0)
        //        {
        //            int contTemp = 0;
        //            foreach (string h in temp2)
        //            {
        //                OrdenApi ordentemp = new OrdenApi();
        //                await pa.UpdateStockRequestAsync(h, temp[contTemp]);
        //                await ordentemp.DeleteOrdenRequestAsync(userID);
        //                contTemp++;
        //            }
        //            ProductApi reep = new ProductApi();
        //            String rre = "";

        //            //string userID= this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        //            rre = await reep.GetProductsRequestAsync();

        //            List<Product> oProducts = new List<Product>();
        //            oProducts = (List<Product>)JsonConvert.DeserializeObject(rre, typeof(List<Product>));
        //            ModelState.AddModelError(""+l, "¡Sin unidades disponibles!");




        //            return View("Pedido", oProducts);
        //        }
        //        else if (((Convert.ToInt32(oUsers[0].Stock)) -pedido.Cantidad)<0)
        //        {
        //            Console.WriteLine("Stock NEGATIVO: " + (x-pedido.Cantidad));

        //            int contTemp = 0;
        //            foreach (string h in temp2)
        //            {
                       
        //                await pa.UpdateStockRequestAsync(h, temp[contTemp]);
                        
        //                contTemp++;

        //            }


        //            ProductApi reep = new ProductApi();
        //            String rre = "";

                    
        //            rre = await reep.GetProductsRequestAsync();
        //            List<Product> oProducts = new List<Product>();
        //            oProducts = (List<Product>)JsonConvert.DeserializeObject(rre, typeof(List<Product>));
        //            ModelState.AddModelError(""+l, "¡Unicamente! " + (Convert.ToInt32(oUsers[0].Stock)) + " unidad(es) disponibles para "+ oUsers[0].ProductName);

        //            OrdenApi ordentemp = new OrdenApi();
        //            await ordentemp.DeleteOrdenRequestAsync(userID);
        //            return View("Pedido", oProducts);
        //        }
        //        else
        //        {
        //            temp2.Add(oUsers[0].ProductId);
        //            temp.Add((Convert.ToInt32(oUsers[0].Stock)));
        //            await pa.UpdateStockRequestAsync(l, ((Convert.ToInt32(oUsers[0].Stock)) - pedido.Cantidad));
        //        }



        //        PedidoDetalleApi repository = new PedidoDetalleApi();
        //        String result = "";
        //        result = await repository.CreatePedidoRequestAsync(pedido);

        //    }

        //    OrdenApi m = new OrdenApi();
        //    Orden orden = new Orden();
        //    String g = await m.GetOrdenSmaTotalRequestAsync(userID);
        //    //decimal suma = Convert.ToDecimal(g);  
        //    Console.WriteLine("SumaTotalDecimal: " + Convert.ToDecimal((g.Replace('.', ','))));
        //    orden.ClienteId = userID;
        //    orden.PrecioTotal = Convert.ToDecimal((g.Replace('.', ',')));
        //    orden.Entrega = direction;
        //    orden.EsEntregado = false;
        //    await m.CreateOrdenRequestAsync(orden);


        //    OrdenApi repository2 = new OrdenApi();
        //    String result2 = "";

            
        //    result2 = await repository2.GetOrdenByCLienteIDRequestAsync(userID);

        //    List<Orden> op = new List<Orden>();
        //    op = (List<Orden>)JsonConvert.DeserializeObject(result2, typeof(List<Orden>));
            

        //    return RedirectToAction("Orden", op);
        //    //string userID = "77";
        //    //PedidoDetalleApi repository = new PedidoDetalleApi();
        //    //String result = "";
        //    //result= await repository.CreatePedidosListRequestAsync(list, userID);
        //    //return RedirectToAction("Index");
        }


    }
}