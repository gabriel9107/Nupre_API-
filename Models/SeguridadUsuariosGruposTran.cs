using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un tabla transaccional de los grupos de acceso y su relación con los usuarios que están incluidos en ellos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadUsuariosGruposTran
{
    /// <summary>
    /// Nombre de usuario de la persona registrado como usuario en el sistema.
    /// </summary>
    public string UsuarioUsuarioNombre { get; set; } = null!;

    /// <summary>
    /// Número único del grupo de seguridad al que pertenecen los usuarios de los sistemas de información.
    /// </summary>
    public byte GrupoSeguridadNumero { get; set; }

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

    public virtual SeguridadGruposCatum GrupoSeguridadNumeroNavigation { get; set; } = null!;

    public virtual SeguridadUsuariosMaster UsuarioUsuarioNombreNavigation { get; set; } = null!;
}
