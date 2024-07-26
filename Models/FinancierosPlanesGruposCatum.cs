using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Tabla catálogo que contiene cada grupo de planes relacionados con los reportes de los estados financieros.
/// </summary>
public partial class FinancierosPlanesGruposCatum
{
    /// <summary>
    /// Es el número único asignado para identificar cuales Planes de Salud son del PDSS o son de los demás planes (Voluntarios, Complementarios, Especiales, etc.), esta columna actualmente solo se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public byte PlanGrupoNumero { get; set; }

    /// <summary>
    /// Es el código asignado para identificar cuales grupos Planes de Salud son del PDSS o son de los demás planes (Voluntarios, Complementarios, Especiales, etc.), esta columna actualmente solo se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public string PlanGrupoCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripción que identifica cuales Planes de Salud son del PDSS o son de los demás planes (Voluntarios, Complementarios, Especiales, etc.), esta columna se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public string PlanGrupoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es la explicación que identifica cuales Planes de Salud son del PDSS o son de los demás planes (Voluntarios, Complementarios, Especiales, etc.), esta columna se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public string PlanGrupoExplicacion { get; set; } = null!;

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

    public virtual ICollection<FinancierosPlanesCatum> FinancierosPlanesCata { get; set; } = new List<FinancierosPlanesCatum>();
}
