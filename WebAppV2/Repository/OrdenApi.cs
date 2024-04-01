using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using WebAppV2.Models;

namespace WebAppV2.Repository
{
    public class OrdenApi
    {
        public async Task<String> GetPedOrdenDBRequestAsync()
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/Orden/GetOrdenDB";
                string api = "GetOrdenDB";
                using (HttpClient client = new HttpClient())
                {

                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(api);
                    result = response.Content.ReadAsStringAsync().Result;

                }
            }
            catch (Exception e)
            {
                String ex = e.Message.ToString();
                result = String.Empty;
            }
            if (result.Contains("HTTP ERROR 500"))
            {
                return @"{""ErrorMsg"":""There was an error getting the users""";
            }
            return result;
        }

        public async Task<String> GetOrdenByCLienteIDRequestAsync(string cedula)
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/Orden/";
                string api = "GetOrdenByCLienteID";
                using (HttpClient client = new HttpClient())
                {
                    String jsonString = @"{

                          ""pedidosId"": 0,
                          ""clienteId"": """ + cedula + @""",
                          ""productId"": ""string"",
                          ""productName"": ""string"",
                          ""cantidad"": 0,
                          ""precioIndividual"": 0,
                          ""precio"": 0,
                          ""precioTotal"": 0,
                          ""categoria"": ""string"",
                          ""imagen"": ""string"",
                          ""marca"": ""string"",
                          ""genero"": ""string"",
                          ""entrega"": ""string"",
                          ""esEntregado"": false

                     }";
                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync(api, content);
                    result = response.Content.ReadAsStringAsync().Result;

                }
            }
            catch (Exception e)
            {
                String ex = e.Message.ToString();
                result = String.Empty;
            }
            if (result.Contains("HTTP ERROR 500"))
            {
                return @"{""ErrorMsg"":""There was an error getting the users""";
            }
            return result;
        }
        public async Task<String> GetOrdenSmaTotalRequestAsync(string cedula)
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/Orden/";
                string api = "GetSumaTotal";
                using (HttpClient client = new HttpClient())
                {
                    String jsonString = @"{

                          ""pedidosId"": 0,
                          ""clienteId"": """ + cedula + @""",
                          ""productId"": ""string"",
                          ""productName"": ""string"",
                          ""cantidad"": 0,
                          ""precioIndividual"": 0,
                          ""precio"": 0,
                          ""precioTotal"": 0,
                          ""categoria"": ""string"",
                          ""imagen"": ""string"",
                          ""marca"": ""string"",
                          ""genero"": ""string"",
                          ""entrega"": ""string"",
                          ""esEntregado"": false

                     }";
                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync(api, content);
                    result =(response.Content.ReadAsStringAsync().Result);

                }
            }
            catch (Exception e)
            {
                String ex = e.Message.ToString();
                result = String.Empty;
            }
            if (result.Contains("HTTP ERROR 500"))
            {
                return @"{""ErrorMsg"":""There was an error getting the users""";
            }

            return result;
        }

        public async Task<String> CreateOrdenRequestAsync(Orden pedido)
        {
            String result = string.Empty;
           

            try
            {
                string url = "https://localhost:7066/Orden/";
                string api = "CreateOrden";
                using (HttpClient client = new HttpClient())
                {

                    
                    //.Replace(",", ".")
                    String jsonString = @"{

                          
                          ""clienteId"": """ + pedido.ClienteId + @""",
                          ""productId"": ""string"",
                          ""productName"": ""string"",
                          ""cantidad"": 0,
                          ""precioIndividual"": 0,
                          ""precio"": 0,
                          ""precioTotal"": """ + pedido.PrecioTotal.ToString().Replace(',', '.') + @""",
                          ""categoria"": ""string"",
                          ""imagen"": ""string"",
                          ""marca"": ""string"",
                          ""genero"": ""string"",
                          ""entrega"": """ + pedido.Entrega + @""",
                          ""esEntregado"": false

                        }";
                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync(api, content);
                    result = response.Content.ReadAsStringAsync().Result;
                  
                }
            }
            catch (Exception e)
            {
                String ex = e.Message.ToString();
                result = String.Empty;
            }
            if (result.Contains("HTTP ERROR 500"))
            {
                return @"{""ErrorMsg"":""There was an error getting the users""";
            }
            return result;
        }

        //public async Task<String> CreatePedidosListRequestAsync(string[] list,string userId)
        //{
        //    String result = string.Empty;

        //    foreach (string item in list) 
        //    {
        //        result = string.Empty;

        //        try
        //        {
        //            string url = "https://localhost:7066/PedidoDetalles/";
        //            string api = "CreatePedido";
        //            using (HttpClient client = new HttpClient())
        //            {

        //                ProductApi pa = new ProductApi();
        //                string r = "";
        //                r = await pa.GetProductByIdRequestAsync(item);
        //                List<Product> oUsers = new List<Product>();
        //                oUsers = (List<Product>)JsonConvert.DeserializeObject(r, typeof(List<Product>));

        //                String jsonString = @"{

        //                  ""cedula"": """ + userId + @""",
        //                  ""productId"": """ + item + @""",
        //                  ""cantidad"": ""1"",
        //                  ""precioIndividual"": """ + oUsers[0].Precio + @"""

        //                }";
        //                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
        //                client.BaseAddress = new Uri(url);
        //                client.DefaultRequestHeaders.Clear();
        //                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //                var response = await client.PostAsync(api, content);
        //                result= response.Content.ReadAsStringAsync().Result;

        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            String ex = e.Message.ToString();
        //            result = String.Empty;
        //        }
        //        if (result.Contains("HTTP ERROR 500"))
        //        {
        //            return @"{""ErrorMsg"":""There was an error getting the users""";
        //        }
        //        return result;
        //    }
        //    return result;

        //}


        public async Task<String> DeleteOrdenRequestAsync(string cedula)
        //
        {
            String result = string.Empty;


            try
            {
                string url = "https://localhost:7066/Orden/DeleteOrden";
                string api = "DeleteOrden";
                using (HttpClient client = new HttpClient())

                {
                    String jsonString = @"{
                          ""clienteId"": """ + cedula + @""",
                          ""productId"": ""string"",
                          ""productName"": ""string"",
                          ""cantidad"": 0,
                          ""precioIndividual"": 0,
                          ""precio"": 0,
                          ""precioTotal"": 0,
                          ""categoria"": ""string"",
                          ""imagen"": ""string"",
                          ""marca"": ""string"",
                          ""genero"": ""string"",
                          ""entrega"": """",
                          ""esEntregado"": false


                        }";
                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync(api, content);
                    result = response.Content.ReadAsStringAsync().Result;


                }
            }
            catch (Exception e)
            {
                String ex = e.Message.ToString();
                result = String.Empty;
            }
            if (result.Contains("HTTP ERROR 500"))
            {
                return @"{""ErrorMsg"":""There was an error getting the users""";
            }
            if (result.Contains("HTTP ERROR 404"))
            {
                return @"{""ErrorMsg"":""There was an error getting the users""";
            }
            return result;
        }

    }
    
}
