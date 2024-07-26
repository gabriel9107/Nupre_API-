using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArlPagosPensionesSobrevivenciasTran
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
    /// Para reportar número de identificación y electoral del beneficiario.
    /// </summary>
    public string BeneficiarioCedula { get; set; } = null!;

    /// <summary>
    /// 1 = Conyugue, 2 =Tutor, 3 = Hijo Mayor.
    /// </summary>
    public byte BeneficiarioTipoNumero { get; set; }

    /// <summary>
    /// Para reportar la cantidad de beneficiarios.
    /// </summary>
    public byte BaneficiariosCantidad { get; set; }

    /// <summary>
    /// Código valido para reportar  el  tipo de Prestación. Solo reportar 4= Pensión Viudez. Y  5 = Pensión Orfandad.
    /// </summary>
    public byte PrestacionTipoNumero { get; set; }

    /// <summary>
    /// Para reportar el monto calculado de la prestación económica por mes que  se le va a pagar al trabajador. (Utilice 9999999.99 para cuando tenga decimales y/o 9999999.00 cuando no tenga decimales).
    /// </summary>
    public decimal PrestacionMonto { get; set; }

    /// <summary>
    /// Para reportar la fecha en que se realizo solicitud de la evaluación de la discapacidad formato  DDMMYYYY.
    /// </summary>
    public DateTime SolicitudFecha { get; set; }

    /// <summary>
    /// Para reportar la fecha en que se realizo el pago. Contendrá el siguiente formato DDMMYYYY.
    /// </summary>
    public DateTime PagoFecha { get; set; }

    /// <summary>
    /// Vía del Pago TB = Transferencia Bancaria, CK = Cheque.
    /// </summary>
    public string PagoViaCodigo { get; set; } = null!;

    /// <summary>
    /// Número de identificación de la transacción del pago. En caso de que la vía de pago  sea igual a CK, será requerido Número de Cheque, caso contrario reportar en cero.
    /// </summary>
    public long DocumentoPagoNumero { get; set; }

    /// <summary>
    /// Para especificar si el pago es 1= Retroactivo, 2 = Único, 3 =Pensión.
    /// </summary>
    public byte PagoTipoNumero { get; set; }

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
