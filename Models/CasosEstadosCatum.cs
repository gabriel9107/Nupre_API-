using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosEstadosCatum
{
    /// <summary>
    /// Número que identifica el estado en el que se encuentra el caso.
    /// </summary>
    public byte CasoEstadoNumero { get; set; }

    /// <summary>
    /// Descripción del estado del caso.
    /// </summary>
    public string CasoEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del estado del caso.
    /// </summary>
    public string CasoEstadoExplicacion { get; set; } = null!;

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

    public virtual ICollection<CasosMaster> CasosMasters { get; set; } = new List<CasosMaster>();
}
