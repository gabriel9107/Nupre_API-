using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SrlCertificacionesMaster
{
    public byte CertificacionNumero { get; set; }

    public DateTime CertificacionFecha { get; set; }

    public DateTime CertificacionUltimaNovedadFecha { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<SrlCertificacionesAfiliadosTran> SrlCertificacionesAfiliadosTrans { get; set; } = new List<SrlCertificacionesAfiliadosTran>();
}
