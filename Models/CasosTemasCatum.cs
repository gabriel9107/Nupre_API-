using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosTemasCatum
{
    /// <summary>
    /// Número que identifica el tema de interes por el cual el afiliado o ciudadano refiere o reclama.
    /// </summary>
    public byte CasoTemaNumero { get; set; }

    /// <summary>
    /// Descripción del tema de interes por el cual el afiliado o ciudadano refiere o reclama.
    /// </summary>
    public string CasoTemaDescripcion { get; set; } = null!;

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

    public virtual ICollection<CasosMotivosCatum> CasosMotivosCata { get; set; } = new List<CasosMotivosCatum>();
}
