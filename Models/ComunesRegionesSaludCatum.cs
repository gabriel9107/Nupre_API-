using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de las regiones de salud definidas por el Ministerio de Salud de la República Dominicana, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesRegionesSaludCatum
{
    /// <summary>
    /// Número único de la región de salud  según clasificación del Ministerio de Salud. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public byte RegionSaludNumero { get; set; }

    /// <summary>
    /// Nombre de la región de salud  según clasificación del Ministerio de Salud. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public string RegionSaludNombre { get; set; } = null!;

    /// <summary>
    /// Número único de la región geográfica a la cual equivale una región de salud  según clasificación del Ministerio de Salud. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public byte RegionGeograficaNumero { get; set; }

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

    public virtual ICollection<ComunesProvinciasCatum> ComunesProvinciasCata { get; set; } = new List<ComunesProvinciasCatum>();

    public virtual ComunesRegionesGeograficasCatum RegionGeograficaNumeroNavigation { get; set; } = null!;
}
