using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las categorías de servicios de salud (departamentos)  y su relación con los subgrupos de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SubGruposCategoriasCatum
{
    /// <summary>
    /// Número único asignado a categoría de los subgrupos del PDSS, se refiere a si las coberturas se prestan bajo un Programa,  Área,  Área/ Servicios o Proceso.
    /// </summary>
    public byte SubGrupoCategoriaNumero { get; set; }

    /// <summary>
    /// Descripción de la categoría de los subgrupos del PDSS,  se refiere a si las coberturas se prestan bajo un Programa,  Área,  Área/ Servicios o Proceso.
    /// </summary>
    public string SubGrupoCategoriaDescripcion { get; set; } = null!;

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

    public virtual ICollection<SubGruposCatum> SubGruposCata { get; set; } = new List<SubGruposCatum>();
}
