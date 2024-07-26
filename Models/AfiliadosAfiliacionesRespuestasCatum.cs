using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de las repuestas de rechazo de una afiliación al SFS, su fuente de alimentación son las vistas estadísticas de UNIPAGO.
/// </summary>
public partial class AfiliadosAfiliacionesRespuestasCatum
{
    /// <summary>
    /// Código único que representa la respuesta que da UNIPAGO al procesar una afiliación, esta respuesta justifica el estado en el que queda la afiliación.
    /// </summary>
    public string AfiliacionesRespuestaCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripción de la respuesta que da UNIPAGO al procesar una afiliación, esta respuesta justifica el estado en el que queda la afiliación.
    /// </summary>
    public string AfiliacionesRespuestaDescripcion { get; set; } = null!;

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

    public virtual ICollection<AfiliadosSfsMaster> AfiliadosSfsMasters { get; set; } = new List<AfiliadosSfsMaster>();
}
