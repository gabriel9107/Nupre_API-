using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArsReportesTran
{
    public byte ArsNumero { get; set; }

    public byte ReporteNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public string ReporteDetalle { get; set; } = null!;

    public string ReporteGeneradoResultado { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual ArsReportesMaster ReporteNumeroNavigation { get; set; } = null!;
}
