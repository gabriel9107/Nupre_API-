using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los lotes con os que se cargaron  las acreditaciones de los promotores de salud en UNIPAGO, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesPromotoresLotesTran
{
    /// <summary>
    /// Número único de lote con el que se cargo la acreditación de un promotor de salud en UNIPAGO.
    /// </summary>
    public short PromotoresLotes { get; set; }

    /// <summary>
    /// Fecha en que se genero el  lote con el que se cargaron  las acreditaciones de los promotores de salud en UNIPAGO.
    /// </summary>
    public DateTime PromotoresLotesFecha { get; set; }

    /// <summary>
    /// Nombre del archivo físico que se genero para  el  lote con el que se cargaron  las acreditaciones de los promotores de salud en UNIPAGO.
    /// </summary>
    public string PromotoresLotesNombreArchivo { get; set; } = null!;

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

    public virtual ICollection<AcreditacionesExamenesTran> AcreditacionesExamenesTrans { get; set; } = new List<AcreditacionesExamenesTran>();
}
