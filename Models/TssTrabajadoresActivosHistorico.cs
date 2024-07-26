using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssTrabajadoresActivosHistorico
{
    public int PeriodoFactura { get; set; }

    public int EmpleadorId { get; set; }

    public long TrabajadorId { get; set; }

    public string TrabajadorSexo { get; set; } = null!;

    public int TrabajadorFechaNacimiento { get; set; }

    public decimal TrabajadorSalarioSs { get; set; }

    public int TrabajadorFechaRegistroTss { get; set; }

    public int TrabajadorFechaActualizacionTss { get; set; }

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFecha { get; set; }
}
