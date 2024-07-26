using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssTrabajadoresTotalVistum
{
    public int EmpleadorRegistroPatronal { get; set; }

    public long TrabajadorNss { get; set; }

    public string TrabajadorEstatus { get; set; } = null!;

    public DateTime TrabajadorFechaRegistroTss { get; set; }

    public DateTime TrabajadorFechaActualizacionTss { get; set; }
}
