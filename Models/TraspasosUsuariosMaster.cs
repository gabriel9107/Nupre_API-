using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosUsuariosMaster
{
    /// <summary>
    /// Número de Cédula de la persona que fue registrada como usuario.
    /// </summary>
    public string UsuarioCedula { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long UsuarioNss { get; set; }

    /// <summary>
    /// Es el número único que le asigna la Tesorería de la Seguridad Social a cada uno de los empleadores que se registran en dicha institución.    
    /// </summary>
    public int EmpleadorRegistroPatronal { get; set; }

    /// <summary>
    /// Nombres de la persona que fue registrada como usuario.
    /// </summary>
    public string UsuarioNombreCompleto { get; set; } = null!;

    /// <summary>
    /// Telefono de contacto1
    /// </summary>
    public string UsuarioTelefono1 { get; set; } = null!;

    /// <summary>
    /// Telefono de contacto2
    /// </summary>
    public string UsuarioTelefono2 { get; set; } = null!;

    public string UsuarioDireccion { get; set; } = null!;

    /// <summary>
    /// Sexo del usuario
    /// </summary>
    public string UsuarioSexo { get; set; } = null!;

    /// <summary>
    /// Cargo del usuario dentro de la emplresa
    /// </summary>
    public string UsuarioCargo { get; set; } = null!;

    public int SolicitudNumero { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long SupervirorInmediatoNss { get; set; }

    public string SupervisorInmediatoTelefono { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public string SupervisorInmediatoCuenta { get; set; } = null!;

    public string? MotivoBaja { get; set; }

    public DateTime UsuarioEstadoFecha { get; set; }

    public byte UsuarioEstadoNumero { get; set; }

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

    public virtual TraspasosUsuariosEstadosCatum UsuarioEstadoNumeroNavigation { get; set; } = null!;

    public virtual TssCiudadanosMaster UsuarioNssNavigation { get; set; } = null!;
}
