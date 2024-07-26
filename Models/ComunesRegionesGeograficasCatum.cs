using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de las regiones geográficas de la República Dominicana, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesRegionesGeograficasCatum
{
    /// <summary>
    /// Número único de la región geográfica a la cual equivale una región de salud  según clasificación del Ministerio de Salud. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public byte RegionGeograficaNumero { get; set; }

    /// <summary>
    /// Nombre de la región geográfica a la cual equivale una región de salud  según clasificación del Ministerio de Salud. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public string RegionGeograficaNombre { get; set; } = null!;

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

    public virtual ICollection<ComunesRegionesSaludCatum> ComunesRegionesSaludCata { get; set; } = new List<ComunesRegionesSaludCatum>();
}
