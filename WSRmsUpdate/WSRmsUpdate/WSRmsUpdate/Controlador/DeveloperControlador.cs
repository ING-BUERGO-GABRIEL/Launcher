using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WSRmsUpdate.Controlador
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperControlador : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles =("D"))]
        public IActionResult Get()
        {
            return Ok("Funca");
        }
    }
}
