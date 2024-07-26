using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNuctCeTran
{
    public int Nuct { get; set; }

    public byte TraspasoTipoNumero { get; set; }

    public DateTime TraspasoSolicitudFecha { get; set; }

    public DateTime? TraspasoEfectividadFecha { get; set; }

    public long AfiliadoTitularNss { get; set; }

    public string AfiliadoTitularCedula { get; set; } = null!;

    public int ArsDestino { get; set; }

    public int ArsOrigen { get; set; }

    public string TraspasoEstatus { get; set; } = null!;

    public string? MotivoNumero { get; set; }

    public string SangreTipoCodigo { get; set; } = null!;

    public string PreguntaClaveDescripcion { get; set; } = null!;

    public string RespuestaDescripcion { get; set; } = null!;

    public string TraspasoTelefonoEmpresa { get; set; } = null!;

    public string TraspasoTelefonoResidencia { get; set; } = null!;

    public string TraspasoTelefonoCelular { get; set; } = null!;

    public DateTime? FechaNotificacionArsOrigen { get; set; }

    public string TraspasoEmail { get; set; } = null!;

    public string RepresentanteCedula { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
