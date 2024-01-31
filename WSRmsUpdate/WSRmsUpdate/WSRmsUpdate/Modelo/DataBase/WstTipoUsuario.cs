using System;
using System.Collections.Generic;

namespace WSRmsUpdate.Modelo.DataBase;

public partial class WstTipoUsuario
{
    public string Codigo { get; set; } = null!;

    public string? TipoPrivilegios { get; set; }

    public virtual ICollection<WstUsuario> WstUsuarios { get; set; } = new List<WstUsuario>();
}
