using System;
using System.Collections.Generic;

namespace WSRmsUpdate.Modelo.DataBase;

public partial class WstUsuario
{
    public int NumSec { get; set; }

    public string UsrCreacion { get; set; } = null!;

    public DateTime FchaCreacion { get; set; }

    public string UsrModif { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Elim { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string CodTipoUsuario { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string CodEstado { get; set; } = null!;

    public virtual WstEstadoUsusario CodEstadoNavigation { get; set; } = null!;

    public virtual WstTipoUsuario CodTipoUsuarioNavigation { get; set; } = null!;
}
