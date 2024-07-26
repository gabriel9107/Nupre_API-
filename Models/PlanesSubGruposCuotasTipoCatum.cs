using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles de los tipos de cuotas que aplican sobre los subgrupos de servicios de salud  relacionados Planes de Servicios de Salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesSubGruposCuotasTipoCatum
{
    /// <summary>
    /// Número único del Tipo de Cuota que aplica sobre el Subgrupo del PDSS, especifica si la cuota a aplicar es Moderadora Fija, Moderadora Variable, Copago  y No (No aplica cuota).  
    /// </summary>
    public byte SubGrupoCuotaTipoNumero { get; set; }

    /// <summary>
    /// Descripción del Tipo de Cuota que aplica sobre el Subgrupo del PDSS, especifica si la cuota a aplicar es Moderadora Fija, Moderadora Variable, Copago  y No (No aplica cuota).  
    /// </summary>
    public string SubGrupoCuotaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es utilizado en los reportes para el formato y ubicación de la descripción del tipo de cuota de  los subgrupos.
    /// </summary>
    public int SubGrupoCuotaTipoReporte { get; set; }

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

    public virtual ICollection<PlanesSubgruposMaster> PlanesSubgruposMasters { get; set; } = new List<PlanesSubgruposMaster>();
}
