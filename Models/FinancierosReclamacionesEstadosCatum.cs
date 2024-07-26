using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla catálogo que contiene los estados de las reclamaciones o autorizaciones al momento de ser reportada.
/// </summary>
public partial class FinancierosReclamacionesEstadosCatum
{
    /// <summary>
    /// Estado en que se encuentran cada una de  las autorizaciones al momento de ser reportada en el esquema. Al corte del período correspondiente.
    /// </summary>
    public byte ReclamacionEstadoNumero { get; set; }

    /// <summary>
    /// Código que representa el estado de la reclamación o autorización al momento de ser reportada y estas pueden ser: 01:AU (Autorizadas) , 02:RE (Reclamada) 03:PA (Pagada), 04:RP (Reaperturada) ,05:NU (Nula) .
    /// </summary>
    public string ReclamacionEstadoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del estado de la reclamación reportada.
    /// </summary>
    public string ReclamacionEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación del estado de la reclamación reportada.
    /// </summary>
    public string ReclamacionEstadoExplicacion { get; set; } = null!;

    /// <summary>
    /// Indica si estado si de la reclamación se validará el número de Prestadora de Servicios de Salud.
    /// </summary>
    public string ReclamacionEstadoValidarPss { get; set; } = null!;

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public long CuentaCodigo { get; set; }

    /// <summary>
    /// Es el código único que representa cada cuenta contable en el catálogo de cuentas.
    /// </summary>
    public string CuentaCodigoBalance { get; set; } = null!;

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
