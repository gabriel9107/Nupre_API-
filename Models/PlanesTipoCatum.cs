using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipos de planes de servicios de salud,  identifica el tipo de plan en el Maestro de Planes, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesTipoCatum
{
    /// <summary>
    /// Número único asignado a cada tipo de plan de salud.
    /// </summary>
    public byte PlanTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de plan de salud (PDSS, Complementario, Voluntario, Especia etc.).
    /// </summary>
    public string PlanTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción del tipo de plan de salud (PDSS, Complementario, Voluntario, Especia etc.).
    /// </summary>
    public string PlanTipoExplicacion { get; set; } = null!;

    /// <summary>
    /// Numero único del tipo de plan de salud, representa si el plan es PDSS, Complementario, Voluntario, Especia etc.
    /// </summary>
    public string PlanTipoCodigo { get; set; } = null!;

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

    public virtual ICollection<PrestadorasInstitucionalesArsTran> PrestadorasInstitucionalesArsTrans { get; set; } = new List<PrestadorasInstitucionalesArsTran>();

    public virtual ICollection<PrestadorasMedicosArsTran> PrestadorasMedicosArsTrans { get; set; } = new List<PrestadorasMedicosArsTran>();

    public virtual ICollection<SeguimientosEsquemas35ValidacionesCatum> SeguimientosEsquemas35ValidacionesCata { get; set; } = new List<SeguimientosEsquemas35ValidacionesCatum>();
}
