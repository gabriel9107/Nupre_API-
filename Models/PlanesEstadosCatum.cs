using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los diferentes estados de situación por lo que pasa un plan de servicios de salud,  identifica además que operaciones pueden hacer las ARS con cada plan, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesEstadosCatum
{
    /// <summary>
    /// Número único  del estado en que se encuentra un Plan de Salud A=Activo (Puede ser vendido y cargado por la ARS), I=Inactivo (Solo puede ser cargado por la ARS) y N=Nulo (No permite actividad), para futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte PlanEstadoNumero { get; set; }

    /// <summary>
    /// Código del estado en que se encuentra un Plan de Salud A=Activo (Puede ser vendido y cargado por la ARS), I=Inactivo (Solo puede ser cargado por la ARS) y N=Nulo (No permite actividad).
    /// </summary>
    public string PlanEstadoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del estado en que se encuentra un Plan de Salud donde A=Activo (Puede ser vendido y cargado por la ARS), I=Inactivo (Solo puede ser cargado por la ARS) y N=Nulo (No permite actividad).
    /// </summary>
    public string PlanEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de cada uno de los estados en que estar un Plan de Salud donde A=Activo, I=Inactivo y N=Nulo.
    /// </summary>
    public string PlanEstadoExplicacion { get; set; } = null!;

    /// <summary>
    /// Indica con una S ó N que los planes con este estado pueden o no cargar afiliados.
    /// </summary>
    public string PlanEstadoCargaAfiliados { get; set; } = null!;

    /// <summary>
    /// Indica si un plan se encuentra en este estado si debe publicar en la WEB o no.
    /// </summary>
    public string PlanEstadoPublicar { get; set; } = null!;

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

    public virtual ICollection<PlanesMaster> PlanesMasters { get; set; } = new List<PlanesMaster>();
}
