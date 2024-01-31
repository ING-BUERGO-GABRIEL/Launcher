using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RmsUpdateApiNet.Http;
using RmsUpdateApiNet.Modelo;
using System.Text;

namespace RmsUpdateApiNet
{
    public class RmsUpdateApiNetClient : IRmsUpdateApiNetClient
    {
        public string Username { get; }
        public string Password { get; }
        public string Token { get; set; } = string.Empty;
        public string BaseUrl { get; }
        public RmsUpdateHttpClient HttpClient { get; }
        public RmsUpdateApiNetClient(string username, string password ,string host= "localhost:44368") 
        {
            Username = username;
            Password = password;
                   
            HttpClient = new RmsUpdateHttpClient(username, password);
            BaseUrl = host;

            _ = Autenticar(HttpClient.LoginModelo);
        }

        public static Uri ApiEndPoint(string host)
        {
            return new Uri($"https://{host}/api");
        }

        private async Task Autenticar(LoginModelo loginModelo)
        {
            var cliente = new HttpClient();
            cliente.BaseAddress = ApiEndPoint(BaseUrl);

            var content = new StringContent(JsonConvert.SerializeObject(loginModelo), Encoding.UTF8, "application/json");
            var response = await cliente.PostAsync("autenticar", content);
            var json_respuesta = await response.Content.ReadAsStringAsync();

            var resultado = JsonConvert.DeserializeObject<ResultadoCredencial>(json_respuesta);

            if (resultado != null)
            {
                Token = resultado.token;
            }
        }
    }
}