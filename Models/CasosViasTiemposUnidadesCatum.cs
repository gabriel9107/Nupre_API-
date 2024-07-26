using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosViasTiemposUnidadesCatum
{
    /// <summary>
    /// Unidad de tiempo establecida para la vía de entrada del servicio.
    /// </summary>
    public byte CasoViaTiempoUnidadNumero { get; set; }

    /// <summary>
    /// Descripción de la unidad de tiempo.
    /// </summary>
    public string CasoViaTiempoUnidadDescripcion { get; set; } = null!;

    /// <summary>
    /// Cantidad de minutos establecidos por unidad de tiempo.
    /// </summary>
    public int? CasoViaTiempoUnidadMinutos { get; set; }

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

    public virtual ICollection<CasosDireccionesViasTiemposTran> CasosDireccionesViasTiemposTrans { get; set; } = new List<CasosDireccionesViasTiemposTran>();
}
