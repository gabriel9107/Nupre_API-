using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los datos de cada uno de los pasos y actividades que se ejecutan en los procedimientos de los procesos de las cargas de los esquemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosProcedimientosLogTran
{
    /// <summary>
    /// Secuencia única asignada a cada log generado por la actividad de un procedimiento.
    /// </summary>
    public long LogSecuencia { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Es la secuencia del evento de carga de un esquema donde se encontró el error.
    /// </summary>
    public byte EventoSecuencia { get; set; }

    /// <summary>
    /// Fecha en que inicio la actividad del procedimiento que generó el log.
    /// </summary>
    public DateTime LogFechaInicio { get; set; }

    /// <summary>
    /// Fecha en que termino la actividad del procedimiento que generó el log.
    /// </summary>
    public DateTime? LogFechaFin { get; set; }

    /// <summary>
    /// Número único del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema.
    /// </summary>
    public short ErrorNumero { get; set; }

    /// <summary>
    /// Nombre del procedimiento donde se ejecuta la actividad que generó el log.
    /// </summary>
    public string LogProcedimiento { get; set; } = null!;

    /// <summary>
    /// Duración en segundos de la actividad del procedimiento que generó el log.
    /// </summary>
    public short LogSegundos { get; set; }

    /// <summary>
    /// Duración en minutos de la actividad del procedimiento que generó el log.
    /// </summary>
    public int LogMinutos { get; set; }

    /// <summary>
    /// Detalles relacionados con las especificaciones (Campo, Paso) de la actividad del procedimiento que generó el log.
    /// </summary>
    public string LogObservacion { get; set; } = null!;

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

    public virtual SeguimientosLotesErroresCatum ErrorNumeroNavigation { get; set; } = null!;
}
