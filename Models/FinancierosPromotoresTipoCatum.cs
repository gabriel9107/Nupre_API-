using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class FinancierosPromotoresTipoCatum
{
    /// <summary>
    /// Número único que identifica el tipo de promotor.
    /// </summary>
    public byte PromotorTipoNumero { get; set; }

    /// <summary>
    /// Código que identifica si el promotor es Físico = F (Persona) o Moral  = M (Empresa).
    /// </summary>
    public string PromotorTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del tipo de promotor.
    /// </summary>
    public string PromotorTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación del tipo de promotor.
    /// </summary>
    public string PromotorTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<FinancierosPagosComisionesTran> FinancierosPagosComisionesTrans { get; set; } = new List<FinancierosPagosComisionesTran>();
}
