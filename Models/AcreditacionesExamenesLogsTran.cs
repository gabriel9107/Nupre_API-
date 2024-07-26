using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los eventos relacionados con los exámenes en las actividades de evaluación de los procesos de acreditación, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesExamenesLogsTran
{
    /// <summary>
    /// Secuencia numérica única que identifica cada registro del log de cada examen. 
    /// </summary>
    public int ExamenLogSecuencia { get; set; }

    /// <summary>
    /// Número único que identifica cada examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public short ExamenNumero { get; set; }

    /// <summary>
    /// Usuario único generado  para cada usuario para un período de exámenes.
    /// </summary>
    public string PersonaPeriodoUsuario { get; set; } = null!;

    /// <summary>
    /// Calve única generada para cada usuario para un período de exámenes.
    /// </summary>
    public string PersonaPeriodoClave { get; set; } = null!;

    /// <summary>
    /// Fecha y hora en la cual el usuario inicio el llenado del examen.
    /// </summary>
    public DateTime ExamenLogFechaEntro { get; set; }

    /// <summary>
    /// Fecha y hora en la cual el usuario termino o se aborto el llenado del examen.
    /// </summary>
    public DateTime ExamenLogFechaSalio { get; set; }

    /// <summary>
    /// Nombre de la interface que utilizaba el usuario para el llenado del examen.
    /// </summary>
    public string ExamenLogInterface { get; set; } = null!;

    /// <summary>
    /// Número único del sistema de información.
    /// </summary>
    public short SistemaNumero { get; set; }

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

    public virtual SistemasMaster SistemaNumeroNavigation { get; set; } = null!;
}
