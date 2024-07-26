using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los grupos de servicios de salud y su relación con los subgrupos de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SubGruposGruposCatum
{
    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Descripción del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public string GrupoDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripción corta (Resumido para mejor visualización en las interfaces) del grupo  al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public string GrupoDescripcionCorta { get; set; } = null!;

    /// <summary>
    /// Explicación detallada del objetivo y contenido del grupo  al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public string GrupoExplicacion { get; set; } = null!;

    /// <summary>
    /// Específica la forma en que se van a cuantificar los servicios para la evaluación del  PDSS, 1 cuando se cuentan cada uno de los servicios prestados (3 Medicamentos) , 2 se cuenta el servicio como dado dentro de un episodio de salud (Se prestó Medicamentos)
    /// </summary>
    public byte GrupoConteoNumero { get; set; }

    /// <summary>
    /// Especifica si el grupo es o no de servicios de salud
    /// </summary>
    public string GrupoServicio { get; set; } = null!;

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

    public virtual ICollection<PlanesGruposMaster> PlanesGruposMasters { get; set; } = new List<PlanesGruposMaster>();

    public virtual ICollection<SubGruposCatum> SubGruposCata { get; set; } = new List<SubGruposCatum>();
}
