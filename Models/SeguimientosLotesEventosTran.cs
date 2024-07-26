using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los eventos que se ejecutan para un Lote de un seguimiento de carga de esquema de una ARS/ARL durante el proceso de carga, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosLotesEventosTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Es la secuencia del evento de carga de un esquema donde se encontró el error.
    /// </summary>
    public byte EventoSecuencia { get; set; }

    /// <summary>
    /// Número único que representa cada evento que forma parte del proceso de una carga de esquema.
    /// </summary>
    public byte EventoTipoNumero { get; set; }

    /// <summary>
    /// Fecha en la que inicio un evento en el proceso de una carga de esquema.
    /// </summary>
    public DateTime EventoFechaInicio { get; set; }

    /// <summary>
    /// Fecha en la que finalizo un evento en el proceso de una carga de esquema.
    /// </summary>
    public DateTime? EventoFechaFin { get; set; }

    public string EventoComentario { get; set; } = null!;

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

    public virtual SeguimientosLotesEventosTipoCatum EventoTipoNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
