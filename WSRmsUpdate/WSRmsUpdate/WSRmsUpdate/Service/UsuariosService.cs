using WSRmsUpdate.Interfaces;
using WSRmsUpdate.Modelo;
using WSRmsUpdate.Modelo.DataBase;

namespace WSRmsUpdate.Service
{
    public  class UsuariosService : IUsuariosService
    {
        public async Task<IEnumerable<WstTipoUsuario>> ObtenerTipoUsuarios()
        {
            List<WstTipoUsuario> ListaTipoUser = new List<WstTipoUsuario>();
            using (WsrmsUpdateContext DB = new WsrmsUpdateContext())
            {
                ListaTipoUser = await Task.Run(() => DB.WstTipoUsuarios.ToList());
            }
            return ListaTipoUser;
        }

        public async Task<IEnumerable<WsvListaUsuario>> ObtenerUsuarios()
        {
            List<WsvListaUsuario> ListaUser = new List<WsvListaUsuario>();
            using (WsrmsUpdateContext DB = new WsrmsUpdateContext())
            {
                ListaUser = await Task.Run(() => DB.WsvListaUsuarios.ToList());
            }
            return ListaUser;
        }
    }
}
