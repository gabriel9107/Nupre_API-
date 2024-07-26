using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosMasterVistum
{
    public int Nuct { get; set; }

    public DateTime TraspasoSolicitudFecha { get; set; }

    public long AfiliadoTitularNss { get; set; }

    public string AfiliadoTitularCedula { get; set; } = null!;

    public string AfiliadoTitularNombreCompleto { get; set; } = null!;

    public byte ArsOrigenNumero { get; set; }

    public string ArsOrigenNombre { get; set; } = null!;

    public byte ArsDestinoNumero { get; set; }

    public string ArsDestinoNombre { get; set; } = null!;

    public byte NuctEstadoNumero { get; set; }

    public string NuctEstadoComentario { get; set; } = null!;

    public byte AccionNumero { get; set; }

    public string AccionDescripcion { get; set; } = null!;

    public byte RespuestaNumero { get; set; }

    public string RespuestaDescripcion { get; set; } = null!;

    public string MotivoDescripcion { get; set; } = null!;
}
