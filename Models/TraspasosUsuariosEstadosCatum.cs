using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosUsuariosEstadosCatum
{
    /// <summary>
    /// Código único que representa el estado de situación de la clave de usuario de PSS para la consulta de afiliados.
    /// </summary>
    public byte UsuarioEstadoNumero { get; set; }

    /// <summary>
    /// Descripción del código único que representa el estado de situación de la clave de usuario de PSS para la consulta de afiliados.
    /// </summary>
    public string UsuarioEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción del código único que representa el estado de situación de la clave de usuario de PSS para la consulta de afiliados.
    /// </summary>
    public string UsuarioEstadoExplicacion { get; set; } = null!;

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

    public virtual ICollection<TraspasosUsuariosMaster> TraspasosUsuariosMasters { get; set; } = new List<TraspasosUsuariosMaster>();
}
