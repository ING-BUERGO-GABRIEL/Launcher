using System;
using System.Collections.Generic;

namespace WSRmsUpdate.Modelo.DataBase;

public partial class WstEstadoUsusario
{
    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<WstUsuario> WstUsuarios { get; set; } = new List<WstUsuario>();
}
