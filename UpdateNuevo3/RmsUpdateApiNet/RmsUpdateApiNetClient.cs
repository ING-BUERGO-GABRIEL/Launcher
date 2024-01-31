using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RmsUpdateApiNet.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RmsUpdateApiNet
{
    public class RmsUpdateApiNetClient
    {
        public string Token { get; set; } = string.Empty;
        public string MsjDialog { get; set; } = string.Empty;
        public string BaseUrl { get; }

        private ModeloLogin Mlogin = new ModeloLogin();

        private ModeloDatosUsuario MUsuario = new ModeloDatosUsuario();

        public RmsUpdateApiNetClient(string username, string password, string host = "localhost:44368")
        {
            Mlogin.Usuario = username;
            Mlogin.Password = password;
            BaseUrl = host;
        }

        public async Task<bool> Autenticar()
        {
            try
            {
                using (var cliente = new HttpClient())
                {
                    cliente.BaseAddress = new Uri($"{BaseUrl}/api/");

                    var content = new StringContent(JsonConvert.SerializeObject(Mlogin), Encoding.UTF8, "application/json");
                    var response = await cliente.PostAsync("login/autenticar", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var json_respuesta = await response.Content.ReadAsStringAsync();

                        if (json_respuesta != "")
                        {
                            Token = json_respuesta;
                            MsjDialog = "Inicio de sesion correcto";
                            return true;
                        }
                        else
                        {
                            MsjDialog = "Usuario o Contraseña incorrecto";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MsjDialog = ("Error en la autenticación: " + ex.Message);
            }

            return false;
        }

        public async Task<ModeloDatosUsuario> DatoUsuario()
        {
            try
            {
                if (MUsuario == null)
                {
                    using (var cliente = new HttpClient())
                    {
                        cliente.BaseAddress = new Uri($"{BaseUrl}/api/");

                        cliente.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

                        var response = await cliente.GetAsync("usuario/datos");

                        if (response.IsSuccessStatusCode)
                        {
                            var jsonRespuesta = await response.Content.ReadAsStringAsync();
                            dynamic result = JsonConvert.DeserializeObject(jsonRespuesta);

                            MUsuario = new ModeloDatosUsuario()
                            {
                                Nombre = result.Nombre,
                                Correo = result.Correo,
                                TipoUsuario = result.TipoUsuario
                            };
                            return MUsuario;
                        }
                    }
                }
                else
                {
                    return MUsuario;
                }
            }
            catch (Exception ex)
            {
                MsjDialog = ("Error en la autenticación: " + ex.Message);
            }
            return null;
        }

        public async Task<List<ModeloUsuario>> ListaUsuarios()
        {
            List<ModeloUsuario> ListUsuario = new List<ModeloUsuario>();
            try
            {
                using (var cliente = new HttpClient())
                {
                    cliente.BaseAddress = new Uri($"{BaseUrl}/api/");

                    cliente.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

                    var response = await cliente.GetAsync("admin/lista/user");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonRespuesta = await response.Content.ReadAsStringAsync();
                        ListUsuario = JsonConvert.DeserializeObject<List<ModeloUsuario>>(jsonRespuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                MsjDialog = ("Error en la autenticación: " + ex.Message);
            }
            return ListUsuario;
        }

        public async Task<List<ModeloTipoUsuario>> ListaTipoPrivilegios()
        {
            List<ModeloTipoUsuario> ListTipoUsuario = new List<ModeloTipoUsuario>();
            try
            {
                using (var cliente = new HttpClient())
                {
                    cliente.BaseAddress = new Uri($"{BaseUrl}/api/");

                    cliente.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

                    var response = await cliente.GetAsync("admin/lista/tipoprivilegio");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonRespuesta = await response.Content.ReadAsStringAsync();
                        ListTipoUsuario = JsonConvert.DeserializeObject<List<ModeloTipoUsuario>>(jsonRespuesta);
                    }
                }
            }
            catch (Exception ex)
            {
                MsjDialog = ("Error en la autenticación: " + ex.Message);
            }
            return ListTipoUsuario;
        }
    }
}
