using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosNovedadesDetallesTipoCatum
{
    /// <summary>
    /// Codigo del tipo de  novedad
    /// </summary>
    public string NovedadDetalleTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del tipo de novedad
    /// </summary>
    public string NovedadDetalleTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Estado del registro A=Activo, I= Inactivo
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Usuario que modifico el registro
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de creacion o modificacion del registro
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<TssPensionadosNovedadesDetallesTran> TssPensionadosNovedadesDetallesTrans { get; set; } = new List<TssPensionadosNovedadesDetallesTran>();
}
