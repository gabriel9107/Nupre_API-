using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los grupos de los CIIU, código industrial internacional unificado, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesCiiuGruposCatum
{
    /// <summary>
    /// Código del grupo al que pertenece el código CIIU,  clasificación internacional industrial uniforme de la división de estadísticas de la ONU, dentro de catálogo de actividades económicas con la que se clasifican los empleadores.
    /// </summary>
    public byte CiiuGrupoNumero { get; set; }

    /// <summary>
    /// Descripción del grupo al que pertenece el código CIIU,  clasificación internacional industrial uniforme de la división de estadísticas de la ONU, dentro de catálogo de actividades económicas con la que se clasifican los empleadores.
    /// </summary>
    public string CiiuGrupoDescripcion { get; set; } = null!;

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    public virtual ICollection<TssActividadesEconomicasCatum> TssActividadesEconomicasCata { get; set; } = new List<TssActividadesEconomicasCatum>();
}
