using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PlanesEscalaEdadesCatum
{
    /// <summary>
    /// Número único  del estado en que se encuentra un Plan de Salud A=Activo (Puede ser vendido y cargado por la ARS), I=Inactivo (Solo puede ser cargado por la ARS) y N=Nulo (No permite actividad), para futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte PlanEscalaNumero { get; set; }

    /// <summary>
    /// Descripción del estado en que se encuentra un Plan de Salud donde A=Activo (Puede ser vendido y cargado por la ARS), I=Inactivo (Solo puede ser cargado por la ARS) y N=Nulo (No permite actividad).
    /// </summary>
    public string PlanEscalaDescripcion { get; set; } = null!;

    public byte PlanEscalaDesde { get; set; }

    public byte PlanEscalaHasta { get; set; }

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

    public virtual ICollection<PlanesPrimasEdadesCatum> PlanesPrimasEdadesCata { get; set; } = new List<PlanesPrimasEdadesCatum>();
}
