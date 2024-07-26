using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo donde se registran la posible respuesta verdadera o falsa, con la que se relaciona unas preguntas de los exámenes en las actividades de evaluación de los procesos de acreditación, su fuente de datos sistemas internos de la SISALRIL.
/// </summary>
public partial class Selec
{
    public int PreguntaSecuencia { get; set; }

    /// <summary>
    /// Número único que identifica cada pregunta del banco de preguntas que puede ser utilizado en los exámenes  de acreditación.
    /// </summary>
    public short PreguntaNumero { get; set; }

    /// <summary>
    /// Es el código (Letra) con la que se puede responder una pregunta específica en un examen de evaluación en un proceso de acreditación.
    /// </summary>
    public string PreguntaRespuestaCodigo { get; set; } = null!;

    /// <summary>
    /// Es el código (Letra) con la que se puede responder una pregunta específica en un examen de evaluación en un proceso de acreditación.
    /// </summary>
    public string PreguntaRespuestaDescripcion { get; set; } = null!;

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
}
