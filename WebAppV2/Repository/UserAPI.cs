using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using WebAppV2.Models;

namespace WebAppV2.Repository
{
    public class UserAPI
    {
        public async Task<String> GetUsersRequestAsync()
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/User/GetUsersDB";
                string api = "GetUsersDB";
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

        //public async Task<String> GetUsersByIdRequestAsync(string userId)
        //{
        //    String result = string.Empty;

        //    try
        //    {
        //        string url = "https://localhost:7066/User/";
        //        string api = "GetUserById";
        //        using (HttpClient client = new HttpClient())
        //        {
        //            String jsonString = @"{

        //                  ""userName"": """",
        //                  ""email"": """",
        //                  ""password"": """",
        //                  ""cedula"": """ + userId + @"""

        //                }";
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
        public async Task<String> GetUsersByIdRequestAsync(long cedula)
        {
            String result = string.Empty;

            try
            {
                string url = "https://localhost:7066/User/";
                string api = "GetUserById/{0}";
                using (HttpClient client = new HttpClient())
                {
                    //String jsonString = @"{

                    //      ""userName"": """",
                    //      ""email"": """",
                    //      ""password"": """",
                    //      ""cedula"": """ + userId + @"""

                    //    }";
                    //StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(String.Format(api, cedula));
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

        public async Task<String> CreateUserRequestAsync(User user)
            //
        {
            String result = string.Empty;
           

            try
            {
                string url = "https://localhost:7066/User/";
                string api = "CreateUser";
                using (HttpClient client = new HttpClient())
                {

                    
                    //String jsonString =   @"{

                    //      ""userName"": """ + UserName + @""",
                    //      ""email"": """ + Email + @""",
                    //      ""password"": """ + Password + @""",
                    //      ""cedula"": """ + Cedula + @"""

                    //    }";
                    string jsonString = JsonSerializer.Serialize(user);//nuevo
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


        
        public async Task<String> DeleteUserRequestAsync(long cedula)
        //
        {
            String result=string.Empty;


            try
            {
                string url = "https://localhost:7066/User/";
                string api = "DeleteUser/{0}";
                using (HttpClient client = new HttpClient())

                {
                    //String jsonString = @"{

                          
                    //      ""cedula"": """ + Cedula + @"""

                    //    }";
                    //StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.DeleteAsync(String.Format(api, cedula));
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

        public async Task<String> IsRegisterRequestAsync(long cedula)
        //
        {
            String result = string.Empty;


            try
            {
                string url = "https://localhost:7066/User/";
                string api = "IsRegister/{0}";
                using (HttpClient client = new HttpClient())
                {


                    //String jsonString = @"{

                          
                    //      ""cedula"": """ + Cedula + @"""

                    //    }";
                    //StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.GetAsync(String.Format(api, cedula));
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

        public async Task<String> IsLoggedRequestAsync(UserLog user)
        //
        {
            String result = string.Empty;


            try
            {
                string url = "https://localhost:7066/User/";
                string api = "IsLogged";
                using (HttpClient client = new HttpClient())
                {

                    //String jsonString = @"{
                    //      ""cedula"": """ + user.Cedula + @""",
                    //      ""password"": """ + user.Password + @"""

                    //    }";
                    string jsonString = JsonSerializer.Serialize(user);//nuevo
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
    }
}
