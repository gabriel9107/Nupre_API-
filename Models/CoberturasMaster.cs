using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las coberturas (Servicios y procedimientos de salud),  utilizado por la SISALRIL para identificar  las coberturas de servicios de salud que se prestan en los planes de salud, su fuente de datos son los sistemas internos de la 
/// </summary>
public partial class CoberturasMaster
{
    /// <summary>
    /// Numero único de cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public short CoberturaNumero { get; set; }

    /// <summary>
    /// Descripción de la cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public string CoberturaDescripcion { get; set; } = null!;

    /// <summary>
    /// Número único del tipo de cobertura, clasifica las coberturas en Actos Quirúrgicos, Consultas, Fármacos, Estudios radiológicos, Etc.
    /// </summary>
    public byte CoberturaTipoNumero { get; set; }

    /// <summary>
    /// Es  el código de la clasificación única de procedimientos en salud utilizado por el ministerio de salud de Colombia.
    /// </summary>
    public string CupsCodigo { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura (insumo, procedimiento médico, material, fármaco, servicio, etc.) es uno de los procedimiento o actos quirúrgicos que pueden ser reportados en una objeción de traspasos por condición de enfermedad CDE.
    /// </summary>
    public string CoberturaAplicaTraspasosCde { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 1er. Nivel de atención de salud.
    /// </summary>
    public string CoberturaNivelAtencion1 { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 2do. Nivel de atención de salud.
    /// </summary>
    public string CoberturaNivelAtencion2 { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura del PDSS puede ser entregada en el 3er. Nivel de atención de salud.
    /// </summary>
    public string CoberturaNivelAtencion3 { get; set; } = null!;

    /// <summary>
    /// Nos indica si la cobertura (insumo, procedimiento médico, material, fármaco, servicio, etc.) pertenece a las actividades que se reportan a través del esquema 40 (Seguimiento a la Promoción y Prevención de Salud, Grupo 1 del PDSS).
    /// </summary>
    public string CoberturaAplicaPyp { get; set; } = null!;

    /// <summary>
    /// Número único del tipo de cobertura, clasifica las coberturas en Actos Quirúrgicos, Consultas, Fármacos, Estudios radiológicos, Etc.
    /// </summary>
    public byte PypNivelNumero { get; set; }

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

    public virtual CoberturasTipoCatum CoberturaTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<CoberturasTecnicasTran> CoberturasTecnicasTrans { get; set; } = new List<CoberturasTecnicasTran>();

    public virtual ComunesCupsCatum CupsCodigoNavigation { get; set; } = null!;

    public virtual ICollection<EpisodiosSubsidiadosTran> EpisodiosSubsidiadosTrans { get; set; } = new List<EpisodiosSubsidiadosTran>();

    public virtual ICollection<EpisodiosTran> EpisodiosTrans { get; set; } = new List<EpisodiosTran>();

    public virtual ICollection<PlanesCoberturasMaster> PlanesCoberturasMasters { get; set; } = new List<PlanesCoberturasMaster>();

    public virtual CoberturasPypNivelCatum PypNivelNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PypServiciosTran> PypServiciosTrans { get; set; } = new List<PypServiciosTran>();

    public virtual ICollection<PypSubGruposCoberturasMaster> PypSubGruposCoberturasMasters { get; set; } = new List<PypSubGruposCoberturasMaster>();
}
