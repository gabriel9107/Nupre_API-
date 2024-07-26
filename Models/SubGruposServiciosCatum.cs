using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipos de servicios de salud y su relación con los subgrupos de servicios de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SubGruposServiciosCatum
{
    /// <summary>
    /// Número único asignado al servicio clínico, se refiere al servicio clínico bajo el cual se prestan  las coberturas de subgrupo del PDSS,  Especialidades básicas, Odontología,  Cirugía General etc.
    /// 
    /// </summary>
    public byte SubGrupoServicioNumero { get; set; }

    /// <summary>
    /// Descripción del  servicio clínico, se refiere al servicio clínico bajo el cual se prestan  las coberturas de subgrupo del PDSS,  Especialidades básicas, Odontología,  Cirugía General etc.
    /// </summary>
    public string SubGrupoServicioDescripcion { get; set; } = null!;

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

    public virtual ICollection<SubGruposCatum> SubGruposCata { get; set; } = new List<SubGruposCatum>();
}
