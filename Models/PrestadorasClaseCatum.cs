using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene la clases de PSS, clasifican los tipos de Prestadoras de Servicios de Salud (PSS), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasClaseCatum
{
    /// <summary>
    /// Es un número único que identifica la clase a la cual pertenece el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos, Centro Ambulatorio, Hospitales, etc.).
    /// </summary>
    public byte PrestadoraClaseNumero { get; set; }

    /// <summary>
    /// Es la descripción de la clase a la cual pertenece el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos, Centro Ambulatorio, Hospitales, etc.).
    /// </summary>
    public string PrestadoraClaseDescripcion { get; set; } = null!;

    /// <summary>
    /// Es la explicación del la clase a la cual pertenece el tipo de prestador de servicio de salud (PSS),  (Centros Diagnósticos, Centro Ambulatorio, Hospitales, etc.).
    /// </summary>
    public string PrestadoraClaseExplicacion { get; set; } = null!;

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

    public virtual ICollection<PrestadorasTipoCatum> PrestadorasTipoCata { get; set; } = new List<PrestadorasTipoCatum>();
}
