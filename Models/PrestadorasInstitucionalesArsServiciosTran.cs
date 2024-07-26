using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las Prestadoras de Servicios de Salud (PSS) institucionales y los servicios contratados por las ARS/ARL,  su fuente de datos es el esquema 26 procesado por el Robot Simon. 
/// </summary>
public partial class PrestadorasInstitucionalesArsServiciosTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Número único del servicio que pueden ser contratados por las ARS/ARL a las PSS..
    /// </summary>
    public byte PrestadoraServicioNumero { get; set; }

    public long? SeguimientoCodigo { get; set; }

    public byte? SeguimientoLote { get; set; }

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

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasServiciosCatum PrestadoraServicioNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran? Seguimiento { get; set; }
}
