using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasProcesosCatum
{
    public byte ProcesoNumero { get; set; }

    public string ProcesoDescripcion { get; set; } = null!;

    public string ProcesoExplicacion { get; set; } = null!;

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

    public virtual ICollection<SistemasArchivosCatum> SistemasArchivosCata { get; set; } = new List<SistemasArchivosCatum>();
}
