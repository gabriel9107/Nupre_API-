using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las preguntas de los exámenes en las actividades de evaluación de los procesos de acreditación, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesExamenesDetallesTran
{
    /// <summary>
    /// Número único que identifica cada examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public short ExamenNumero { get; set; }

    /// <summary>
    /// Número único que identifica cada pregunta del banco de preguntas que puede ser utilizado en los exámenes  de acreditación.
    /// </summary>
    public short PreguntaNumero { get; set; }

    /// <summary>
    /// Repuesta dada por la persona a la pregunta de un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public string ExamenRespuesta { get; set; } = null!;

    /// <summary>
    /// Secuencia única de cada pregunta de un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public byte ExamenPreguntaSecuencia { get; set; }

    /// <summary>
    /// Valor de la repuesta correcta de una pregunta de un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public decimal ExamenPuntuacion { get; set; }

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

    public virtual AcreditacionesExamenesTran ExamenNumeroNavigation { get; set; } = null!;

    public virtual AcreditacionesPreguntasCatum PreguntaNumeroNavigation { get; set; } = null!;
}
