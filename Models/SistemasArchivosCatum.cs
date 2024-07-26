using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasArchivosCatum
{
    public int ArchivoNumero { get; set; }

    public string ArchivoNombre { get; set; } = null!;

    public string ArchivoDescripcion { get; set; } = null!;

    public string ArchivoExplicacion { get; set; } = null!;

    public byte ProcesoNumero { get; set; }

    public byte InstitucionRecibeNumero { get; set; }

    public byte InstitucionEnviaNumero { get; set; }

    public int ArchivoLineasLongitud { get; set; }

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

    public virtual SistemasProcesosCatum ProcesoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SistemasArchivosEstructurasCatum> SistemasArchivosEstructurasCata { get; set; } = new List<SistemasArchivosEstructurasCatum>();

    public virtual ICollection<SistemasSeguimientosMaster> SistemasSeguimientosMasters { get; set; } = new List<SistemasSeguimientosMaster>();
}
