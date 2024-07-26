using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los clasificaciones de las actividades económicas de los empleadores, su fuente de datos la vista de publicadas por TSS, codificación de la DGII.
/// </summary>
public partial class TssActividadesEconomicasCatum
{
    /// <summary>
    /// Número único que identifica la actividad económica del catálogo de actividades económicas con la que se clasifican los empleadores.
    /// </summary>
    public int ActividadEconomicaNumero { get; set; }

    /// <summary>
    /// Descripción de la actividad económica del catálogo de actividades económicas con la que se clasifican los empleadores.
    /// </summary>
    public string ActividadEconomicaDescripcion { get; set; } = null!;

    /// <summary>
    /// Salario mínimo especificado para una actividad económica, dentro de catálogo de actividades económicas con la que se clasifican los empleadores. 
    /// </summary>
    public decimal ActividadEconomicaSalarioMinimo { get; set; }

    /// <summary>
    /// Código de clasificación internacional industrial uniforme de la división de estadísticas de la ONU,  equivalente a la actividad económica del catálogo de actividades económicas con la que se clasifican los empleadores.
    /// </summary>
    public string CiiuCodigo { get; set; } = null!;

    /// <summary>
    /// Códigos de clasificación internacional industrial uniforme de la división de estad¡sticas de la ONU,  dentro de catálogo de actividades económicas con la que se clasifican los empleadores, varios Código CIIU para  una misma actividad económica.
    /// </summary>
    public string CiiuCodigoVarios { get; set; } = null!;

    /// <summary>
    /// Categor¡a de riesgo asignada por el SDSS a cada actividad económica, dentro de catálogo de actividades económicas con la que se clasifican los empleadores.
    /// </summary>
    public string ActividadEconomicaCategoriaRiesgo { get; set; } = null!;

    /// <summary>
    /// Código de la clase a la que corresponde el código CIIU clasificación internacional industrial uniforme de la división de estadísticas de la ONU, dentro de catálogo de actividades económicas con la que se clasifican los empleadores.
    /// </summary>
    public string CiiuClaseCodigo { get; set; } = null!;

    /// <summary>
    /// Código del grupo al que pertenece el código CIIU,  clasificación internacional industrial uniforme de la división de estadísticas de la ONU, dentro de catálogo de actividades económicas con la que se clasifican los empleadores.
    /// </summary>
    public byte CiiuGrupoNumero { get; set; }

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

    public virtual ComunesCiiuClasesCatum CiiuClaseCodigoNavigation { get; set; } = null!;

    public virtual ComunesCiiuGruposCatum CiiuGrupoNumeroNavigation { get; set; } = null!;
}
