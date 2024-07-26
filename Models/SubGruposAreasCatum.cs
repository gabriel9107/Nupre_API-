﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las aéreas de servicios de salud (departamentos)  y su relación con los subgrupos de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SubGruposAreasCatum
{
    /// <summary>
    /// Número único asignado al área, se refiere al área donde se deben prestar  las coberturas de subgrupo del PDSS,  Ambulatoria, Urgencias y Hospitalización.
    /// </summary>
    public byte SubGrupoAreaNumero { get; set; }

    /// <summary>
    /// Descripción del área, se refiere al área donde se deben prestar las coberturas de subgrupo del PDSS, Ambulatoria, Urgencias y Hospitalización.
    /// </summary>
    public string SubGrupoAreaDescripcion { get; set; } = null!;

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
