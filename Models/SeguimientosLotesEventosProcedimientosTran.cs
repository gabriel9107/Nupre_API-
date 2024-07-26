using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosLotesEventosProcedimientosTran
{
    public int EventoProcedimientoNumero { get; set; }

    /// <summary>
    /// Número único que representa cada  esquema.
    /// </summary>
    public byte EsquemaNumero { get; set; }

    /// <summary>
    /// Número único que representa cada evento que forma parte del proceso de una carga de esquema.
    /// </summary>
    public byte EventoTipoNumero { get; set; }

    public string EventoProcedimientoNombre { get; set; } = null!;

    public int EventoProcedimientoOrden { get; set; }

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

    public virtual SeguimientosEsquemasCatum EsquemaNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesEventosTipoCatum EventoTipoNumeroNavigation { get; set; } = null!;
}
