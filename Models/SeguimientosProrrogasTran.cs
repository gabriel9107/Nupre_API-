using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las autorizaciones de prorrogas que se otorgan a las ARS/ARL cuando su fecha de carga de esquemas esta vencida, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosProrrogasTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único de una  prorroga otorgada a la ARS/ARL para la carga de un esquema de un periodo (Año y Mes) específico (Seguimiento).
    /// </summary>
    public byte SeguimientoProrrogaNumero { get; set; }

    /// <summary>
    /// Fecha en que termina la prorroga otorgada a la ARS/ARL para la carga de un esquema de un periodo (Año y Mes) específico (Seguimiento).
    /// </summary>
    public DateTime SeguimientoProrrogaHasta { get; set; }

    /// <summary>
    /// Indica si está o no vencida una  prorroga otorgada a la ARS/ARL para la carga de un esquema de un periodo (Año y Mes) específico (Seguimiento).
    /// </summary>
    public string SeguimientoProrrogaVencida { get; set; } = null!;

    /// <summary>
    /// Indica si está o no vencida una  prorroga otorgada a la ARS/ARL para la carga de un esquema de un periodo (Año y Mes) específico (Seguimiento).
    /// </summary>
    public string SeguimientoProrrogaComentario { get; set; } = null!;

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

    public virtual SeguimientosMaster SeguimientoCodigoNavigation { get; set; } = null!;
}
