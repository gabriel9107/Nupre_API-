using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles de los códigos únicos de procedimientos de salud (CUPS del ministerios de salud de Colombia), se relacionan con las coberturas de servicios de  salud,  fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesCupsCatum
{
    /// <summary>
    /// Es  el código de la clasificación única de procedimientos en salud utilizado por el ministerio de salud de Colombia.
    /// </summary>
    public string CupsCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripción del código de la clasificación única de procedimientos en salud utilizado por el ministerio de salud de Colombia.
    /// </summary>
    public string CupsDetalle { get; set; } = null!;

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

    public virtual ICollection<CoberturasMaster> CoberturasMasters { get; set; } = new List<CoberturasMaster>();

    public virtual ICollection<ComunesCupsCie09Catum> ComunesCupsCie09Cata { get; set; } = new List<ComunesCupsCie09Catum>();
}
