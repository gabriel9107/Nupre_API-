using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SrlCertificacionesEstadosCatum
{
    public byte CertificacionEstadoNumero { get; set; }

    public string CertificacionEstadoDescripcion { get; set; } = null!;

    public string CertificacionEstadoExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<SrlCertificacionesAfiliadosTran> SrlCertificacionesAfiliadosTrans { get; set; } = new List<SrlCertificacionesAfiliadosTran>();
}
