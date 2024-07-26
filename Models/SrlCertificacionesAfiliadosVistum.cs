using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SrlCertificacionesAfiliadosVistum
{
    public long CiudadanoNss { get; set; }

    public byte CertificacionNumero { get; set; }

    public string CiudadanoNoDocumento { get; set; } = null!;

    public string CiudadanoNombreCompleto { get; set; } = null!;

    public DateTime CertificacionFecha { get; set; }

    public string CertificacionEstadoDescripcion { get; set; } = null!;

    public decimal PorcientoDiscapacidadCertificada { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
