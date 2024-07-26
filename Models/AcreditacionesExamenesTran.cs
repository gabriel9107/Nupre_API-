using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los exámenes en las actividades de evaluación de los procesos de acreditación, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesExamenesTran
{
    /// <summary>
    /// Número único que identifica cada examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public short ExamenNumero { get; set; }

    /// <summary>
    /// Número único que identifica un período (Rango de fecha) en el cual se procedió a habilitar la toma de exámenes en las actividades de evaluación de los procesos de acreditación.
    /// </summary>
    public short PeriodoNumero { get; set; }

    /// <summary>
    /// Secuencia única asignada a cada persona en el sistema de acreditación.
    /// </summary>
    public long PersonaNss { get; set; }

    /// <summary>
    /// Fecha y hora en que inició una persona  un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public DateTime ExamenFechaInicio { get; set; }

    /// <summary>
    /// Fecha y hora en que terminó una persona  un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public DateTime ExamenFechaFinal { get; set; }

    /// <summary>
    /// Calificación numérica obtenido por la persona en un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public byte ExamenResultado { get; set; }

    /// <summary>
    /// Estado en que se encuentra (Iniciado o Finalizado)  un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public string ExamenEstado { get; set; } = null!;

    /// <summary>
    /// Número único de lote con el que se cargo la acreditación de un promotor de salud en UNIPAGO.
    /// </summary>
    public short PromotoresLotes { get; set; }

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

    public virtual ICollection<AcreditacionesExamenesDetallesTran> AcreditacionesExamenesDetallesTrans { get; set; } = new List<AcreditacionesExamenesDetallesTran>();

    public virtual ICollection<AcreditacionesExamenesLogsTran> AcreditacionesExamenesLogsTrans { get; set; } = new List<AcreditacionesExamenesLogsTran>();

    public virtual ICollection<AcreditacionesExamenesRecibosTran> AcreditacionesExamenesRecibosTrans { get; set; } = new List<AcreditacionesExamenesRecibosTran>();

    public virtual AcreditacionesPersonasPeriodosTran Per { get; set; } = null!;

    public virtual AcreditacionesPersonasMaster PersonaNssNavigation { get; set; } = null!;

    public virtual AcreditacionesPromotoresLotesTran PromotoresLotesNavigation { get; set; } = null!;
}
