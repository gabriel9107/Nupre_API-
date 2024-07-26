using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosMasterDuver
{
    public int Nuct { get; set; }

    public byte NuctEstadoNumero { get; set; }

    public byte TraspasoTipoNumero { get; set; }

    public byte TraspasoVencimientoTipoNumero { get; set; }

    public DateTime TraspasoSolicitudFecha { get; set; }

    public DateTime? TraspasoEfectividadFecha { get; set; }

    public long AfiliadoTitularNss { get; set; }

    public string AfiliadoTitularCedula { get; set; } = null!;

    public string AfiliadoTitularNombreCompleto { get; set; } = null!;

    public byte ArsDestino { get; set; }

    public byte ArsOrigen { get; set; }

    public string TraspasoEstatus { get; set; } = null!;

    public string ImagenNombre { get; set; } = null!;

    public string ImagenEncontrada { get; set; } = null!;

    public string ImagenRuta { get; set; } = null!;

    public string TraspasoObservacion { get; set; } = null!;

    public byte AccionNumero { get; set; }

    public byte RespuestaNumero { get; set; }

    public DateTime? TraspasoNotificacionArsOrigenFecha { get; set; }

    public DateTime? TraspasoVencimientoReporteProblemaImagenFecha { get; set; }

    public DateTime? TraspasoVencimientoReporteCondicionEnfermedadFecha { get; set; }

    public byte? SansionNumero { get; set; }

    public int CasoNumero { get; set; }

    public string TraspasoTelefonoEmpresa { get; set; } = null!;

    public string TraspasoTelefonoResidencia { get; set; } = null!;

    public string TraspasoTelefonoCelular { get; set; } = null!;

    public string TraspasoEmail { get; set; } = null!;

    public string RepresentanteCedula { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public string TraspasoTelefonos { get; set; } = null!;
}
