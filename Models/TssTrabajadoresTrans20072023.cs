using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssTrabajadoresTrans20072023
{
    public int EmpleadorRegistroPatronal { get; set; }

    public long TrabajadorNss { get; set; }

    public DateTime TrabajadorFechaRegistroTss { get; set; }

    public DateTime TrabajadorFechaActualizacionTss { get; set; }

    public string TrabajadorEstatus { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
