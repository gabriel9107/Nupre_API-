using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional, que contiene los detalles de las prestaciones económicas pagadas  y reportados por  la ARL,  su fuente de datos es el esquema 53 procesado por el Robot Simon. 
/// </summary>
public partial class ArlPrestacionesEconomicasTran
{
    /// <summary>
    /// Número de secuencia generado por cada transacción.
    /// </summary>
    public int PrestacionSecuencia { get; set; }

    /// <summary>
    /// Número de Cédula del trabajador asignada por la Junta Central Electoral.
    /// </summary>
    public string TrabajadorCedula { get; set; } = null!;

    /// <summary>
    /// Es el número de expediente reportado por la ARLSS.
    /// </summary>
    public long ExpedienteArlNumero { get; set; }

    /// <summary>
    /// Número de Cédula del beneficiario asignada por la Junta Central Electoral.
    /// </summary>
    public string BeneficiarioCedula { get; set; } = null!;

    /// <summary>
    /// Es el Registro Nacional de Contribuyente de la Empresa que reportó al trabajador.
    /// </summary>
    public string EmpleadorRncOCedula { get; set; } = null!;

    /// <summary>
    /// Es el salario del trabajador, notificado por el SUIR en base al monto calculado.
    /// </summary>
    public decimal PrestacionSalarioSuirCalculado { get; set; }

    /// <summary>
    /// Código del tipo de prestación.
    /// </summary>
    public byte PrestacionTipoNumero { get; set; }

    /// <summary>
    /// Es el monto calculado de la prestación económica por mes que se le va a pagar al trabajador.
    /// </summary>
    public decimal PrestacionMontoCalculado { get; set; }

    /// <summary>
    /// Fecha en que se comenzó a pagarle al trabajador.
    /// </summary>
    public DateTime PrestacionInicioPagoFecha { get; set; }

    /// <summary>
    /// Es el primer monto pagado por la ARL, al trabajador.
    /// </summary>
    public decimal PrestacionMontoPrimerPago { get; set; }

    /// <summary>
    /// Cantidad de pagos retroactivos acumulados y pagados realizado al trabajador que se está reportando.
    /// </summary>
    public byte PrestacionCantidadPagosRetroactivos { get; set; }

    /// <summary>
    /// Monto retroactivo pagado por la ARL al trabajador.
    /// </summary>
    public decimal PrestacionMontoRetroactivo { get; set; }

    /// <summary>
    /// Fecha en que se pronostica que se realizará el último pago del trabajador.
    /// </summary>
    public DateTime PrestacionUltimoPagoFecha { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

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

    public virtual ArlPrestacionesTipoCatum PrestacionTipoNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
