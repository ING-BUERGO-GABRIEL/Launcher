using WSRmsUpdate.Interfaces;
using WSRmsUpdate.Modelo;
using WSRmsUpdate.Modelo.DataBase;
using WSRmsUpdate.Seguridad;

namespace WSRmsUpdate.Service
{
    public class LoginService : ILoginService
    {
        public async Task<string> ValidarUsuario(LoginModelo MLogin)
        {
            try
            {
                using (WsrmsUpdateContext DB = new WsrmsUpdateContext())
                {
                    var ususario = await Task.Run(() => DB.WstUsuarios.Where(x => x.Usuario == MLogin.Usuario && x.Password == MLogin.Password).Take(1).FirstOrDefault());
                    if (ususario != null)
                    {
                        return GeneradorToken.GenerateTokenJwt(ususario);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error al validar el usuario: {ex.Message}");
            }
            return "";
        }
    }
}

