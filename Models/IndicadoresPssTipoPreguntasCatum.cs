using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los indicadores  (Preguntas realizadas en las visitas de evaluación de las PSS) según el Tipo de prestadora de Salud PSS, estos conforman una versión de formulario de visitas, su fuente son los sistemas internos de la SISALRIL
/// </summary>
public partial class IndicadoresPssTipoPreguntasCatum
{
    /// <summary>
    /// Es un número único que identifica el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public byte PrestadoraTipoNumero { get; set; }

    /// <summary>
    /// Numero de versión de los formularios generados con las preguntas (Indicadores) que se utilizan en los procesos de visitas de supervisión que se realiza a una  prestadora  de servicio de salud de categoría institucional.
    /// </summary>
    public byte IndicadorVersionNumero { get; set; }

    /// <summary>
    /// Número único de cada pregunta (Indicador) que se utiliza en los procesos de visitas de supervisión que se realiza a una  prestadora  de servicio de salud de categoría institucional.
    /// </summary>
    public short IndicadorNumero { get; set; }

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

    public virtual IndicadoresPssSubTemasPreguntasCatum IndicadorNumeroNavigation { get; set; } = null!;

    public virtual ICollection<IndicadoresPssVisitasDetalleTran> IndicadoresPssVisitasDetalleTrans { get; set; } = new List<IndicadoresPssVisitasDetalleTran>();
}
