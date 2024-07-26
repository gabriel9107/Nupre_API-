using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, donde se almacenan los resumenes de errores de los esquemas de las ARS arrojados durante la validación, los cuales son procesado por el Robot Simon
/// </summary>
public partial class SeguimientosLotesErroresResumenesTran
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
    /// Número único del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema o de la solicitud de un traspaso.
    /// </summary>
    public short ErrorNumero { get; set; }

    /// <summary>
    /// Descripción del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema o de la solicitud de un traspaso.
    /// </summary>
    public string ErrorDescripcion { get; set; } = null!;

    /// <summary>
    /// Cantidad de Errores encontrados en la carga realizada por las ARS.
    /// </summary>
    public int CantidadErrores { get; set; }

    /// <summary>
    /// Detalle relacionado con la columna (Campo) de la estructura de datos del esquema o el proceso, donde  se encontró un error,  en un proceso de carga de esquema.
    /// </summary>
    public string EventoCampoError { get; set; } = null!;
}
