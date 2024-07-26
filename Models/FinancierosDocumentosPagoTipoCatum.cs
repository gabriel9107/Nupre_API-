using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class FinancierosDocumentosPagoTipoCatum
{
    /// <summary>
    /// s el número de Cheque o transacción bancaria con la cual la ARS realizó el último pago a la PSS, por cada autorización reportada. Al corte del período correspondiente.
    /// </summary>
    public byte DocumentoPagoTipoNumero { get; set; }

    /// <summary>
    /// s el tipo de documento Cheque = CK o transacción bancaria = TR con el cual la ARS realizó el último pago a la PSS, por cada autorización reportada. Al corte del período correspondiente.
    /// </summary>
    public string DocumentoPagoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del tipo de documento Cheque = CK o transacción bancaria = TR con el cual la ARS realizó el último pago a la PSS, por cada autorización reportada. Al corte del período correspondiente.
    /// </summary>
    public string DocumentoPagoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicació del tipo de documento Cheque = CK o transacción bancaria = TR con el cual la ARS realizó el último pago a la PSS, por cada autorización reportada. Al corte del período correspondiente.
    /// </summary>
    public string DocumentoPagoTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<FinancierosReclamacionesArsTran> FinancierosReclamacionesArsTrans { get; set; } = new List<FinancierosReclamacionesArsTran>();
}
