using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene el código internacional de enfermedades  del tomo de los procedimientos  (CIE9) de la OPS OMS y su relación con los códigos únicos de procedimiento de salud (CUPS), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesCupsCie09Catum
{
    /// <summary>
    /// Es  el código de la clasificación única de procedimientos en salud utilizado por el ministerio de salud de Colombia.
    /// </summary>
    public string CupsCodigo { get; set; } = null!;

    /// <summary>
    /// Es un código que representa un procedimiento de salud y pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
    /// </summary>
    public string Cie09Codigo { get; set; } = null!;

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

    public virtual ComunesCie09Catum Cie09CodigoNavigation { get; set; } = null!;

    public virtual ComunesCupsCatum CupsCodigoNavigation { get; set; } = null!;
}
