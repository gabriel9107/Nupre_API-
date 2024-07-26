using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un  maestro con los datos de las personas que participan en los procesos de acreditación, sistema acreditación,  su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesPersonasMaster
{
    /// <summary>
    /// Secuencia única asignada a cada persona en el sistema de acreditación.
    /// </summary>
    public short PersonaSecuencia { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long PersonaNss { get; set; }

    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único que identifica la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public byte AcreditacionCategoriaNumero { get; set; }

    /// <summary>
    /// Número único que identifica que quien se está acreditando es una persona o entidad.
    /// </summary>
    public byte AcreditacionClaseNumero { get; set; }

    public byte AcreditacionEstadoNumero { get; set; }

    /// <summary>
    /// Dirección de  residencia de la persona.
    /// </summary>
    public string PersonaDireccion { get; set; } = null!;

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Número único  asignado a cada sector de las ciudades y municipio por la JCE.
    /// </summary>
    public short SectorNumero { get; set; }

    /// <summary>
    /// Número único que identifica la ciudad
    /// </summary>
    public byte CiudadNumero { get; set; }

    /// <summary>
    /// Número de teléfono de la persona..
    /// </summary>
    public string PersonaTelefono { get; set; } = null!;

    /// <summary>
    /// Numero de teléfono celular de la persona.
    /// </summary>
    public string PersonaCelular { get; set; } = null!;

    /// <summary>
    /// Número único que identifica el nivel académico de la persona.
    /// </summary>
    public byte NivelAcademicoNumero { get; set; }

    /// <summary>
    /// Número único que identifica el tipo de agente promotor (Local, Nacional).
    /// </summary>
    public byte AgenteTipoNumero { get; set; }

    public string PersonaCorreoElectronico { get; set; } = null!;

    public DateTime PersonaFechaAcreditacion { get; set; }

    public DateTime PersonaFechaRenovacion { get; set; }

    public DateTime PersonaFechaVencimiento { get; set; }

    public string PersonaObservacion { get; set; } = null!;

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

    public virtual AcreditacionesCategoriasClasesCatum AcreditacionC { get; set; } = null!;

    public virtual AcreditacionesEstadosCatum AcreditacionEstadoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<AcreditacionesEntidadesPersonasTran> AcreditacionesEntidadesPersonasTrans { get; set; } = new List<AcreditacionesEntidadesPersonasTran>();

    public virtual ICollection<AcreditacionesExamenesTran> AcreditacionesExamenesTrans { get; set; } = new List<AcreditacionesExamenesTran>();

    public virtual ICollection<AcreditacionesPersonasPeriodosTran> AcreditacionesPersonasPeriodosTrans { get; set; } = new List<AcreditacionesPersonasPeriodosTran>();

    public virtual ICollection<AcreditacionesPersonasRequerimientosTran> AcreditacionesPersonasRequerimientosTrans { get; set; } = new List<AcreditacionesPersonasRequerimientosTran>();

    public virtual AcreditacionesAgenteTipoCatum AgenteTipoNumeroNavigation { get; set; } = null!;

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual ComunesNivelesAcademicosCatum NivelAcademicoNumeroNavigation { get; set; } = null!;

    public virtual TssCiudadanosMaster PersonaNssNavigation { get; set; } = null!;
}
