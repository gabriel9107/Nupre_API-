using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los recibos de resultados de los exámenes en las actividades de evaluación de los procesos de acreditación, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesExamenesRecibosTran
{
    /// <summary>
    /// Número único del recibo de resultado de un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public short ReciboNumero { get; set; }

    /// <summary>
    /// Número único que identifica cada examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public short ExamenNumero { get; set; }

    /// <summary>
    /// Fecha del recibo de resultado de un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public DateTime ReciboFecha { get; set; }

    /// <summary>
    /// Serial generado para un recibo de resultado de un examen en la actividad de evaluación de los procesos de acreditación.
    /// </summary>
    public string ReciboSerial { get; set; } = null!;

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
}
