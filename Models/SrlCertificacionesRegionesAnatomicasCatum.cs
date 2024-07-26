using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SrlCertificacionesRegionesAnatomicasCatum
{
    public string RegionAnatomicaCodigo { get; set; } = null!;

    public string RegionAnatomicaDescripcion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<SrlCertificacionesAfiliadosTran> SrlCertificacionesAfiliadosTrans { get; set; } = new List<SrlCertificacionesAfiliadosTran>();
}
