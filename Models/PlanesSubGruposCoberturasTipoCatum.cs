using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles de los tipos de coberturas que aplican sobre subgrupos de servicios de salud  relacionados Planes de Servicios de Salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PlanesSubGruposCoberturasTipoCatum
{
    /// <summary>
    /// Es un número único que representa el tipo de cobertura del subgrupo, indica si el subgrupo  tiene una cobertura Gradual o Ilimitada.
    /// </summary>
    public byte SubGrupoCoberturaTipoNumero { get; set; }

    /// <summary>
    /// Es la descripción del tipo de cobertura del subgrupo, indica si el subgrupo  tiene una cobertura Gradual o Ilimitada.
    /// </summary>
    public string SubGrupoCoberturaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es una breve explicación de la descripción del tipo de cobertura del subgrupo.
    /// </summary>
    public string SubGrupoCoberturaTipoExplicacion { get; set; } = null!;

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
