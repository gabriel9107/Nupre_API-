using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosNovedadesTipoCatum
{
    /// <summary>
    /// Código del tipo de novedad
    /// </summary>
    public string NovedadTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripcion del tipo de novedad
    /// </summary>
    public string NovedadTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Estado del registro A= Activo, I= Inactivo
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Usuario del registro
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// fecha del registro
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<TssPensionadosNovedadesTran> TssPensionadosNovedadesTrans { get; set; } = new List<TssPensionadosNovedadesTran>();
}
