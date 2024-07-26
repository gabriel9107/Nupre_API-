using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosCambiosExcepcionMotivosCatum
{
    public byte CambioExcepcionMotivoSecuencia { get; set; }

    public byte CambioExcepcionMotivoUnipagoNumero { get; set; }

    public string CambioExcepcionMotivoDescripcion { get; set; } = null!;

    public string CambioExcepcionMotivoAprobadoUnipago { get; set; } = null!;

    public string CambioExcepcionMotivoEstatus { get; set; } = null!;

    public string CambioExcepcionMotivoGeneraAlta { get; set; } = null!;

    public string CambioExcepcionMotivoGeneraBaja { get; set; } = null!;

    public string CambioExcepcionMotivoAfiliadoOrigenTipo { get; set; } = null!;

    public string CambioExcepcionMotivoAfiliadoDestinoTipo { get; set; } = null!;

    public string CambioExcepcionMotivoAfiliadoEstatus { get; set; } = null!;

    public string CambioExcepcionMotivoAfiliadoEstatusMotivo { get; set; } = null!;

    public byte CambioExcepcionMotivoGeneraMovimientoArs { get; set; }

    public byte CambioExcepcionMotivoRegimenOrigenNumero { get; set; }

    public byte CambioExcepcionMotivoRegimenDestinoNumero { get; set; }

    public byte CambioExcepcionMotivoParticipoTraspasoArs { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<CasosCambiosExcepcionSolicitudesTran> CasosCambiosExcepcionSolicitudesTrans { get; set; } = new List<CasosCambiosExcepcionSolicitudesTran>();
}
