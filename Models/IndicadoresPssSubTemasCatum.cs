using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles  de los sub temas relacionados con los indicadores  (Preguntas realizadas en las visitas de evaluación de las PSS contratadas por las ARS) según temas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class IndicadoresPssSubTemasCatum
{
    /// <summary>
    /// Es el número único de cada uno de los subtemas que agrupan las preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional.
    /// </summary>
    public byte IndicadorSubTemaNumero { get; set; }

    /// <summary>
    /// Es la descripción de cada uno de los subtemas que agrupan las preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional.
    /// </summary>
    public string IndicadorSubTemaDescripcion { get; set; } = null!;

    /// <summary>
    /// Es el número único de cada tema que agrupan las preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional.
    /// </summary>
    public byte IndicadorTemaNumero { get; set; }

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

    public virtual IndicadoresPssTemasCatum IndicadorTemaNumeroNavigation { get; set; } = null!;

    public virtual ICollection<IndicadoresPssSubTemasPreguntasCatum> IndicadoresPssSubTemasPreguntasCata { get; set; } = new List<IndicadoresPssSubTemasPreguntasCatum>();
}
