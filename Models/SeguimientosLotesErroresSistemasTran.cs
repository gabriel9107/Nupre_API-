using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los errores de sistemas relacionados con cada con los procesos de las cargas de los esquemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosLotesErroresSistemasTran
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
    /// Secuencia para identifica cuando en una Línea del sistema (Aplicación) relacionada con  el error de sistema generado en un proceso de carga de esquema, se producen más de un error.
    /// </summary>
    public byte ErrorSistemaSecuencia { get; set; }

    /// <summary>
    /// Describe el detalle de error de sistema generado en un proceso de carga de esquema.
    /// </summary>
    public string ErrorSistemaDetalle { get; set; } = null!;

    /// <summary>
    /// Línea del sistema (Aplicación) relacionada con  el error de sistema generado en un proceso de carga de esquema.
    /// </summary>
    public int ErrorSistemaLinea { get; set; }

    /// <summary>
    /// Fecha en que sucedió el error de sistema generado en un proceso de carga de esquema.
    /// </summary>
    public DateTime ErrorSistemaFecha { get; set; }

    /// <summary>
    /// Detalle que clasifica la tipología del  error de sistema generado en un proceso de carga de esquema.
    /// </summary>
    public string ErrorSistemaTipo { get; set; } = null!;

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

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
