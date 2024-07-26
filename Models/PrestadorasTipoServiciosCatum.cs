using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipo de Prestadoras de Servicios de Salud (PSS) y su relación con los servicios que pueden ser contratados por estas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasTipoServiciosCatum
{
    /// <summary>
    /// Es un número único que identifica el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos Especializado, Centro Ambulatorio General, Hospital General, etc.).
    /// </summary>
    public byte PrestadoraTipoNumero { get; set; }

    /// <summary>
    /// Número único del servicio que pueden ser contratados por las ARS/ARL a las PSS..
    /// </summary>
    public byte PrestadoraServicioNumero { get; set; }

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

    public virtual PrestadorasServiciosCatum PrestadoraServicioNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasTipoCatum PrestadoraTipoNumeroNavigation { get; set; } = null!;
}
