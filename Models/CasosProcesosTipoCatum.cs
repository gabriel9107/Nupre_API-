using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CasosProcesosTipoCatum
{
    /// <summary>
    /// Número que indica el tipo de proceso ante determinada actividad.
    /// </summary>
    public byte CasoProcesoTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de proceso ante determinada actividad.
    /// </summary>
    public string CasoProcesoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del tipo de proceso ante determinada actividad.
    /// </summary>
    public string CasoProcesoTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<CasosActividadesTipoCatum> CasosActividadesTipoCata { get; set; } = new List<CasosActividadesTipoCatum>();
}
