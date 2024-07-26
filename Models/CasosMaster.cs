using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosMaster
{
    /// <summary>
    /// Número que identifica el caso generado mediante una solicitud ante una queja o reclamo por parte de los ciudadanos.
    /// </summary>
    public int CasoNumero { get; set; }

    /// <summary>
    /// Número de identifica el tipo de servicio, el cual puede ser un Servicio o un Caso.
    /// </summary>
    public byte CasoTipoNumero { get; set; }

    /// <summary>
    /// Número que identifica el estado en el que se encuentra el caso.
    /// </summary>
    public byte CasoEstadoNumero { get; set; }

    /// <summary>
    /// Fecha de registro del caso o solicitud.
    /// </summary>
    public DateTime CasoFecha { get; set; }

    /// <summary>
    /// Número que identifica la dirección (Uadministrativa), solo para casos.
    /// </summary>
    public byte CasoDireccionNumero { get; set; }

    /// <summary>
    /// Número que identifica la vía de recepción de la información para la gestión del caso.
    /// </summary>
    public byte CasoViaNumero { get; set; }

    /// <summary>
    /// Frecuencia de tiempo con la que se mide la vía de entrada de un documento.
    /// </summary>
    public int CasoViaTiempoSecuencia { get; set; }

    /// <summary>
    /// Descripción de la motivación de solicitud para la gestión del caso o servicio.
    /// </summary>
    public string CasoMotivacionDescripcion { get; set; } = null!;

    /// <summary>
    /// Número que indica el motivo para la gestión de un caso o servicio.
    /// </summary>
    public short CasoMotivoNumero { get; set; }

    /// <summary>
    /// Conclusión del caso o servicio brindado.
    /// </summary>
    public string CasoConclusionDescripcion { get; set; } = null!;

    /// <summary>
    /// Fecha de conclsión del caso o servicio.
    /// </summary>
    public DateTime CasoConclusionFecha { get; set; }

    /// <summary>
    /// Usuario que concluyó el caso o servicio.
    /// </summary>
    public string CasoConclusionUsuario { get; set; } = null!;

    /// <summary>
    /// Número que indica el origen del caso o servicio.
    /// </summary>
    public byte CasoOrigenNumero { get; set; }

    /// <summary>
    /// A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual CasosDireccionesMaster CasoDireccionNumeroNavigation { get; set; } = null!;

    public virtual CasosEstadosCatum CasoEstadoNumeroNavigation { get; set; } = null!;

    public virtual CasosOrigenesCatum CasoOrigenNumeroNavigation { get; set; } = null!;

    public virtual CasosTiposCatum CasoTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<CasosActividadesTran> CasosActividadesTrans { get; set; } = new List<CasosActividadesTran>();

    public virtual ICollection<CasosCambiosExcepcionSolicitudesTran> CasosCambiosExcepcionSolicitudesTrans { get; set; } = new List<CasosCambiosExcepcionSolicitudesTran>();

    public virtual ICollection<CasosDocumentosTran> CasosDocumentosTrans { get; set; } = new List<CasosDocumentosTran>();

    public virtual ICollection<CasosRelacionadosTran> CasosRelacionadosTrans { get; set; } = new List<CasosRelacionadosTran>();
}
