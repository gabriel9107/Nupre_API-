using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de las coberturas de servicios de salud relacionados la Previsión y Promoción de la Salud (PYP) según subgrupos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PypSubGruposCoberturasMaster
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
    /// Año correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoAnio { get; set; }

    /// <summary>
    /// Numero único de cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public short CoberturaNumero { get; set; }

    /// <summary>
    /// Representa el peso del valor de la actividad (Cobertura) para un programa de salud (Subgrupo).
    /// </summary>
    public byte PorcientoPonderado { get; set; }

    /// <summary>
    /// Nos indica en cual orden debe presentarse una actividad (Cobertura) para un programa de salud (Subgrupo).
    /// </summary>
    public byte CoberturaOrden { get; set; }

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

    public virtual SubGruposCatum SubGruposCatum { get; set; } = null!;
}
