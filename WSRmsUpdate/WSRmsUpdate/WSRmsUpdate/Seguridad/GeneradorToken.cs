using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WSRmsUpdate.Modelo;
using WSRmsUpdate.Modelo.DataBase;


namespace WSRmsUpdate.Seguridad
{
    internal static class GeneradorToken
    {

        public static string GenerateTokenJwt(WstUsuario usuario)
        {
            //string jwtKey = Configuraciones.ObtenerValor("Jwt:Key");

            var seguridadKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuraciones.ObtenerValor("Jwt:Key")));
            var credenciales = new SigningCredentials(seguridadKey, SecurityAlgorithms.HmacSha256);
            // create a claimsIdentity 
            var claimsIdentity = new[]
            {
                new Claim(ClaimTypes.Name, usuario.Nombre),
                new Claim(ClaimTypes.Email, usuario.Correo),
                new Claim(ClaimTypes.Role, usuario.CodTipoUsuario)
            };

            var token = new JwtSecurityToken(
               Configuraciones.ObtenerValor("Jwt:Issuer"),
               Configuraciones.ObtenerValor("Jwt:Audience"),
               claimsIdentity,
               expires: DateTime.Now.AddMinutes(Convert.ToInt32(Configuraciones.ObtenerValor("Jwt:MinutosToken"))),
               signingCredentials: credenciales
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
