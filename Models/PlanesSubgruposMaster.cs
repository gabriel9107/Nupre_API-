using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de los subgrupos de servicios de salud relacionados con cada uno de los Planes de Servicios de Salud según grupos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesSubgruposMaster
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
    /// Número único del Tipo de Cuota que aplica sobre el Subgrupo del PDSS, especifica si la cuota a aplicar es Moderadora Fija, Moderadora Variable, Copago  y No (No aplica cuota).  
    /// </summary>
    public byte SubGrupoCuotaTipoNumero { get; set; }

    /// <summary>
    /// Es un número único que representa el tipo de cobertura del subgrupo, indica si el subgrupo  tiene una cobertura Gradual o Ilimitada.
    /// </summary>
    public byte SubGrupoCoberturaTipoNumero { get; set; }

    /// <summary>
    /// Monto del Tope de consumo que aplica sobre el Subgrupo del PDSS.  
    /// </summary>
    public decimal SubGrupoCoberturaTope { get; set; }

    /// <summary>
    /// Porcentaje del monto a pagar que debe ser cubierto por la ARS para el Subgrupo del PDSS.
    /// </summary>
    public decimal SubgrupoCuotaArsPorciento { get; set; }

    /// <summary>
    /// Porcentaje del monto a pagar que debe ser cubierto por el Afiliado para el Subgrupo del PDSS.
    /// </summary>
    public decimal SubGrupoCuotaAfiliadoPorciento { get; set; }

    /// <summary>
    /// Monto fijo a pagar que debe ser cubierto por el Afiliado para el Subgrupo del PDSS.
    /// </summary>
    public decimal SubGrupoCuotaAfiliadoFija { get; set; }

    /// <summary>
    /// Monto Máximo a pagar que debe ser cubierto por el Afiliado para el Subgrupo del PDSS.
    /// </summary>
    public decimal SubGrupoCuotaAfiliadoTope { get; set; }

    /// <summary>
    /// Identifica el número de Plan de cual se tomo la información para este plan.
    /// </summary>
    public string PlanNumeroOrigen { get; set; } = null!;

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

    public virtual PlanesMaster PlanNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PlanesCoberturasMaster> PlanesCoberturasMasters { get; set; } = new List<PlanesCoberturasMaster>();

    public virtual PlanesSubGruposCoberturasTipoCatum SubGrupoCoberturaTipoNumeroNavigation { get; set; } = null!;

    public virtual PlanesSubGruposCuotasTipoCatum SubGrupoCuotaTipoNumeroNavigation { get; set; } = null!;

    public virtual SubGruposCatum SubGruposCatum { get; set; } = null!;
}
