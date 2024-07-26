using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresHistorico
{
    public string PromotorCedula { get; set; } = null!;

    public byte ArsNumero { get; set; }

    public byte ArsNumeroAutorizo { get; set; }

    public string? PromotoraRnc { get; set; }

    public byte PromotorEstadoNumero { get; set; }

    public DateTime PromotorEstadoFecha { get; set; }

    public string PromotorCorreoElectronico { get; set; } = null!;

    public string PromotorObservacion { get; set; } = null!;

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

    public virtual AuditoresMaster PromotorCedulaNavigation { get; set; } = null!;
}
