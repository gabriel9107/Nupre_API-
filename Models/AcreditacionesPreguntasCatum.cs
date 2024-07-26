using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un  catálogo donde se registran las diferentes preguntas disponibles para generar  los  exámenes de evaluación en un proceso de acreditación.
/// </summary>
public partial class AcreditacionesPreguntasCatum
{
    /// <summary>
    /// Número único que identifica cada pregunta del banco de preguntas que puede ser utilizado en los exámenes  de acreditación.
    /// </summary>
    public short PreguntaNumero { get; set; }

    /// <summary>
    /// Número único que identifica la categoría de acreditación a ser otorgada (Auditor, Promotor, Promotora, Firma Auditoria etc.).
    /// </summary>
    public byte AcreditacionCategoriaNumero { get; set; }

    /// <summary>
    /// Detalles de cada pregunta del banco de preguntas que puede ser utilizado en los exámenes  de acreditación.
    /// </summary>
    public string PreguntaDescripcion { get; set; } = null!;

    /// <summary>
    /// Respuesta de cada pregunta del banco de preguntas que puede ser utilizado en los exámenes de acreditación.(ascii(convert(char(1),’Carácter A,B,C,D,E,F,G ‘ ))+ Pregunta_Numero)* (Un factor  ejp.: 123).
    /// </summary>
    public string PreguntaRespuesta { get; set; } = null!;

    /// <summary>
    /// Valoración asignada a cada pregunta del banco de preguntas que puede ser utilizado en los exámenes  de acreditación.
    /// </summary>
    public decimal PreguntaPuntuacion { get; set; }

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

    public virtual AcreditacionesCategoriasCatum AcreditacionCategoriaNumeroNavigation { get; set; } = null!;

    public virtual ICollection<AcreditacionesExamenesDetallesTran> AcreditacionesExamenesDetallesTrans { get; set; } = new List<AcreditacionesExamenesDetallesTran>();
}
