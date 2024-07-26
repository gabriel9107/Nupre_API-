using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosUsuariosMotivosCatum
{
    /// <summary>
    /// Numero unico de indentificacion de motivos
    /// </summary>
    public byte MotivoNumero { get; set; }

    /// <summary>
    /// Descripcion de los motivos 
    /// </summary>
    public string MotivoDescripcion { get; set; } = null!;

    /// <summary>
    /// Mensaje de descripcion de motivo
    /// </summary>
    public string MotivoMensaje { get; set; } = null!;

    /// <summary>
    /// Motivo Rechazo S = si, N no
    /// </summary>
    public string MotivoRechazo { get; set; } = null!;

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

    public virtual ICollection<TraspasosUsuariosSolicitudesTran> TraspasosUsuariosSolicitudesTrans { get; set; } = new List<TraspasosUsuariosSolicitudesTran>();
}
