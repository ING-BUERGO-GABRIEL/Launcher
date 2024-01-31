using WSRmsUpdate.Modelo;

namespace WSRmsUpdate.Interfaces
{
    public interface ILoginService
    {
        Task<string> ValidarUsuario(LoginModelo MLogin);
    }
}
