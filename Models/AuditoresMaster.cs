using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresMaster
{
    public string PromotorCedula { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long PromotorNss { get; set; }

    public byte? ArsNumero { get; set; }

    public byte ArsNumeroAutorizo { get; set; }

    public string? PromotoraRnc { get; set; }

    public DateTime? PromotorFechaAcreditacion { get; set; }

    public DateTime? PromotorFechaVencimiento { get; set; }

    public byte PromotorEstadoNumero { get; set; }

    public DateTime PromotorEstadoFecha { get; set; }

    public string PromotorEstadoMotivo { get; set; } = null!;

    public short? DisposicionNumero { get; set; }

    /// <summary>
    /// Dirección de  residencia de la persona.
    /// </summary>
    public string PromotorDireccion { get; set; } = null!;

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Número de teléfono de la persona..
    /// </summary>
    public string PromotorTelefono { get; set; } = null!;

    /// <summary>
    /// Numero de teléfono celular de la persona.
    /// </summary>
    public string PromotorCelular { get; set; } = null!;

    /// <summary>
    /// Número único que identifica el nivel académico de la persona.
    /// </summary>
    public byte NivelAcademicoNumero { get; set; }

    /// <summary>
    /// Número único que identifica el tipo de agente promotor (Local, Nacional).
    /// </summary>
    public byte AgenteTipoNumero { get; set; }

    public string PromotorCorreoElectronico { get; set; } = null!;

    public string PromotorObservacion { get; set; } = null!;

    public string? PromotorRepresentante { get; set; }

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

    public virtual PromotoresAgentesTiposCatum AgenteTipoNumero1 { get; set; } = null!;

    public virtual AuditoresAgentesTiposCatum AgenteTipoNumeroNavigation { get; set; } = null!;

    public virtual ArsMaster? ArsNumeroNavigation { get; set; }

    public virtual ICollection<AuditoresExamenesTran> AuditoresExamenesTrans { get; set; } = new List<AuditoresExamenesTran>();

    public virtual ICollection<AuditoresHistorico> AuditoresHistoricos { get; set; } = new List<AuditoresHistorico>();

    public virtual ICollection<AuditoresRequerimientosHistorico> AuditoresRequerimientosHistoricos { get; set; } = new List<AuditoresRequerimientosHistorico>();

    public virtual ComunesNivelesAcademicosCatum NivelAcademicoNumeroNavigation { get; set; } = null!;

    public virtual PromotoresEstadosCatum PromotorEstadoNumero1 { get; set; } = null!;

    public virtual AuditoresEstadosCatum PromotorEstadoNumeroNavigation { get; set; } = null!;

    public virtual TssCiudadanosMaster PromotorNssNavigation { get; set; } = null!;

    public virtual AuditoresAuditorasMaster? PromotoraRncNavigation { get; set; }
}
