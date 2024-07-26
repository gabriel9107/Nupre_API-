using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosDireccionesViasTiemposTran
{
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
    /// Tiempo limite establecido para la vía de entrada del servicio.
    /// </summary>
    public byte CasoViaTiempoLimite { get; set; }

    /// <summary>
    /// Unidad de tiempo establecida para la vía de entrada del servicio.
    /// </summary>
    public byte CasoViaTiempoUnidadNumero { get; set; }

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

    public virtual CasosViasCatum CasoViaNumeroNavigation { get; set; } = null!;

    public virtual CasosViasTiemposUnidadesCatum CasoViaTiempoUnidadNumeroNavigation { get; set; } = null!;
}
