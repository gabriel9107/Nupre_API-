using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los grupos de población y su relación con los subgrupos de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SubGruposPoblacionesCatum
{
    /// <summary>
    /// Número único de población (Grupo etario) 
    /// </summary>
    public byte SubGrupoPoblacionNumero { get; set; }

    /// <summary>
    /// Descripción de la población (Grupo etario)
    /// </summary>
    public string SubGrupoPoblacionDescripcion { get; set; } = null!;

    /// <summary>
    /// Si la población (Grupo etario) incluye las mujeres (Sexo femenino)
    /// </summary>
    public string SubGrupoPoblacionMujeres { get; set; } = null!;

    /// <summary>
    /// Si la población (Grupo etario) incluye los  hombres (Sexo Masculino)
    /// </summary>
    public string SubGrupoPoblacionHombres { get; set; } = null!;

    /// <summary>
    /// Si la población (Grupo etario) incluye los niños (Ambos Sexos)
    /// </summary>
    public string SubGrupoPoblacionNinios { get; set; } = null!;

    /// <summary>
    /// Desde cual edad se incluye la población (Grupo etario)  para hombres y mujeres.
    /// </summary>
    public short SubGrupoPoblacionDesdeHm { get; set; }

    /// <summary>
    /// Desde cual edad se incluye la población (Grupo etario)  para hombres y mujeres.
    /// </summary>
    public short SubGrupoPoblacionHastaHm { get; set; }

    /// <summary>
    /// Desde cual edad se incluye la población (Grupo etario)  para los niños.
    /// </summary>
    public short SubGrupoPoblacionDesdeNinios { get; set; }

    /// <summary>
    /// Hasta cual edad se incluye la población (Grupo etario)   para los niños.
    /// </summary>
    public short SubGrupoPoblacionHastaNinios { get; set; }

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
