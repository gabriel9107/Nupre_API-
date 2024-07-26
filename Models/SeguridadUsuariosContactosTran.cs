using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un tabla transaccional donde se registran los contactos de los usuarios registrados para el uso de los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadUsuariosContactosTran
{
    /// <summary>
    /// Numero del medio de contacto del usuario.
    /// </summary>
    public int UsuarioContactoNumero { get; set; }

    /// <summary>
    /// Nombre el usuario que origino la operación del evento que genero el registro log del sistema.
    /// </summary>
    public string UsuarioUsuarioNombre { get; set; } = null!;

    /// <summary>
    /// Tipo de medio del contacto registrado para el usuario.
    /// </summary>
    public string UsuarioContactoTipo { get; set; } = null!;

    /// <summary>
    /// Descripción del Tipo de medio del contacto registrado para el usuario.
    /// </summary>
    public string UsuarioContactoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Información de medio de contacto del usuario.
    /// </summary>
    public string UsuarioContactoDato { get; set; } = null!;

    /// <summary>
    /// Nota sobre el  medio de contacto del usuario.
    /// </summary>
    public string UsuarioContactoNota { get; set; } = null!;

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

    public virtual SeguridadUsuariosMaster UsuarioUsuarioNombreNavigation { get; set; } = null!;
}
