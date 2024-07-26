using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles del Origen relacionado con los Accidentes de Transito no laborales), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AccidentesOrigenesCatum
{
    /// <summary>
    /// Número que identifica el origen del accidente.
    /// </summary>
    public byte OrigenNumero { get; set; }

    /// <summary>
    /// Descripción del origen del accidente.
    /// </summary>
    public string OrigenDescripcion { get; set; } = null!;

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<AccidentesTransitoArsTran> AccidentesTransitoArsTrans { get; set; } = new List<AccidentesTransitoArsTran>();
}
