using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WSRmsUpdate.Interfaces;

namespace WSRmsUpdate.Controlador
{
    [Authorize(Roles = "A")]
    [Route("api/admin")]
    [ApiController]
    public class AdminControlador : ControllerBase
    {

        private readonly IUsuariosService _usuariosService;

        public AdminControlador(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpGet]
        [Route("lista/user")]
        public async Task<IActionResult> ListaUserAsync()
        {
            var usuarios = await _usuariosService.ObtenerUsuarios();
            return Ok(usuarios);
        }

        [HttpGet]
        [Route("lista/tipoprivilegio")]
        public async Task<IActionResult> ListaTipoPrivilegios()
        {
            var privilegios = await _usuariosService.ObtenerTipoUsuarios();
            return Ok(privilegios);
        }
    }
}
