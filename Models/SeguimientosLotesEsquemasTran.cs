using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, donde se almacenan los detalle de errores de los esquemas de las ARS arrojados durante la validación, los cuales son procesado por el Robot Simon
/// </summary>
public partial class SeguimientosLotesEsquemasTran
{
    /// <summary>
    /// Número único que representa cada  esquema.
    /// </summary>
    public byte EsquemaNumero { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Periodo (Año y Mes) correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Cantidad de registros (líneas) procesados en un  proceso de una carga de esquema de un lote.
    /// </summary>
    public int SeguimientoLoteRegistros { get; set; }

    /// <summary>
    /// Indica el estado del Seguimiento Lote (OK = Procesado, NU = Nuevos, AC = Actualizar) de las cargas procesados de los esquemas cargados por las ARS.
    /// </summary>
    public string SeguimientoLoteEstado { get; set; } = null!;
}
