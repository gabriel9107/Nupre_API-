using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los estados en que pude estar un traspaso, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosEstadosCatum
{
    /// <summary>
    /// Número único de cada estado, relacionado con los diferentes procesos de investigación o notificación del SUIR, que pueden aplicar sobre  los traspasos.
    /// </summary>
    public byte NuctEstadoNumero { get; set; }

    /// <summary>
    /// Descripción de cada estado, relacionado con los diferentes procesos de investigación o notificación del SUIR, que pueden aplicar sobre  los traspasos.
    /// </summary>
    public string NuctEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción de cada estado, relacionado con los diferentes procesos de investigación o notificación del SUIR, que pueden aplicar sobre  los traspasos.
    /// </summary>
    public string NuctEstadoExplicacion { get; set; } = null!;

    /// <summary>
    /// Comentario para presentar a los usuarios en función de la descripción de cada estado, relacionado con los diferentes procesos de investigación o notificación del SUIR, que pueden aplicar sobre  los traspasos.
    /// </summary>
    public string NuctEstadoComentario { get; set; } = null!;

    public string NuctEstadoCambio { get; set; } = null!;

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

    public virtual ICollection<TraspasosMaster> TraspasosMasters { get; set; } = new List<TraspasosMaster>();
}
