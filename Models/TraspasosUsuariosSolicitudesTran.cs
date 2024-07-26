using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosUsuariosSolicitudesTran
{
    /// <summary>
    /// Es una secuencia de 1 a N que depende de la solicitud generada en la oficina virtual,  y representa cada solicitud que realiza el usuario en la oficina virtual.
    /// </summary>
    public int SolicitudNumero { get; set; }

    /// <summary>
    /// Para reportar la fecha en que se realizo solicitud en la oficina virtual  DDMMYYYY 
    /// </summary>
    public DateTime SolicitudFecha { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string UsuarioCedula { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long UsuarioNss { get; set; }

    /// <summary>
    /// Es el nombre propio de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string UsuarioNombres { get; set; } = null!;

    /// <summary>
    /// Es el primer apellido de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string UsuarioPrimerApellido { get; set; } = null!;

    /// <summary>
    /// Es el segundo apellido de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string UsuarioSegundoApellido { get; set; } = null!;

    /// <summary>
    /// Sexo de la persona (Afiliado)  (F=femenino, M=masculino, N = No Especificado).
    /// </summary>
    public string UsuarioSexo { get; set; } = null!;

    /// <summary>
    /// Telefono número 1 del usuario que realiza la solicitud a traves de la oficina virtual de la SISALRIL.
    /// </summary>
    public string UsuarioTelefono1 { get; set; } = null!;

    /// <summary>
    /// Telefono número 2 del usuario que realiza la solicitud a traves de la oficina virtual de la SISALRIL.
    /// </summary>
    public string UsuarioTelefono2 { get; set; } = null!;

    public string UsuarioMail { get; set; } = null!;

    public string UsuarioDireccion { get; set; } = null!;

    /// <summary>
    /// Cargo que desempeña el usuario.
    /// </summary>
    public string UsuarioCargo { get; set; } = null!;

    /// <summary>
    /// Registro Nacional de Contribuyente de la Empresa que reportó al trabajador.
    /// </summary>
    public string EmpleadorRncOCedula { get; set; } = null!;

    /// <summary>
    /// Es el número único que le asigna la Tesorería de la Seguridad Social a cada uno de los empleadores que se registran en dicha institución.    
    /// </summary>
    public int EmpleadorRegistroPatronal { get; set; }

    /// <summary>
    /// Es la razón social registrada por el empleador en la DGII, y que utiliza la Tesorería de la Seguridad Social en su registro de empleadores. Representa el nombre oficial de cada empresa o institución en el país.
    /// </summary>
    public string EmpleadorRazonSocial { get; set; } = null!;

    /// <summary>
    /// Teléfono del empleador.
    /// </summary>
    public string EmpleadorTelefono { get; set; } = null!;

    public string SupervisorInmediatoCedula { get; set; } = null!;

    public string SupervisorInmediatoNombre { get; set; } = null!;

    public string SupervisorInmediatoTelefono1 { get; set; } = null!;

    public string SupervisorInmediatoTelefono2 { get; set; } = null!;

    public string SupervisorInmediatoCargo { get; set; } = null!;

    /// <summary>
    /// Es la cuenta de correo electronica del usuario que realiza la solicitud en la oficina virtual, esta puede ser una cuenta personal o una cuenta empresarial.
    /// </summary>
    public string SupervisorInmediatoCuenta { get; set; } = null!;

    /// <summary>
    /// Número del documento (ARCHI) donde se solcito la activación de la clave para el usuario.
    /// </summary>
    public int DocumentoNumero { get; set; }

    /// <summary>
    /// Es el número que representa el estado de la solicitud realizada a traves de la oficina virtual, dependerá de las validaciones que se realizan en las solicitudes de la oficina virtual.
    /// </summary>
    public byte SolicitudEstadoNumero { get; set; }

    public string? MotivoBajaNumero { get; set; }

    /// <summary>
    /// Esta Columna guarda el motivo de la baja de la solicitud 
    /// </summary>
    public string? SolicitudMotivo { get; set; }

    /// <summary>
    /// Indica la fecha del estado de la solicitud.
    /// </summary>
    public DateTime SolicitudEstadoFecha { get; set; }

    /// <summary>
    /// Es el número que representa el estado de la solicitud realizada a traves de la oficina virtual, dependerá de las validaciones que se realizan en las solicitudes de la oficina virtual.
    /// </summary>
    public string SolicitudEstadoNota { get; set; } = null!;

    /// <summary>
    /// Código que indica el detalle de la acción tomada por la SISALRIL.
    /// </summary>
    public byte MotivoNumero { get; set; }

    public string? BajaComentario { get; set; }

    public bool BajaDefinitiva { get; set; }

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

    public virtual AfiliadosMotivosBajaCatum? MotivoBajaNumeroNavigation { get; set; }

    public virtual TraspasosUsuariosMotivosCatum MotivoNumeroNavigation { get; set; } = null!;

    public virtual TraspasosUsuariosSolicitudesEstadosCatum SolicitudEstadoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<TraspasosUsuariosSolicitudesHistorico> TraspasosUsuariosSolicitudesHistoricos { get; set; } = new List<TraspasosUsuariosSolicitudesHistorico>();

    public virtual ICollection<TraspasosUsuariosSolicitudesRequerimientosTran> TraspasosUsuariosSolicitudesRequerimientosTrans { get; set; } = new List<TraspasosUsuariosSolicitudesRequerimientosTran>();
}
