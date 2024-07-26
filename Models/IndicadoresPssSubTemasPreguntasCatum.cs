using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los detalles  los indicadores  (Preguntas realizadas en las visitas de evaluación de las PSS contratadas por las ARS) según subtemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class IndicadoresPssSubTemasPreguntasCatum
{
    /// <summary>
    /// Número único de cada pregunta (Indicador) que se utiliza en los procesos de visitas de supervisión que se realiza a una  prestadora  de servicio de salud de categoría institucional.
    /// </summary>
    public short IndicadorNumero { get; set; }

    /// <summary>
    /// Es el detalle de las preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional.
    /// </summary>
    public string IndicadorDescripcion { get; set; } = null!;

    /// <summary>
    /// Es el tipo de preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional, CT = Cuantitativo, Cl=Cualitativo y DS=Desarrollo.
    /// </summary>
    public byte IndicadorTipoNumero { get; set; }

    /// <summary>
    /// Es el número único de cada uno de los subtemas que agrupan las preguntas (Indicadores) que se utiliza en los procesos de visitas de supervisión que se realizan a las prestadoras  de servicios de salud de categoría institucional.
    /// </summary>
    public byte IndicadorSubTemaNumero { get; set; }

    /// <summary>
    /// Indica de cual indicador depende, tomado del levantamiento realizado por la DARS.
    /// </summary>
    public int IndicadorDependencia { get; set; }

    /// <summary>
    /// Indica de cual indicador es el padre (Referencia Única),  tomado del levantamiento realizado por la DARS.
    /// </summary>
    public int IndicadorReferenciaPadre { get; set; }

    /// <summary>
    /// Indica cual es la referencia única del indicador, tomado del levantamiento realizado por la DARS.
    /// </summary>
    public int IndicadorReferenciaUnico { get; set; }

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

    public virtual IndicadoresPssSubTemasCatum IndicadorSubTemaNumeroNavigation { get; set; } = null!;

    public virtual IndicadoresPssTipoCatum IndicadorTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<IndicadoresPssTipoPreguntasCatum> IndicadoresPssTipoPreguntasCata { get; set; } = new List<IndicadoresPssTipoPreguntasCatum>();
}
