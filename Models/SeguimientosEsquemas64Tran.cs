using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas64Tran
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
    /// Número único asignado a cada registro del archivo temporal de una carga de esquema especifica (Seguimiento + Lote).
    /// </summary>
    public long ArchivoLinea { get; set; }

    /// <summary>
    /// Para reportar el número de reclamación asignado por la ARLSS.
    /// </summary>
    public string NumeroReclamacion { get; set; } = null!;

    /// <summary>
    /// Para reportar el número de expediente dado por la ARL SS.
    /// </summary>
    public string NumeroExpedienteArl { get; set; } = null!;

    /// <summary>
    /// Número único asignado por la ARL a cada solicitud de pago. Reportar en cero en caso de no tenerlo.
    /// </summary>
    public string NumeroSolicitudPago { get; set; } = null!;

    /// <summary>
    /// Monto pagado por la ARL al beneficiario. (Utilice 9999999.99 para cuando tenga decimales y/o 9999999.00 cuando no tenga decimales). 
    /// </summary>
    public string MontoPagado { get; set; } = null!;

    /// <summary>
    /// Para reportar la fecha en que se realizo el pago. Contendrá el siguiente formato DDMMYYYY.
    /// </summary>
    public string FechaPago { get; set; } = null!;

    /// <summary>
    /// Código del procedimiento Medico, Según codificación CIE-09, en caso de no tener la información, reportar en cero, Ej.: 0000000000.
    /// </summary>
    public string ProcedimientoMedicoPagado { get; set; } = null!;

    /// <summary>
    /// Para especificar si el pago fue TB = Transferencia Bancaria o CK = Cheque.
    /// </summary>
    public string ViaPago { get; set; } = null!;

    /// <summary>
    /// Número de identificación de la transacción del pago. En caso de que la vía de pago  sea igual a CK, será requerido Número de Cheque, caso contrario reporta en cero.
    /// </summary>
    public string NumeroDocumentoPago { get; set; } = null!;

    /// <summary>
    /// OK = Activo, RE = Rechazado.
    /// </summary>
    public string RegistroValidacionEstado { get; set; } = null!;

    /// <summary>
    /// Número que identifica los posibles errores reportados.
    /// </summary>
    public string RegistroValidacionErrores { get; set; } = null!;

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
