using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las diferentes modalidades que aplican para los planes de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesModalidadCatum
{
    /// <summary>
    /// Numero único que identifica la modalidad del plan de salud, representa si el plan es Individual o Colectivo.
    /// </summary>
    public byte PlanModalidadNumero { get; set; }

    /// <summary>
    /// Descripción de la modalidad del plan de salud (Individual o Colectivo).
    /// </summary>
    public string PlanModalidadDescripcion { get; set; } = null!;

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

    public virtual ICollection<PlanesMaster> PlanesMasters { get; set; } = new List<PlanesMaster>();
}
