using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro con los detalles de las Prestadoras de Servicios de Salud (PSS) institucionales (Hospitales, Laboratorios, Farmacias, etc.), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasInstitucionalesMaster
{
    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// RNC  (Registro Nacional Contribuyente) del prestador de servicio de salud.
    /// </summary>
    public string PrestadoraRncOCedula { get; set; } = null!;

    /// <summary>
    /// Número único que indica si la prestadora institucional es una sede principal o una sucursal.
    /// </summary>
    public byte PrestadoraSedeNumero { get; set; }

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
    /// Es un número único que identifica el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public byte PrestadoraTipoNumero { get; set; }

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Cantidad de médicos contratados que tiene la prestadora de servicios de salud (PSS).
    /// </summary>
    public short PrestadoraMedicos { get; set; }

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
    /// Número de la institución que es o a la que pertenece la ARS.
    /// </summary>
    public int InstitucionNumero { get; set; }

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

    public virtual ICollection<IndicadoresPssVisitasMaster> IndicadoresPssVisitasMasters { get; set; } = new List<IndicadoresPssVisitasMaster>();

    public virtual InstitucionesMaster InstitucionNumeroNavigation { get; set; } = null!;

    public virtual ComunesMunicipiosCatum MunicipioNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasSedeCatum PrestadoraSedeNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasTipoCatum PrestadoraTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PrestadorasInstitucionalesArsTran> PrestadorasInstitucionalesArsTrans { get; set; } = new List<PrestadorasInstitucionalesArsTran>();
}
