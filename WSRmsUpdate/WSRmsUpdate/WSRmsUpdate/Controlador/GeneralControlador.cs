using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WSRmsUpdate.Modelo;

namespace WSRmsUpdate.Controlador
{
    [Route("api/usuario")]
    [ApiController]
    public class GeneralControlador : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("datos")]
        public IActionResult UsuarioActual()
        {
            UsuarioModelo user = new UsuarioModelo();

            var identity = HttpContext?.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClain = identity.Claims;
                user = new UsuarioModelo
                {
                    Nombre = userClain.FirstOrDefault(o => o.Type == ClaimTypes.Name)?.Value,
                    Correo = userClain.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value,
                    TipoUsuario = Convert.ToChar(userClain.FirstOrDefault(o => o.Type == ClaimTypes.Role)?.Value)
                };

            }

            return Ok(user);
        }

    }
}
