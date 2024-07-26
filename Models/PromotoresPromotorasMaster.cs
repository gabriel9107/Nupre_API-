using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PromotoresPromotorasMaster
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

    public virtual PromotoresEstadosCatum PromotorEstadoNumeroNavigation { get; set; } = null!;

    public virtual TssEmpleadoresMaster PromotoraRegistroPatronalNavigation { get; set; } = null!;

    public virtual ICollection<PromotoresMaster> PromotoresMasters { get; set; } = new List<PromotoresMaster>();

    public virtual ICollection<PromotoresPromotorasHistorico> PromotoresPromotorasHistoricos { get; set; } = new List<PromotoresPromotorasHistorico>();

    public virtual ICollection<PromotoresPromotorasRequerimientosTran> PromotoresPromotorasRequerimientosTrans { get; set; } = new List<PromotoresPromotorasRequerimientosTran>();
}
