using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresPreguntasCatum
{
    /// <summary>
    /// Número único que identifica cada pregunta del banco de preguntas que puede ser utilizado en los exámenes  de acreditación.
    /// </summary>
    public short PreguntaNumero { get; set; }

    /// <summary>
    /// Detalles de cada pregunta del banco de preguntas que puede ser utilizado en los exámenes  de acreditación.
    /// </summary>
    public string PreguntaDescripcion { get; set; } = null!;

    public string PreguntaObservacion { get; set; } = null!;

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

    public virtual ICollection<AuditoresExamenesDetallesTran> AuditoresExamenesDetallesTrans { get; set; } = new List<AuditoresExamenesDetallesTran>();

    public virtual ICollection<AuditoresPreguntasHistorico> AuditoresPreguntasHistoricos { get; set; } = new List<AuditoresPreguntasHistorico>();

    public virtual ICollection<AuditoresPreguntasRespuestasCatum> AuditoresPreguntasRespuestasCata { get; set; } = new List<AuditoresPreguntasRespuestasCatum>();
}
