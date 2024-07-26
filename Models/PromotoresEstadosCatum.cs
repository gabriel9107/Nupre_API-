using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PromotoresEstadosCatum
{
    public byte PromotorEstadoNumero { get; set; }

    public string PromotorEstadoCodigo { get; set; } = null!;

    public string PromotorEstadoDescripcion { get; set; } = null!;

    public string PromotorEstadoExplicacion { get; set; } = null!;

    public string PromotorEstadoMotivo { get; set; } = null!;

    public string PromotorEstadoConsulta { get; set; } = null!;

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

    public virtual ICollection<AuditoresMaster> AuditoresMasters { get; set; } = new List<AuditoresMaster>();

    public virtual ICollection<PromotoresMaster> PromotoresMasters { get; set; } = new List<PromotoresMaster>();

    public virtual ICollection<PromotoresPromotorasMaster> PromotoresPromotorasMasters { get; set; } = new List<PromotoresPromotorasMaster>();
}
