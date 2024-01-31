using WSRmsUpdate.Modelo.DataBase;

namespace WSRmsUpdate.Interfaces
{
    public interface IUsuariosService
    {
        Task<IEnumerable<WstTipoUsuario>> ObtenerTipoUsuarios();
        Task<IEnumerable<WsvListaUsuario>> ObtenerUsuarios();
    }
}
