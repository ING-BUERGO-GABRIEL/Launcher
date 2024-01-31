using System;
using System.Collections.Generic;

namespace WSRmsUpdate.Modelo.DataBase;

public partial class WsvListaUsuario
{
    public int NumSec { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string? TipoPrivilegios { get; set; }

    public string Estado { get; set; } = null!;
}
