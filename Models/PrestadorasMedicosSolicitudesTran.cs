using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro con los detalles de las Prestadoras de Servicios de Salud (PSS) Médicos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasMedicosSolicitudesTran
{
    public int SolicitudNumero { get; set; }

    public DateTime SolicitudFecha { get; set; }

    public byte ArsNumero { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string MedicoCedula { get; set; } = null!;

    public string MedicoNombreCompleto { get; set; } = null!;

    /// <summary>
    /// Dirección donde está la sede o domicilio principal del prestador de servicio de salud.
    /// </summary>
    public string MedicoDireccion { get; set; } = null!;

    /// <summary>
    /// Número de Exequátur del Médico.
    /// </summary>
    public string MedicoExequatur { get; set; } = null!;

    /// <summary>
    /// Email del prestador de servicio de salud.
    /// </summary>
    public string MedicoMail { get; set; } = null!;

    /// <summary>
    /// Numero de la especialidad médica. 
    /// </summary>
    public short EspecialidadNumero1 { get; set; }

    /// <summary>
    /// Numero de la especialidad médica. 
    /// </summary>
    public short EspecialidadNumero2 { get; set; }

    /// <summary>
    /// Numero de la especialidad médica. 
    /// </summary>
    public short EspecialidadNumero3 { get; set; }

    /// <summary>
    /// Teléfono del consultorio del prestador de servicio de salud.
    /// </summary>
    public string MedicoTelefonoExtencion { get; set; } = null!;

    /// <summary>
    /// Teléfono del consultorio del prestador de servicio de salud.
    /// </summary>
    public string MedicoTelefonoConsultorio { get; set; } = null!;

    /// <summary>
    /// Teléfono de la residencia del prestador de servicio de salud.
    /// </summary>
    public string MedicoTelefonoResidencia { get; set; } = null!;

    /// <summary>
    /// Teléfono móvil del prestador de servicio de salud.
    /// </summary>
    public string MedicoCelular { get; set; } = null!;

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    public byte SolicitudEstadoNumero { get; set; }

    public DateTime SolicitudEstadoFecha { get; set; }

    public string SolicitudEstadoNota { get; set; } = null!;

    public string SolicitudUsuarioCuenta { get; set; } = null!;

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

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

    public virtual PrestadorasEspecialidadesCatum EspecialidadNumero1Navigation { get; set; } = null!;

    public virtual PrestadorasEspecialidadesCatum EspecialidadNumero2Navigation { get; set; } = null!;

    public virtual PrestadorasEspecialidadesCatum EspecialidadNumero3Navigation { get; set; } = null!;

    public virtual ComunesMunicipiosCatum MunicipioNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PrestadorasMedicosSolicitudesHistorico> PrestadorasMedicosSolicitudesHistoricos { get; set; } = new List<PrestadorasMedicosSolicitudesHistorico>();
}
