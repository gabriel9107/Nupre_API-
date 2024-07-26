using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasAlertasFrecuenciasCatum
{
    public int AlertaNumero { get; set; }

    public byte TiempoIntervaloNumero { get; set; }

    public int AlertaFrecuenciaNumero { get; set; }

    public string? AlertaFrecuenciaDescripcion { get; set; }

    public string? AlertaFrecuenciaExplicacion { get; set; }

    public string? AlertaFrecuenciaDatosTipo { get; set; }

    public int? AlertaFrecuenciaDatoCuantitativoMaximo { get; set; }

    public string? CatalogoTabla { get; set; }

    public string? CatalogoTablaColumna { get; set; }

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

    public virtual SistemasAlertasMaster AlertaNumeroNavigation { get; set; } = null!;

    public virtual SistemasAlertasFrecuenciasTran SistemasAlertasFrecuenciasTran { get; set; } = null!;

    public virtual SistemasAlertasTiemposIntervalosCatum TiempoIntervaloNumeroNavigation { get; set; } = null!;
}
