using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de las poblaciones objetivas según Grupos y Subgrupos de servicios de salud, para el seguimiento del PYP a través del esquema 40, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PypSubGruposPoblacionesCatum
{
    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Número único asignado al subgrupo del PDSS, se incrementa de 1 a N para cada grupo del PDSS.
    /// </summary>
    public byte SubgrupoNumero { get; set; }

    /// <summary>
    /// Número único de la población objetiva, la cual se agrupo por  edades y sexo enfocados en un programa de salud o que puede recibir servicios médicos (Coberturas) específicas.
    /// </summary>
    public byte PoblacionObjetivaNumero { get; set; }

    /// <summary>
    /// Nos indica con (S/N) cuando una población objetiva es utilizada como un valor de referencia en relación a otras poblaciones objetivas. 
    /// </summary>
    public string PoblacionReferencia { get; set; } = null!;

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

    public virtual PypProblacionesObjetivasCatum PoblacionObjetivaNumeroNavigation { get; set; } = null!;

    public virtual SubGruposCatum SubGruposCatum { get; set; } = null!;
}
