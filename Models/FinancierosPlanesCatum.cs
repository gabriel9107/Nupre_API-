using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Tabla catálogo que contiene cada tipo de planes relacionados con los reportes de los estados financieros.
/// </summary>
public partial class FinancierosPlanesCatum
{
    /// <summary>
    /// Es el número único de cada tipo de planes relacionados con los reportes de los estados financieros
    /// </summary>
    public byte PlanCuentaNumero { get; set; }

    /// <summary>
    /// Es la descripción de cada tipo de planes relacionados con los reportes de los estados financieros
    /// </summary>
    public string PlanCuentaDescripcion { get; set; } = null!;

    /// <summary>
    /// Es el número único asignado para identificar cuales Planes de Salud son del PDSS o son de los demás planes (Voluntarios, Complementarios, Especiales, etc.), esta columna actualmente solo se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public byte PlanGrupoNumero { get; set; }

    /// <summary>
    /// Periodo determinado para las cuentas de los estados financieros y grupos, esta columna actualmente solo se utiliza en los estados de resultados de los estados financieros.
    /// </summary>
    public int PlanCuentaPeriodo { get; set; }

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

    public virtual ICollection<FinancierosEstadosTran> FinancierosEstadosTrans { get; set; } = new List<FinancierosEstadosTran>();

    public virtual FinancierosPlanesGruposCatum PlanGrupoNumeroNavigation { get; set; } = null!;
}
