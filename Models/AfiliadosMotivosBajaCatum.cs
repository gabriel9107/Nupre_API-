using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los diferentes motivo por la cual se le da baja a la afiliación de un afiliado en  el SFS, su fuente de alimentación son las vistas estadísticas de UNIPAGO.
/// </summary>
public partial class AfiliadosMotivosBajaCatum
{
    /// <summary>
    /// Código único que representa el motivo que provoco la baja del afiliado.
    /// </summary>
    public string MotivoBajaCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del el motivo que provoco la baja del afiliado.
    /// </summary>
    public string MotivoBajaDescripcion { get; set; } = null!;

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

    public virtual ICollection<TraspasosUsuariosSolicitudesTran> TraspasosUsuariosSolicitudesTrans { get; set; } = new List<TraspasosUsuariosSolicitudesTran>();
}
