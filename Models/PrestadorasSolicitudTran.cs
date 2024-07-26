using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las solicitudes de las ARS /ARL para el registros  las Prestadoras de Servicios de Salud (PSS) institucionales,  su fuente de datos son los sistemas  de la SISALRIL.
/// </summary>
public partial class PrestadorasSolicitudTran
{
    /// <summary>
    /// Número único de la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL.
    /// </summary>
    public int PrestadoraSolicitudNumero { get; set; }

    /// <summary>
    /// Fecha de la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL.
    /// </summary>
    public DateTime PrestadoraSolicitudFecha { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único del tipo de solicitud de inclusión de PSS Institucional que realizan  las ARS/ARL.
    /// </summary>
    public byte PrestadoraSolicitudTipoNumero { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumeroSedePrincipal { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// RNC  (Registro Nacional Contribuyente) del prestador de servicio de salud.
    /// </summary>
    public string PrestadoraRncOCedula { get; set; } = null!;

    /// <summary>
    /// Nombre del prestador de servicio de salud (PSS) que entrego los servicio (Institucional o Médico).
    /// </summary>
    public string PrestadoraNombre { get; set; } = null!;

    /// <summary>
    /// Teléfono principal del prestador de servicio de salud.
    /// </summary>
    public string PrestadoraTelefono1 { get; set; } = null!;

    /// <summary>
    /// Teléfono principal del prestador de servicio de salud.
    /// </summary>
    public string PrestadoraTelefono2 { get; set; } = null!;

    /// <summary>
    /// Teléfono principal del prestador de servicio de salud.
    /// </summary>
    public string PrestadoraTelefono3 { get; set; } = null!;

    /// <summary>
    /// Email del prestador de servicio de salud.
    /// </summary>
    public string PrestadoraEmail { get; set; } = null!;

    /// <summary>
    /// Website de la prestadora de salud institucional.
    /// </summary>
    public string PrestadoraWebsite { get; set; } = null!;

    /// <summary>
    /// Dirección donde está la sede o domicilio principal del prestador de servicio de salud.
    /// </summary>
    public string PrestadoraDireccion { get; set; } = null!;

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Es un número único que identifica el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public byte PrestadoraTipoNumero { get; set; }

    /// <summary>
    /// Número único que indica el estado de proceso en que se encuentra la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL
    /// </summary>
    public byte PrestadoraSolicitudEstadoNumero { get; set; }

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 1er. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraPrimerNivel { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 2do. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraSegundoNivel { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 3er. Nivel de atención de salud.
    /// </summary>
    public string PrestadoraTercerNivel { get; set; } = null!;

    /// <summary>
    /// Es el código único de habilitación que asigna el Ministerio de Salud a cada una de la  prestadora  de servicio de salud habilitada de categoría institucional.
    /// </summary>
    public string PrestadoraCodigoSespas { get; set; } = null!;

    /// <summary>
    /// Indica si el código único de habilitación que asigna el Ministerio de Salud a es provisional.
    /// </summary>
    public string PrestadoraCodigoSespasProvisional { get; set; } = null!;

    /// <summary>
    /// Observación o motivo de rechazo de  la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL.
    /// </summary>
    public string PrestadoraSolicitudObservacionDevolucion { get; set; } = null!;

    public DateTime? MispaHabilitacionVencimientoFecha { get; set; }

    public string? PrestadoraGeolocalizacion { get; set; }

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

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuarioModifica { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFechaModifica { get; set; }

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual ComunesMunicipiosCatum MunicipioNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasSolicitudesEstadoCatum PrestadoraSolicitudEstadoNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasSolicitudesTipoCatum PrestadoraSolicitudTipoNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasTipoCatum PrestadoraTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PrestadorasSolicitudDocumentosTran> PrestadorasSolicitudDocumentosTrans { get; set; } = new List<PrestadorasSolicitudDocumentosTran>();

    public virtual ICollection<PrestadorasSolicitudesServiciosTran> PrestadorasSolicitudesServiciosTrans { get; set; } = new List<PrestadorasSolicitudesServiciosTran>();
}
