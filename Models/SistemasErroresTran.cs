using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran todo los errores generado por el Sistema Operativo en la ejecución de una aplicación,  su fuente de datos los sistemas internos de la SISALRIL.
/// </summary>
public partial class SistemasErroresTran
{
    /// <summary>
    /// Es una secuencia única para identificar la transacción con el objetivo de optimizar las funcionalidades de la tabla.
    /// </summary>
    public int ErrorSecuencia { get; set; }

    public string SistemaNombre { get; set; } = null!;

    /// <summary>
    /// Mensaje cortó generado por el Sistema Operativo en un error en la ejecución de una aplicación.
    /// </summary>
    public string ErrorMensajeCorto { get; set; } = null!;

    /// <summary>
    /// Detalle completo del  mensaje generado por el Sistema Operativo en un error en la ejecución de una aplicación.
    /// </summary>
    public string ErrorMensajeDetalle { get; set; } = null!;

    /// <summary>
    /// Origen del  mensaje generado por el Sistema Operativo en un error en la ejecución de una aplicación.
    /// </summary>
    public string ErrorOrigen { get; set; } = null!;

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
