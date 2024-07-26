using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosTiposCatum
{
    /// <summary>
    /// Número que identifica el tipo de servicio ante una queja o reclamo.
    /// </summary>
    public byte CasoTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de servicio ante una queja o reclamo.
    /// </summary>
    public string CasoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del tipo de servicio ante una queja o reclamo.
    /// </summary>
    public string CasoTipoExplicacion { get; set; } = null!;

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
