using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas05Tran
{
    /// <summary>
    /// Código del seguimiento de la carga
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número de seguimiento del lote de carga
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Número que indetifica la lineas de errores del archivo
    /// </summary>
    public long ArchivoLinea { get; set; }

    /// <summary>
    /// Número de seguimiento del lote de carga
    /// </summary>
    public int InstitucionNumero { get; set; }

    /// <summary>
    /// Indica el Numero de la Cuenta Contable.
    /// </summary>
    public string CuentaCodigo { get; set; } = null!;

    /// <summary>
    /// Indica el Balance de la  fecha  anterior a la actual en la cuenta. (Debe enviarse los montos con formato en decimal. Así : 00000000000000000.00 y en caso que el monto se negativo debe enviar así: -0000000000000000.00) .
    /// </summary>
    public string BalanceAnterior { get; set; } = null!;

    /// <summary>
    /// Indica el monto a la Fecha en la cuenta, lado Debito. (Debe enviarse los montos con formato en decimal. Así : 00000000000000000.00).
    /// </summary>
    public string BalanceDebito { get; set; } = null!;

    /// <summary>
    /// Indica el monto a la Fecha en la cuenta, lado Crédito. (Debe enviarse los montos con formato en decimal. Así : 00000000000000000.00).
    /// </summary>
    public string BalanceCredito { get; set; } = null!;

    /// <summary>
    /// Indica el Balance Actual a la Fecha en la cuenta (Balance Anterior + Debito - Crédito). (Debe enviarse los montos con formato en decimal. Así : 00000000000000000.00 y en caso que el monto se negativo debe enviar así: -0000000000000000.00 ).
    /// </summary>
    public string BalanceActual { get; set; } = null!;

    /// <summary>
    /// OK = Activo, RE = Rechazado.
    /// </summary>
    public string RegistroValidacionEstado { get; set; } = null!;

    /// <summary>
    /// Número que identifica los posibles errores reportados
    /// </summary>
    public string RegistroValidacionErrores { get; set; } = null!;

    /// <summary>
    /// A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }
}
