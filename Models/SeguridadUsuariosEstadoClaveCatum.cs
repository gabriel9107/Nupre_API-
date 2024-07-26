using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipo de estados en que puede estar una clave de usuario en cualquiera de los sistemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadUsuariosEstadoClaveCatum
{
    /// <summary>
    /// Código único que representa el estado de situación de la clave de usuario de PSS para la consulta de afiliados.
    /// </summary>
    public string EstadoClaveCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del código único que representa el estado de situación de la clave de usuario de PSS para la consulta de afiliados.
    /// </summary>
    public string EstadoClaveDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción del código único que representa el estado de situación de la clave de usuario de PSS para la consulta de afiliados.
    /// </summary>
    public string EstadoClaveExplicacion { get; set; } = null!;

    /// <summary>
    /// Es el estado del registro de la clave que debe asignarle en relación al Estado de la Clave.
    /// </summary>
    public string EstadoClaveRegistroEstado { get; set; } = null!;

    /// <summary>
    /// Número  único que representa la novedad sobre el registro de usuarios.
    /// </summary>
    public byte TipoNovedadNumero { get; set; }

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

    public virtual ICollection<SeguridadUsuariosMaster> SeguridadUsuariosMasters { get; set; } = new List<SeguridadUsuariosMaster>();

    public virtual SeguridadUsuariosNovedadTipoCatum TipoNovedadNumeroNavigation { get; set; } = null!;
}
