using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class FinancierosPagosComisionesTemporalTran
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
    /// Número único con el que se identifica la Administradora de Riesgos de Salud ARS.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Número de cédula o RNC del promotor a cual se realizó el pago de la comisiones.
    /// </summary>
    public string PromotorRncOCedula { get; set; } = null!;

    /// <summary>
    /// Número único asignado a cada tipo de plan de salud.
    /// </summary>
    public byte PlanTipoNumero { get; set; }

    /// <summary>
    /// Número único del Tipo de Plan relacionado con el pago de las comisiones.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    /// <summary>
    /// Indica si el pago de la reclamación esta pagado (P) o cancelado (C)
    /// </summary>
    public string PagoEstado { get; set; } = null!;

    /// <summary>
    /// Número de cuenta o número único con el que se identifica de forma específica al promotor dentro del sistema de la ARS.
    /// </summary>
    public string PromotorNumero { get; set; } = null!;

    /// <summary>
    /// Nombre completo del promotor 
    /// </summary>
    public string PromotorNombre { get; set; } = null!;

    /// <summary>
    /// Indica si el promotor es 1 = Físico = F (Persona) o 2 = Moral  = M (Empresa).
    /// </summary>
    public string PromotorTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número de teléfono de contacto de promotor.
    /// </summary>
    public string PromotorTelefono { get; set; } = null!;

    /// <summary>
    /// Monto total pagado por comisiones a un promotor por un tipo de plan específico.
    /// </summary>
    public decimal PromotorMontoPagado { get; set; }

    /// <summary>
    /// Indica el periodo al que corresponde el pago de la reclamación cuando su estado es (C) 
    /// </summary>
    public int PagoPeriodo { get; set; }

    public string DocumentoPagoTipoCodigo { get; set; } = null!;

    public long DocumentoPagoNumero { get; set; }

    public DateTime PagoFecha { get; set; }

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
