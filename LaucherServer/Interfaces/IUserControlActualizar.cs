using System;

namespace LauncherServer.Interfaces
{
    public interface IUserControlActualizar
    {
        event EventHandler BtnSiguienteClick;
        event EventHandler BtnAtrasClick;
        event EventHandler BtnGuardarClick;
        event EventHandler BtnCancelarClick;
        bool Validar();
    }
}
