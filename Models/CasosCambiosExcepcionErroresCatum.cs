using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosCambiosExcepcionErroresCatum
{
    public short CambioExcepcionSolicitudErrorNumero { get; set; }

    public string CambioExcepcionSolicitudErrorDescripcion { get; set; } = null!;

    public string CambioExcepcionSolicitudErrorExplicacion { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<CasosCambiosExcepcionSolicitudesErroresTran> CasosCambiosExcepcionSolicitudesErroresTrans { get; set; } = new List<CasosCambiosExcepcionSolicitudesErroresTran>();
}
