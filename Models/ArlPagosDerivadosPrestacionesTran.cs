using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, que contiene los detalles de las prestaciones en especies  reportadas por  la ARL,  su fuente de datos es el esquema 54 procesado por el Robot Simon. 
/// </summary>
public partial class ArlPagosDerivadosPrestacionesTran
{
    /// <summary>
    /// Periodo (Año y Mes) correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Para reportar el número de expediente dado por la ARLSS.
    /// </summary>
    public long ExpedienteArlNumero { get; set; }

    /// <summary>
    /// Para reportar el número de la reclamación asignado por la ARLSS.
    /// </summary>
    public long ReclamacionNumero { get; set; }

    /// <summary>
    /// Para reportar la fecha en que se realizo el pago. Contendrá el siguiente formato DDMMYYYY.
    /// </summary>
    public DateTime PagoFecha { get; set; }

    /// <summary>
    /// Vía del Pago TB = Transferencia Bancaria, CK = Cheque.
    /// </summary>
    public string PagoViaCodigo { get; set; } = null!;

    /// <summary>
    /// Número único asignado por la ARL a cada solicitud de pago. Reportar en cero en caso de no tenerlo.
    /// </summary>
    public long SolicitudPagoNumero { get; set; }

    /// <summary>
    /// Monto pagado por la ARL al beneficiario. (Utilice 9999999.99 para cuando tenga decimales y/o 9999999.00 cuando no tenga decimales). 
    /// </summary>
    public decimal MontoPagado { get; set; }

    /// <summary>
    /// Código del procedimiento Medico, Según codificación CIE-09, en caso de no tener la información, reportar en cero, Ej.: 0000000000.
    /// </summary>
    public string Cie09Codigo { get; set; } = null!;

    /// <summary>
    /// Número de identificación de la transacción del pago. En caso de que la vía de pago  sea igual a CK, será requerido Número de Cheque, caso contrario reportar en cero.
    /// </summary>
    public long DocumentoPagoNumero { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public int SeguimientoLote { get; set; }

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
