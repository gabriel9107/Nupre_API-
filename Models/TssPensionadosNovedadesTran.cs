using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosNovedadesTran
{
    /// <summary>
    /// ID de Novedad
    /// </summary>
    public short NovedadNumero { get; set; }

    /// <summary>
    /// Codigo de la ARS que reporto la novedad
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// A= Carga por la ARS, S= Cargada por la SEH, T= Dado de baja pot TSS
    /// </summary>
    public string NovedadTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Fecha en que se cargo el movimiento
    /// </summary>
    public DateTime NovedadFechaCarga { get; set; }

    /// <summary>
    /// Fecha en la que termino de procesar el movimiento
    /// </summary>
    public DateTime NovedadFechaTermino { get; set; }

    /// <summary>
    /// ID Recepcion 
    /// </summary>
    public int NovedadRecepcionNumero { get; set; }

    /// <summary>
    /// A= Activo, I Inactivo
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Usuario del registro
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual TssPensionadosNovedadesTipoCatum NovedadTipoCodigoNavigation { get; set; } = null!;

    public virtual ICollection<TssPensionadosNovedadesDetallesTran> TssPensionadosNovedadesDetallesTrans { get; set; } = new List<TssPensionadosNovedadesDetallesTran>();
}
