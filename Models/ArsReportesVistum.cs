using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArsReportesVistum
{
    public byte ArsNumero { get; set; }

    public string ArsNombre { get; set; } = null!;

    public byte ReporteNumero { get; set; }

    public string ReporteTitulo { get; set; } = null!;

    public byte EsquemaNumero { get; set; }

    public string EsquemaDescripcion { get; set; } = null!;

    public byte ReporteTemaNumero { get; set; }

    public string ReporteTemaDescripcion { get; set; } = null!;

    public int SeguimientoPeriodo { get; set; }

    public string SeguimientoPeriodoFormateado { get; set; } = null!;

    public string ReporteDetalle { get; set; } = null!;

    public string ReporteGeneradoResultado { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
