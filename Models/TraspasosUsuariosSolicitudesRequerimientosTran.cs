using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosUsuariosSolicitudesRequerimientosTran
{
    public int SolicitudNumero { get; set; }

    public byte RequerimientoNumero { get; set; }

    public string DocumentoCodigo { get; set; } = null!;

    public byte RequerimientoEstadoNumero { get; set; }

    public DateTime RequerimientoEstadoFecha { get; set; }

    public string RequerimientoEstadoNota { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual TraspasosUsuariosSolicitudesTran SolicitudNumeroNavigation { get; set; } = null!;
}
