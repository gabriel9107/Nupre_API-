using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArsReportesMaster
{
    public byte ReporteNumero { get; set; }

    public string ReporteTitulo { get; set; } = null!;

    public byte EsquemaNumero { get; set; }

    public byte ReporteTemaNumero { get; set; }

    public byte ReporteTipoNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<ArsReportesTran> ArsReportesTrans { get; set; } = new List<ArsReportesTran>();

    public virtual SeguimientosEsquemasCatum EsquemaNumeroNavigation { get; set; } = null!;

    public virtual ArsReportesTemasCatum ReporteTemaNumeroNavigation { get; set; } = null!;

    public virtual ArsReportesTiposCatum ReporteTipoNumeroNavigation { get; set; } = null!;
}
