using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, donde se almacenan los eventos de las cargas realizadas por los esquemas de las ARS, donde se calcula cantidad de registros y duracion de cada carga en sus diferentes eventos, estas cargas son procesado por el Robot Simon
/// </summary>
public partial class SeguimientosLotesEventosIndicadoresTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Mes correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoPeriodoMes { get; set; }

    /// <summary>
    /// Número único que representa cada  esquema.
    /// </summary>
    public byte EsquemaNumero { get; set; }

    /// <summary>
    /// Fecha en la que inicio un evento en el proceso de una carga de esquema.
    /// </summary>
    public DateTime EventoFechaInicio { get; set; }

    /// <summary>
    /// Fecha en la que finalizo un evento en el proceso de una carga de esquema.
    /// </summary>
    public DateTime EventoFechaFin { get; set; }

    /// <summary>
    /// Es la secuencia del evento de carga de un esquema donde se encontró el error.
    /// </summary>
    public byte EventoSecuencia { get; set; }

    /// <summary>
    /// Número único que representa cada evento que forma parte del proceso de una carga de esquema.
    /// </summary>
    public byte EventoTipoNumero { get; set; }

    /// <summary>
    /// Descripción de  cada evento que forma parte del proceso de una carga de esquema.
    /// </summary>
    public string EventoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Cantidad total de Minutos durante el evento en el proceso de una carga de esquema.
    /// </summary>
    public int EventoMinutos { get; set; }

    /// <summary>
    /// Cantidad de registros (líneas) procesados en un  proceso de una carga de esquema de un lote.
    /// </summary>
    public int SeguimientoLoteRegistros { get; set; }

    /// <summary>
    /// Año en que inició el un evento en el proceso de una carga de esquema.
    /// </summary>
    public int EventoInicioAno { get; set; }

    /// <summary>
    /// Mes en que inició el un evento en el proceso de una carga de esquema.
    /// </summary>
    public int EventoInicioMes { get; set; }
}
