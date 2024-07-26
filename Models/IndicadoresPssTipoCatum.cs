using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los  tipo de indicadores  (Preguntas realizadas en las visitas de evaluación de las PSS contratadas por las ARS), los clasifican en función del valor que pueden recibir, su fuente de datos son los sistemas internos de la SISAL
/// </summary>
public partial class IndicadoresPssTipoCatum
{
    /// <summary>
    /// Es el tipo de preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional, CT = Cuantitativo, Cl=Cualitativo y DS=Desarrollo.
    /// </summary>
    public byte IndicadorTipoNumero { get; set; }

    /// <summary>
    /// Es el tipo de preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional, CT = Cuantitativo, Cl=Cualitativo y DS=Desarrollo.
    /// </summary>
    public string IndicadorTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripcióon del tipo de preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional, CT = Cuantitativo, Cl=Cualitativo y DS=Desarrollo.
    /// </summary>
    public string IndicadorTipoDescripcion { get; set; } = null!;

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

    public virtual ICollection<IndicadoresPssSubTemasPreguntasCatum> IndicadoresPssSubTemasPreguntasCata { get; set; } = new List<IndicadoresPssSubTemasPreguntasCatum>();
}
