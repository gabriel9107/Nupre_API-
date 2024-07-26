using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PlanesPrimasTran
{
    /// <summary>
    /// Código único de la versión del Plan de servicios de Salud (PDSS) al cual pertenece el Subgrupo.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Numero único que identifica la modalidad del plan de salud, representa si el plan es Individual o Colectivo.
    /// </summary>
    public byte PrimaRangoNumero { get; set; }

    public decimal PrimaRangoValor { get; set; }

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

    public virtual PlanesMaster PlanNumeroNavigation { get; set; } = null!;

    public virtual PlanesPrimasRangosCatum PrimaRangoNumeroNavigation { get; set; } = null!;
}
