using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosMotivosCatum
{
    /// <summary>
    /// Número que indica el motivo para la gestión de un caso o servicio.
    /// </summary>
    public short CasoMotivoNumero { get; set; }

    /// <summary>
    /// Descripción del motivo por el cual se gestionará el caso o servicio.
    /// </summary>
    public string CasoMotivoDescripcion { get; set; } = null!;

    /// <summary>
    /// Número que indica el tema referente a la motivación del ciudadano.
    /// </summary>
    public byte CasoTemaNumero { get; set; }

    /// <summary>
    /// Número que identifica la dirección (Uadministrativa), solo para casos.
    /// </summary>
    public byte CasoDireccionNumero { get; set; }

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

    public virtual CasosTemasCatum CasoTemaNumeroNavigation { get; set; } = null!;
}
