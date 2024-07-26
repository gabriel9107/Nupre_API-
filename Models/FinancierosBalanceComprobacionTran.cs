using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, que contiene los detalles de los balances de las cuentas de la balanza de comprobación reportados por las ARS y la ARL,  su fuente de datos es el esquema 05 procesado por el Robot Simon. 
/// </summary>
public partial class FinancierosBalanceComprobacionTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaCodigo { get; set; }

    /// <summary>
    /// Es el balance anterior que tiene la cuenta para el periodo reportado en el esquema 5, en el cual se informa la Balanza de comprobación.
    /// </summary>
    public decimal BalanceAnterior { get; set; }

    /// <summary>
    /// Es el balance en la columna de los Débitos que tienen  la cuenta para el período reportado en el esquema 5, en el cual se informa la Balanza de comprobación.
    /// </summary>
    public decimal BalanceDebito { get; set; }

    /// <summary>
    /// Es el balance en la columna de los créditos que tienen  la cuenta para el período reportado en el esquema 5, en el cual se informa la Balanza de comprobación.
    /// </summary>
    public decimal BalanceCredito { get; set; }

    /// <summary>
    /// Es el balance actual que tiene la cuenta para el periodo reportado en el esquema 5, en el cual se informa la Balanza de comprobación.
    /// </summary>
    public decimal BalanceActual { get; set; }

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

    public virtual FinancierosCuentasCatum CuentaCodigoNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
