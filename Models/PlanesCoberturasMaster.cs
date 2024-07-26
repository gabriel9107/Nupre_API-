using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de las coberturas de servicios de salud, relacionados con los Planes de Servicios de Salud, según grupos y subgrupos de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesCoberturasMaster
{
    /// <summary>
    /// Código único de la versión del Plan de servicios de Salud (PDSS) al cual pertenece el Subgrupo.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Número único asignado al subgrupo del PDSS, se incrementa de 1 a N para cada grupo del PDSS.
    /// </summary>
    public byte SubGrupoNumero { get; set; }

    /// <summary>
    /// Numero único de cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public short CoberturaNumero { get; set; }

    /// <summary>
    /// Identifica el número de Plan de cual se tomo la información para este plan.
    /// </summary>
    public string PlanNumeroOrigen { get; set; } = null!;

    /// <summary>
    /// Número único que representa la  información (Resolución, Versión de PDSS,  Inclusiones o exclusiones, etc.  ). Relacionadas con la revisión de las cobertura para este plan.
    /// </summary>
    public byte RevisionNumero { get; set; }

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

    public virtual CoberturasMaster CoberturaNumeroNavigation { get; set; } = null!;

    public virtual PlanesSubgruposMaster PlanesSubgruposMaster { get; set; } = null!;

    public virtual PlanesCoberturasRevisionesCatum RevisionNumeroNavigation { get; set; } = null!;
}
