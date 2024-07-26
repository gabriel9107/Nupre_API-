﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene el código internacional de enfermedades  (Diagnósticos)   (CIE10) de la OPS OMS y su relación con los códigos únicos de procedimiento de salud (CUPS), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SubgruposCie10Catum
{
    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Número único asignado al subgrupo del PDSS, se incrementa de 1 a N para cada grupo del PDSS.
    /// </summary>
    public byte SubGrupoNumero { get; set; }

    /// <summary>
    /// Es el código de una enfermedad o padecimiento y pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
    /// </summary>
    public string Cie10Codigo { get; set; } = null!;

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

    public virtual ComunesCie10Catum Cie10CodigoNavigation { get; set; } = null!;

    public virtual SubGruposCatum SubGruposCatum { get; set; } = null!;
}
