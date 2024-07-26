using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosMotivoBajaCatum
{
    /// <summary>
    /// Código de baja del pensionado
    /// </summary>
    public string MotivoBajaCodigo { get; set; } = null!;

    /// <summary>
    /// Descripcion de baja del pensionado
    /// </summary>
    public string MotivoBajaDescripcion { get; set; } = null!;

    /// <summary>
    /// Muestra el esta del registro A=Activo, I=Inactivo
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Resgistra el usuario que registro o modifico el registro
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de creacion o modificacion del registro
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ICollection<TssPensionadosNovedadesDetallesTran> TssPensionadosNovedadesDetallesTrans { get; set; } = new List<TssPensionadosNovedadesDetallesTran>();
}
