using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro donde se registran los usuarios para el uso de los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguridadUsuariosMaster
{
    /// <summary>
    /// Nombre de usuario de la persona registrado como usuario en el sistema.
    /// </summary>
    public string UsuarioUsuarioNombre { get; set; } = null!;

    /// <summary>
    /// Número de la institución que es o a la que pertenece la ARS.
    /// </summary>
    public int InstitucionNumero { get; set; }

    public int EmpleadoNumero { get; set; }

    /// <summary>
    /// Clave de acceso del usuario.
    /// </summary>
    public string UsuarioClave { get; set; } = null!;

    /// <summary>
    /// Número  único que representa el estado de situación de la clave de usuario de PSS para la consulta de afiliados.
    /// </summary>
    public string EstadoClaveCodigo { get; set; } = null!;

    /// <summary>
    /// Fecha en que fue activada la clave del usuario.
    /// </summary>
    public DateTime UsuarioClaveFechaActiva { get; set; }

    /// <summary>
    /// Fecha en que aviso la activación de la clave al usuario.
    /// </summary>
    public DateTime UsuarioClaveFechaAviso { get; set; }

    /// <summary>
    /// Número de Cédula de la persona que fue registrada como usuario.
    /// </summary>
    public string UsuarioPersonaCedula { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long UsuarioPersonaNss { get; set; }

    /// <summary>
    /// Nombres de la persona que fue registrada como usuario.
    /// </summary>
    public string UsuarioPersonaNombre { get; set; } = null!;

    /// <summary>
    /// Apellidos de la persona que fue registrada como usuario.
    /// </summary>
    public string UsuarioPersonaApellidos { get; set; } = null!;

    /// <summary>
    /// Cargo que desempeña el usuario.
    /// </summary>
    public string UsuarioCargo { get; set; } = null!;

    /// <summary>
    /// Clave del documento donde se solcito la activación de la clave para el usuario.
    /// </summary>
    public string UsuarioDocumentoClave { get; set; } = null!;

    /// <summary>
    /// Número del documento (ARCHI) donde se solcito la activación de la clave para el usuario.
    /// </summary>
    public string UsuarioDocumentoNumero { get; set; } = null!;

    /// <summary>
    /// Observaciones sobre el registro de la clave de usuario.
    /// </summary>
    public string UsuarioNotas { get; set; } = null!;

    /// <summary>
    /// Número  único que representa la novedad sobre el registro de usuarios.
    /// </summary>
    public byte TipoNovedadNumero { get; set; }

    /// <summary>
    /// Número único que identifica cada uno de los regímenes definidos en la ley 87-01, (Contributivo, Subsidiado y Contributivo Subsidiado).
    /// </summary>
    public byte RegimenNumero { get; set; }

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

    public virtual SeguridadUsuariosEstadoClaveCatum EstadoClaveCodigoNavigation { get; set; } = null!;

    public virtual ICollection<SeguridadEventosLogsTran> SeguridadEventosLogsTrans { get; set; } = new List<SeguridadEventosLogsTran>();

    public virtual ICollection<SeguridadUsuariosContactosTran> SeguridadUsuariosContactosTrans { get; set; } = new List<SeguridadUsuariosContactosTran>();

    public virtual ICollection<SeguridadUsuariosDocumentosTran> SeguridadUsuariosDocumentosTrans { get; set; } = new List<SeguridadUsuariosDocumentosTran>();

    public virtual ICollection<SeguridadUsuariosGruposTran> SeguridadUsuariosGruposTrans { get; set; } = new List<SeguridadUsuariosGruposTran>();

    public virtual SeguridadUsuariosNovedadTipoCatum TipoNovedadNumeroNavigation { get; set; } = null!;

    public virtual TssCiudadanosMaster UsuarioPersonaNssNavigation { get; set; } = null!;
}
