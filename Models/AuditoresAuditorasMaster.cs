using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresAuditorasMaster
{
    public string PromotoraRnc { get; set; } = null!;

    /// <summary>
    /// Es el número único que le asigna la Tesorería de la Seguridad Social a cada uno de los empleadores que se registran en dicha institución.    
    /// </summary>
    public int PromotoraRegistroPatronal { get; set; }

    /// <summary>
    /// Fecha en la que se aprobó una entidad en los procesos de acreditación.
    /// </summary>
    public DateTime PromotoraFechaAcreditacion { get; set; }

    public byte PromotorEstadoNumero { get; set; }

    public DateTime PromotorEstadoFecha { get; set; }

    public DateTime? PromotorFechaVencimiento { get; set; }

    public string PromotorEstadoMotivo { get; set; } = null!;

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

    public virtual ICollection<AuditoresAuditorasHistorico> AuditoresAuditorasHistoricos { get; set; } = new List<AuditoresAuditorasHistorico>();

    public virtual ICollection<AuditoresAuditorasRequerimientosTran> AuditoresAuditorasRequerimientosTrans { get; set; } = new List<AuditoresAuditorasRequerimientosTran>();

    public virtual ICollection<AuditoresMaster> AuditoresMasters { get; set; } = new List<AuditoresMaster>();

    public virtual AuditoresEstadosCatum PromotorEstadoNumeroNavigation { get; set; } = null!;

    public virtual TssEmpleadoresMaster PromotoraRegistroPatronalNavigation { get; set; } = null!;
}
