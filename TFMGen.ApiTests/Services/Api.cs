using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net;
using TFMGen.ApiTests.Repositories.Implementations;

namespace TFMGen.ApiTests.Services
{
    public class Api
    {
        public static Task<HttpResponseMessage> Get(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string apiUrl = API_URIs.baseURI + url;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.Timeout = TimeSpan.FromSeconds(900);
                    var repositoryUsuario = new UsuarioRepository();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(repositoryUsuario.Login(new Models.DTO.UsuarioDTO { Email = "admin@pruebas.es", Password = "123456" }).data.ToString());
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.GetAsync(apiUrl);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Task<HttpResponseMessage> Post<T>(string url, T model) where T : class
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string apiUrl = API_URIs.baseURI + url;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.Timeout = TimeSpan.FromSeconds(900);
                    var repositoryUsuario = new UsuarioRepository();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(repositoryUsuario.Login(new Models.DTO.UsuarioDTO { Email = "admin@pruebas.es", Password = "123456" }).data.ToString());
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PostAsJsonAsync(apiUrl, model);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Task<HttpResponseMessage> Put<T>(string url, T model) where T : class
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string apiUrl = API_URIs.baseURI + url;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.Timeout = TimeSpan.FromSeconds(900);
                    var repositoryUsuario = new UsuarioRepository();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(repositoryUsuario.Login(new Models.DTO.UsuarioDTO { Email = "admin@pruebas.es", Password = "123456" }).data.ToString());
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PutAsJsonAsync(apiUrl, model);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static Task<HttpResponseMessage> Delete(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string apiUrl = API_URIs.baseURI + url;
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.Timeout = TimeSpan.FromSeconds(900);
                    var repositoryUsuario = new UsuarioRepository();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(repositoryUsuario.Login(new Models.DTO.UsuarioDTO { Email = "admin@pruebas.es", Password = "123456" }).data.ToString());
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.DeleteAsync(apiUrl);
                    response.Wait();
                    return response;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
