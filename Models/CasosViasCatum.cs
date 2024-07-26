using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosViasCatum
{
    /// <summary>
    /// Número que identifica la vía de entrada de la solicitud.
    /// </summary>
    public byte CasoViaNumero { get; set; }

    /// <summary>
    /// Descripción de la vía de entrada de la solicitud.
    /// </summary>
    public string CasoViaDescripcion { get; set; } = null!;

    /// <summary>
    /// Indicador de visibilidad de la vía.
    /// </summary>
    public bool CasoViaVisible { get; set; }

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
