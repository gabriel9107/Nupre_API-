using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresDisposicionesTran
{
    public short DisposicionNumero { get; set; }

    public byte DisposicionTipoNumero { get; set; }

    public DateTime DisposicionFecha { get; set; }

    public short? PeriodoNumero { get; set; }

    public string PromotoraRnc { get; set; } = null!;

    public string? PromotorCedula { get; set; }

    public string DisposicionDetalle { get; set; } = null!;

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

    public virtual AuditoresDisposicionesTiposCatum DisposicionTipoNumeroNavigation { get; set; } = null!;
}
