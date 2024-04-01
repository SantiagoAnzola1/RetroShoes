using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WebAppV2.Models;

namespace WebAppV2.Repository
{
    public class ProductApi
    {
        public async Task<String> GetProductsRequestAsync()
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/Product/GetProductDB";
                string api = "GetProductDB";
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
                Console.WriteLine("ERROR PRODUCTS-API");
                
                result = String.Empty;
                Console.WriteLine(result);
            }
            if (result.Contains("HTTP ERROR 500"))
            {
                Console.WriteLine("ERROR PRODUCTS-API");
                return @"{""ErrorMsg"":""There was an error getting the products""";
            }
            return result;
        }

        //public async Task<String> GetProductByIdRequestAsync(string productId)
        //{
        //    String result = string.Empty;

        //    try
        //    {
        //        string url = "https://localhost:7066/Product/";
        //        string api = "GetProductById";
        //        using (HttpClient client = new HttpClient())
        //        {
        //            String jsonString = @"{



        //                  ""productName"": """",
        //                  ""productId"": """ + productId + @""",
        //                  ""stock"": ""0"",
        //                  ""precio"": ""0"",
        //                  ""categoria"": """",
        //                  ""imagen"": """",
        //                  ""marca"": """",
        //                  ""genero"": """"

        //             }";
        //            StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
        //            client.BaseAddress = new Uri(url);
        //            client.DefaultRequestHeaders.Clear();
        //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var response = await client.PostAsync(api, content);
        //            result = response.Content.ReadAsStringAsync().Result;

        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        String ex = e.Message.ToString();
        //        result = String.Empty;
        //    }
        //    if (result.Contains("HTTP ERROR 500"))
        //    {
        //        return @"{""ErrorMsg"":""There was an error getting the users""";
        //    }
        //    return result;
        //}

        public async Task<String> GetProductByIdRequestAsync(int productId)
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/Product/";
                string api = "GetProductById/{0}";
                using (HttpClient client = new HttpClient())
                {
                    String jsonString = "";
                    StringContent content = new StringContent(jsonString);
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(String.Format(api,productId));
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

        public async Task<String> CreateProductRequestAsync(Product product)
        {
            String result = string.Empty;
           

            try
            {
                string url = "https://localhost:7066/Product/";
                string api = "CreateProduct";
                using (HttpClient client = new HttpClient())
                {


                    //String jsonString = @"{

                    //      ""productName"": """ + product.ProductName + @""",
                    //      ""productId"": """ + product.ProductId + @""",
                    //      ""stock"": """ + product.Stock + @""",
                    //      ""precio"": """ + product.Precio + @""",
                    //      ""categoria"": """ + product.Categoria + @""",
                    //      ""imagen"": """ + product.Imagen + @""",
                    //      ""marca"": """ + product.Marca+ @""",
                    //      ""genero"": """ + product.Genero  + @"""

                    //    }";
                    string jsonString = JsonSerializer.Serialize(product);//nuevo

                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync(api, content);
                    //result = response.Content.ReadAsStringAsync().Result;
                    result = await response.Content.ReadAsStringAsync();

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
        public async Task<String> UpdateStockRequestAsync(ProductStock product)
        {
            String result = string.Empty;
           

            try
            {
                string url = "https://localhost:7066/Product/";
                string api = "UpdateStock";
                using (HttpClient client = new HttpClient())
                {

                    
                    //String jsonString = @"{

                    //      ""productName"": """",
                    //      ""productId"": """ + productid + @""",
                    //      ""stock"": """ + stock + @""",
                    //      ""precio"": ""0"",
                    //      ""categoria"": """",
                    //      ""imagen"": """",
                    //      ""marca"": """",
                    //      ""genero"": """"

                    //    }";
                    string jsonString = JsonSerializer.Serialize(product);//nuevo

                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsync(api, content);
                    //result = response.Content.ReadAsStringAsync().Result;
                    result = await response.Content.ReadAsStringAsync();

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
        public async Task<String> UpdateProdcutAsync(Product product)
        {
            String result = string.Empty;
           

            try
            {
                string url = "https://localhost:7066/Product/";
                string api = "UpdateProduct";
                using (HttpClient client = new HttpClient())
                {


                    //String jsonString = @"{

                    //      ""productName"": """ + product.ProductName + @""",
                    //      ""productId"": """ + product.ProductId + @""",
                    //      ""stock"": """ + product.Stock + @""",
                    //      ""precio"": """ + product.Precio + @""",
                    //      ""imagen"": """ + product.Imagen + @""",
                    //      ""marca"": """ + product.Marca + @""",
                    //      ""genero"": """ + product.Genero + @"""

                    //    }";

                    string jsonString = JsonSerializer.Serialize(product);//nuevo
                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PutAsync(api, content);
                    //result = response.Content.ReadAsStringAsync().Result;
                    result = await  response.Content.ReadAsStringAsync();
                  
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


        
        public async Task<String> DeleteProductRequestAsync(int productId)
        //
        {
            String result=string.Empty;


            try
            {
                string url = "https://localhost:7066/Product/";
                string api = "DeleteProduct/{0}";
                using (HttpClient client = new HttpClient())

                {
                    //String jsonString = @"{

                          
                    //      ""productName"": """",
                    //      ""productId"": """ + productId + @""",
                    //      ""stock"": ""0"",
                    //      ""precio"": ""0"",
                    //      ""categoria"": """",
                    //      ""imagen"": """",
                    //      ""marca"": """",
                    //      ""genero"": """"

                    //    }";
                   
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.DeleteAsync(String.Format(api, productId));
                    //result = response.Content.ReadAsStringAsync().Result;
                    result = await response.Content.ReadAsStringAsync();

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

        public async Task<String> GetProductByGeneroRequestAsync(string genero)
        {
            String result = string.Empty;


            try
            {
                string url = "https://localhost:7066/Product/";
                string api = "GetProductByGender/{0}";
                using (HttpClient client = new HttpClient())
                {


                    //String jsonString = @"{

                          
                    //      ""productName"": """",
                    //      ""productId"": ""0"",
                    //      ""stock"": ""0"",
                    //      ""precio"": ""0"",
                    //      ""categoria"": """",
                    //      ""imagen"": """",
                    //      ""marca"": """",
                    //      ""genero"": """ + genero + @"""

                    //    }";
                    //StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(String.Format(api, genero));
                    //result = response.Content.ReadAsStringAsync().Result;
                    result = await response.Content.ReadAsStringAsync();

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
        public async Task<String> GetProductByCategoryRequestAsync(string categoria)
        {
            String result = string.Empty;


            try
            {
                string url = "https://localhost:7066/Product/";
                string api = "GetProductByCategory/{0}";
                using (HttpClient client = new HttpClient())
                {


                    //String jsonString = @"{

                          
                    //      ""productName"": """",
                    //      ""productId"": ""0"",
                    //      ""stock"": ""0"",
                    //      ""precio"": ""0"",
                    //      ""categoria"": """ + categoria + @""",
                    //      ""imagen"": """",
                    //      ""marca"": """",
                    //      ""genero"": """"

                    //    }";
                    //StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(String.Format(api, categoria));
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

        public async Task<Int32> GetStockRequestAsync(int productId)
        {
            Int32 result = 0;


            try
            {
                string url = "https://localhost:7066/Product/";
                string api = "GetStockById/{0}";
                using (HttpClient client = new HttpClient())
                {


                    //String jsonString = @"{

                          
                    //      ""productName"": """",
                    //      ""productId"": """ + productId + @""",
                    //      ""stock"": ""0"",
                    //      ""precio"": ""0"",
                    //      ""categoria"": """",
                    //      ""imagen"": """",
                    //      ""marca"": """",
                    //      ""genero"": """"

                    //    }";
                    //StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(String.Format(api, productId));
                    result = Convert.ToInt32( response.Content.ReadAsStringAsync().Result);
                   
                }
            }
            catch (Exception e)
            {
                String ex = e.Message.ToString();
                result = 0;
            }
            
            return result;
        }
    }
    
}
