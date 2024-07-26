using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosCambiosExcepcionSolicitudesEstadosCatum
{
    public byte CambioExcepcionSolicitudEstadoNumero { get; set; }

    public string CambioExcepcionSolicitudEstadoDescripcion { get; set; } = null!;

    public string CambioExcepcionSolicitudEstadoExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<CasosCambiosExcepcionSolicitudesTran> CasosCambiosExcepcionSolicitudesTrans { get; set; } = new List<CasosCambiosExcepcionSolicitudesTran>();
}
