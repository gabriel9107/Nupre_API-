using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosRelacionadosTipoCatum
{
    /// <summary>
    /// Número que identifica el tipo de relacionado de un caso.
    /// </summary>
    public byte CasoRelacionadoTipoNumero { get; set; }

    /// <summary>
    /// Número de orden del tipo de relacionado de un caso.
    /// </summary>
    public byte CasoRelacionadoTipoOrden { get; set; }

    /// <summary>
    /// Descripción del tipo de relacionado de un caso.
    /// </summary>
    public string CasoRelacionadoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del tipo de relacionado de un caso.
    /// </summary>
    public string CasoRelacionadoTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<CasosRelacionadosTran> CasosRelacionadosTrans { get; set; } = new List<CasosRelacionadosTran>();
}
