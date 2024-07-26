using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una vista de las coberturas según grupo y subgrupos de servicios de salud, utilizados para el registro de los detalles relacionados con traspasos con condición de enfermedad (CDE), su fuente de datos  la tabla Planes Subgrupos Coberturas.
/// </summary>
public partial class TraspasosProcedimientosVistum
{
    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Numero único de cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public int CoberturaNumero { get; set; }

    /// <summary>
    /// Descripción del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public string GrupoDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripción de la cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public string CoberturaDescripcion { get; set; } = null!;

    /// <summary>
    /// Número único del tipo de cobertura, clasifica las coberturas en Actos Quirúrgicos, Consultas, Fármacos, Estudios radiológicos, Etc.
    /// </summary>
    public byte CoberturaTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de cobertura, clasifica las coberturas en Actos Quirúrgicos, Consultas, Fármacos, Estudios radiológicos, Etc.
    /// </summary>
    public string CoberturaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es  el código de la clasificación única de procedimientos en salud utilizado por el ministerio de salud de Colombia.
    /// </summary>
    public string CodigoCups { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura (insumo, procedimiento médico, material, fármaco, servicio, etc.) es uno de los procedimiento o actos quirúrgicos que pueden ser reportados en una objeción de traspasos por condición de enfermedad CDE.
    /// </summary>
    public string CoberturaAplicaTraspasosCde { get; set; } = null!;

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

    public virtual ICollection<TraspasosFormulariosCdeDetallesTran> TraspasosFormulariosCdeDetallesTrans { get; set; } = new List<TraspasosFormulariosCdeDetallesTran>();
}
