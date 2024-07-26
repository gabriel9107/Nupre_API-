using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNucufTran
{
    public long Nucuf { get; set; }

    public byte TraspasoTipoNumero { get; set; }

    public string TraspasoTipoFormulario { get; set; } = null!;

    public string AfiliadoTipoCodigo { get; set; } = null!;

    public long AfiliadoTitularNss { get; set; }

    public string AfiliadoTitularCedula { get; set; } = null!;

    public DateTime TraspasoSolicitudFecha { get; set; }

    public string TraspasoEfectividadFecha { get; set; } = null!;

    public string ArsOrigenNumero { get; set; } = null!;

    public byte ArsDestinoNumero { get; set; }

    public string RechazoMotivo { get; set; } = null!;

    public string NucufEstado { get; set; } = null!;

    public string RepresentanteCedula { get; set; } = null!;

    public string TraspasoTelefonos { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
