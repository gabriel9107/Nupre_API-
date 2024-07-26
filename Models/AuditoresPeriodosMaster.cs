using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AuditoresPeriodosMaster
{
    /// <summary>
    /// Número único que identifica un período (Rango de fecha) en el cual se procedió a habilitar la toma de exámenes en las actividades de evaluación de los procesos de acreditación.
    /// </summary>
    public short PeriodoNumero { get; set; }

    /// <summary>
    /// Fecha en la que inicia un período específico de exámenes en los procesos de acreditación.
    /// </summary>
    public DateTime PeriodoFechaInicio { get; set; }

    /// <summary>
    /// Fecha en la que finaliza un período específico de exámenes en los procesos de acreditación.
    /// </summary>
    public DateTime? PeriodoFechaFinal { get; set; }

    /// <summary>
    /// Observación sobre un período específico de exámenes en los procesos de acreditación.
    /// </summary>
    public string PeriodoObservacion { get; set; } = null!;

    /// <summary>
    /// Estado en el que se encuentra un período específico de exámenes en los procesos de acreditación.
    /// </summary>
    public string PeriodoEstado { get; set; } = null!;

    /// <summary>
    /// Hora en la que debe iniciar un período específico de exámenes en los procesos de acreditación.
    /// </summary>
    public byte PeriodoHoraInicioExamen { get; set; }

    public byte ExamenPreguntas { get; set; }

    public byte ExamenPreguntasVencidos { get; set; }

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

    public virtual ICollection<AuditoresExamenesTran> AuditoresExamenesTrans { get; set; } = new List<AuditoresExamenesTran>();
}
