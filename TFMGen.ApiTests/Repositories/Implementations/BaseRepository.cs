using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Implementations
{
    public class BaseRepository
    {
        public ResponseModel<T2> Login<T1, T2>(string URI, T1 model) where T1 : class where T2 : class
        {
            var qry = Api.Login(URI, model);
            var response = new ResponseModel<T2>();

            if (qry.Result.StatusCode == System.Net.HttpStatusCode.OK || qry.Result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                response.data = Newtonsoft.Json.JsonConvert.DeserializeObject<T2>(qry.Result.Content.ReadAsStringAsync().Result.ToString());
                response.error = false;
            }
            else
            {
                response.error = true;
            }

            return response;
        }

        public ResponseModel<T> Get<T>(string URI)
        {
            var repositoryUsuario = new UsuarioRepository();
            var token = repositoryUsuario.Login(new Models.DTO.UsuarioDTO { Email = "omm35@gcloud.ua.es", Password = "123456" }).data.Value.ToString();

            var qry = Api.Get(URI, token);
            var response = new ResponseModel<T>();

            if (qry.Result.StatusCode == System.Net.HttpStatusCode.OK || qry.Result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                var a = qry.Result.Content.ReadAsStringAsync().Result.ToString();
                response.data = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(qry.Result.Content.ReadAsStringAsync().Result.ToString());
                response.error = false;
            }
            else
            {
                response.error = true;
            }

            return response;
        }

        public ResponseModel<T2> Post<T1, T2>(string URI, T1 model) where T1 : class where T2 : class
        {
            var repositoryUsuario = new UsuarioRepository();
            var token = repositoryUsuario.Login(new Models.DTO.UsuarioDTO { Email = "omm35@gcloud.ua.es", Password = "123456" }).data.Value.ToString();

            var qry = Api.Post(URI, model, token);
            var response = new ResponseModel<T2>();

            if (qry.Result.StatusCode == System.Net.HttpStatusCode.OK || qry.Result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                response.data = Newtonsoft.Json.JsonConvert.DeserializeObject<T2>(qry.Result.Content.ReadAsStringAsync().Result.ToString());
                response.error = false;
            }
            else
            {
                response.error = true;
            }

            return response;
        }

        public ResponseModel<T2> Put<T1,T2>(string URI, T1 model) where T1 : class where T2 : class
        {
            var repositoryUsuario = new UsuarioRepository();
            var token = repositoryUsuario.Login(new Models.DTO.UsuarioDTO { Email = "omm35@gcloud.ua.es", Password = "123456" }).data.Value.ToString();

            var qry = Api.Put(URI, model, token);
            var response = new ResponseModel<T2>();

            if (qry.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                response.data = Newtonsoft.Json.JsonConvert.DeserializeObject<T2>(qry.Result.Content.ReadAsStringAsync().Result.ToString());
                response.error = false;
            }
            else
            {
                response.error = true;
            }

            return response;
        }

        public ResponseModel<T> Delete<T>(string URI)
        {
            var repositoryUsuario = new UsuarioRepository();
            var token = repositoryUsuario.Login(new Models.DTO.UsuarioDTO { Email = "omm35@gcloud.ua.es", Password = "123456" }).data.Value.ToString();

            var qry = Api.Delete(URI, token);
            var response = new ResponseModel<T>();

            if (qry.Result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                response.error = false;
            }
            else
            {
                response.error = true;
            }

            return response;
        }
    }
}
