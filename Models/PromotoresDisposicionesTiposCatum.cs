using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PromotoresDisposicionesTiposCatum
{
    public byte DisposicionTipoNumero { get; set; }

    public string DisposicionTipoDescripcion { get; set; } = null!;

    public string DisposicionTipoPromotora { get; set; } = null!;

    public string DisposicionTipoPromotor { get; set; } = null!;

    public string DisposicionTipoRequerimientos { get; set; } = null!;

    public string DisposicionTipoExamenes { get; set; } = null!;

    public string DisposicionTipoEstado { get; set; } = null!;

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

    public virtual ICollection<PromotoresDisposicionesTran> PromotoresDisposicionesTrans { get; set; } = new List<PromotoresDisposicionesTran>();
}
