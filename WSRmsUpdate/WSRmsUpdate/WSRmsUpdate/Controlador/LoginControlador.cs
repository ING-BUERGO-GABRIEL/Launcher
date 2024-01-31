using Microsoft.AspNetCore.Mvc;
using WSRmsUpdate.Interfaces;
using WSRmsUpdate.Modelo;
using WSRmsUpdate.Modelo.DataBase;
using WSRmsUpdate.Seguridad;

namespace WSRmsUpdate.Controlador
{
    [Route("api/login")]
    [ApiController]
    public class LoginControlador : ControllerBase
    {

        private readonly ILoginService _loginService;

        public LoginControlador(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        [Route("conexion")]
        public async Task<IActionResult> Conexion()
        {
            return await Task.Run(() => Ok(true));
        }

        [HttpPost]
        [Route("autenticar")]
        public async Task<IActionResult> Autenticar(LoginModelo Mlogin)
        {
            if (Mlogin == null)
            {
                return  BadRequest();
            }

            try
            {
                string token = await _loginService.ValidarUsuario(Mlogin);
                if (token != "")
                {
                    return Ok(token);
                }
                else
                {
                    return Unauthorized();
                }
            }
            catch
            {
                return Unauthorized();
            }
        }

    }
}
