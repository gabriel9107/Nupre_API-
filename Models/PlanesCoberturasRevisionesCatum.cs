using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles  de las revisiones (Resolución, Versión de PDSS, Inclusiones o exclusiones, etc.  ). Relacionadas con la revisión de las coberturas para un plan de servicios de salud, fuente de datos son los sistemas internos de 
/// </summary>
public partial class PlanesCoberturasRevisionesCatum
{
    /// <summary>
    /// Número único que representa la  información (Resolución, Versión de PDSS,  Inclusiones o exclusiones, etc.  ). Relacionadas con la revisión de las cobertura para este plan.
    /// </summary>
    public byte RevisionNumero { get; set; }

    /// <summary>
    /// Es la descripción de la  información (Resolución, Versión de PDSS,  Inclusiones o exclusiones, etc.  ). Relacionadas con la revisión de las cobertura para este plan.
    /// </summary>
    public string RevisionDescripcion { get; set; } = null!;

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

    public virtual ICollection<PlanesCoberturasMaster> PlanesCoberturasMasters { get; set; } = new List<PlanesCoberturasMaster>();
}
