using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArsReportesTiposCatum
{
    public byte ReporteTipoNumero { get; set; }

    public string ReporteTipoDescripcion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<ArsReportesMaster> ArsReportesMasters { get; set; } = new List<ArsReportesMaster>();
}
