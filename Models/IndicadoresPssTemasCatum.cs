using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles  de los temas relacionados con los indicadores  (Preguntas realizadas en las visitas de evaluación de las PSS contratadas por las ARS), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class IndicadoresPssTemasCatum
{
    /// <summary>
    /// Es el número único de cada tema que agrupan las preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional.
    /// </summary>
    public byte IndicadorTemaNumero { get; set; }

    /// <summary>
    /// Es la descripción de los temas que agrupan las preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional.
    /// </summary>
    public string IndicadorTemaDescripcion { get; set; } = null!;

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

    public virtual ICollection<IndicadoresPssSubTemasCatum> IndicadoresPssSubTemasCata { get; set; } = new List<IndicadoresPssSubTemasCatum>();
}
