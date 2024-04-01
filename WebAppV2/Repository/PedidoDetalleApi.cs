using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using WebAppV2.Models;

namespace WebAppV2.Repository
{
    public class PedidoDetalleApi
    {
        public async Task<String> GetPedidosDBRequestAsync()
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/PedidoDetalles/GetPedidosDB";
                string api = "GetPedidosDB";
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

        public async Task<String> GetProductByUserIDRequestAsync(string cedula)
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/PedidoDetalles/";
                string api = "GetProductByUserID";
                using (HttpClient client = new HttpClient())
                {
                    String jsonString = @"{



                          ""cedula"": """ + cedula + @""",
                          ""productId"": ""string"",
                          ""cantidad"": 0,
                          ""precioIndividual"": 0,
                          ""precio"": 0

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

        public async Task<String> CreatePedidoRequestAsync(PedidoDetalle pedido)
        {
            String result = string.Empty;
           

            try
            {
                string url = "https://localhost:7066/PedidoDetalles/";
                string api = "CreatePedido";
                using (HttpClient client = new HttpClient())
                {

                   
                    //.Replace(",", ".")
                    String jsonString = @"{

                          ""cedula"": """ + pedido.Cedula + @""",
                          ""productId"": """ + pedido.ProductId + @""",
                          ""cantidad"": " + pedido.Cantidad + @",
                          ""precioIndividual"": """ + pedido.PrecioIndividual.ToString().Replace(',', '.') + @"""

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

        public async Task<String> CreatePedidosListRequestAsync(string[] list,string userId)
        {
            String result = string.Empty;

            foreach (string item in list) 
            {
                result = string.Empty;

                try
                {
                    string url = "https://localhost:7066/PedidoDetalles/";
                    string api = "CreatePedido";
                    using (HttpClient client = new HttpClient())
                    {
                        
                        ProductApi pa = new ProductApi();
                        string r = "";
                        r = await pa.GetProductByIdRequestAsync(Int32.Parse(item));
                        List<Product> oUsers = new List<Product>();
                        oUsers = (List<Product>)JsonConvert.DeserializeObject(r, typeof(List<Product>));

                        String jsonString = @"{

                          ""cedula"": """ + userId + @""",
                          ""productId"": """ + item + @""",
                          ""cantidad"": ""1"",
                          ""precioIndividual"": """ + oUsers[0].Precio + @"""

                        }";
                        StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                        client.BaseAddress = new Uri(url);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var response = await client.PostAsync(api, content);
                        result= response.Content.ReadAsStringAsync().Result;

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
            return result;

        }


        public async Task<String> DeleteProductRequestAsync(string cedula, string productId)
        //
        {
            String result=string.Empty;


            try
            {
                string url = "https://localhost:7066/PedidoDetalles/DeleteProduct";
                string api = "DeleteProduct";
                using (HttpClient client = new HttpClient())

                {
                    String jsonString = @"{

                          
                          ""cedula"": """ + cedula + @""",
                          ""productId"": """+ productId+@""",
                          ""cantidad"": 0,
                          ""precioIndividual"": 0,
                          ""precio"": 0

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
