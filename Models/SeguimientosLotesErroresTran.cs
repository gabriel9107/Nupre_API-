using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los datos  los  errores relacionados con cada uno de los pasos y actividades que se ejecutan en  los procesos de las cargas de los esquemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosLotesErroresTran
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
    /// Es la secuencia del evento de carga de un esquema donde se encontró el error.
    /// </summary>
    public byte EventoSecuencia { get; set; }

    /// <summary>
    /// Es una secuencia única para identificar la transacción con el objetivo de optimizar las funcionalidades de la tabla.
    /// </summary>
    public long ErrorSecuencia { get; set; }

    /// <summary>
    /// Número único asignado a cada registro del archivo temporal de una carga de esquema especifica (Seguimiento + Lote).
    /// </summary>
    public long ArchivoLinea { get; set; }

    /// <summary>
    /// Número único del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema.
    /// </summary>
    public short ErrorNumero { get; set; }

    /// <summary>
    /// Detalle relacionado con la columna (Campo) de la estructura de datos del esquema o el proceso, donde  se encontró un error,  en un proceso de carga de esquema.
    /// </summary>
    public string EventoCampoError { get; set; } = null!;

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
}
