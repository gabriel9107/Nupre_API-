using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosCambiosExcepcionSolicitudesErroresTran
{
    public int CambioExcepcionSolicitudNumero { get; set; }

    public int SeguimientoNumero { get; set; }

    public short CambioExcepcionSolicitudErrorNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual CasosCambiosExcepcionErroresCatum CambioExcepcionSolicitudErrorNumeroNavigation { get; set; } = null!;

    public virtual CasosCambiosExcepcionSolicitudesTran CambioExcepcionSolicitudNumeroNavigation { get; set; } = null!;
}
