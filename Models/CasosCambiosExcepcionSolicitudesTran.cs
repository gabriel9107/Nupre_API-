using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosCambiosExcepcionSolicitudesTran
{
    public int CambioExcepcionSolicitudNumero { get; set; }

    public int CasoNumero { get; set; }

    public byte CambioExcepcionSolicitudEstadoNumero { get; set; }

    public byte CambioExcepcionMotivoSecuencia { get; set; }

    public byte CambioExcepcionMotivoUnipagoNumero { get; set; }

    public string AfiliadoTipoCodigo { get; set; } = null!;

    public long AfiliadoNss { get; set; }

    public string AfiliadoCedula { get; set; } = null!;

    public string AfiliadoNombres { get; set; } = null!;

    public DateTime AfiliadoNacimientoFecha { get; set; }

    public string AfiliadoSexo { get; set; } = null!;

    public byte ArsOrigenNumero { get; set; }

    public byte ArsDestinoNumero { get; set; }

    public long AfiliadoTitularNuevoNss { get; set; }

    public string AfiliadoTitularNuevoCedula { get; set; } = null!;

    public byte AfiliadoParentescoNumero { get; set; }

    public byte AfiliadoTipoAfiliarseNumero { get; set; }

    public string AfiliadoEstudiante { get; set; } = null!;

    public string AfiliadoDiscapacitado { get; set; } = null!;

    public string CambioExcepcionSolicitudCreadoUsuario { get; set; } = null!;

    public DateTime CambioExcepcionSolicitudCreadoFecha { get; set; }

    public string CambioExcepcionSolicitudAprobadoUsuario { get; set; } = null!;

    public DateTime CambioExcepcionSolicitudAprobadoFecha { get; set; }

    public string CambioExcepcionSolicitudAutorizadoUsuario { get; set; } = null!;

    public DateTime CambioExcepcionSolicitudAutorizadoFecha { get; set; }

    public string CambioExcepcionSolicitudRechazadoUsuario { get; set; } = null!;

    public DateTime CambioExcepcionSolicitudRechazadoFecha { get; set; }

    public string CambioExcepcionSolicitudRechazadoComentario { get; set; } = null!;

    public int SeguimientoNumero { get; set; }

    public string SeguimientoRespuestaEstatus { get; set; } = null!;

    public string SeguimientoRespuesta { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual CasosCambiosExcepcionMotivosCatum CambioExcepcionMotivo { get; set; } = null!;

    public virtual CasosCambiosExcepcionSolicitudesEstadosCatum CambioExcepcionSolicitudEstadoNumeroNavigation { get; set; } = null!;

    public virtual CasosMaster CasoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<CasosCambiosExcepcionSolicitudesErroresTran> CasosCambiosExcepcionSolicitudesErroresTrans { get; set; } = new List<CasosCambiosExcepcionSolicitudesErroresTran>();
}
