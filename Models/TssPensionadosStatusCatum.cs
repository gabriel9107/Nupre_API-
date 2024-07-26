using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosStatusCatum
{
    /// <summary>
    /// Codigo del estatus del registro
    /// </summary>
    public string StatusCodigo { get; set; } = null!;

    /// <summary>
    /// Descripcion del codigo 
    /// </summary>
    public string StatusDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripcion de la explicacion del estatus
    /// </summary>
    public string StatusExplicacion { get; set; } = null!;

    /// <summary>
    /// Estado actual del registro A= Activo, I= Inactivo
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Usuario que registro el registro
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha del registro
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<TssPensionadosMaster> TssPensionadosMasters { get; set; } = new List<TssPensionadosMaster>();

    public virtual ICollection<TssPensionadosNovedadesDetallesTran> TssPensionadosNovedadesDetallesTrans { get; set; } = new List<TssPensionadosNovedadesDetallesTran>();
}
