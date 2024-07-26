using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasMedicosSolicitudesEstadosCatum
{
    public byte SolicitudEstadoNumero { get; set; }

    public string SolicitudEstadoDescripcion { get; set; } = null!;

    public string SolicitudEstadoExplicacion { get; set; } = null!;

    public string SolicitudEstadoPendiente { get; set; } = null!;

    public string SolicitudEstadoNota { get; set; } = null!;

    public string SolicitudEstadoMensaje { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
