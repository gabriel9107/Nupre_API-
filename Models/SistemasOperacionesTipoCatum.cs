using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los tipos de operaciones que ejecutan los controles  utilizados en los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL  en el proceso de desarrollo.
/// </summary>
public partial class SistemasOperacionesTipoCatum
{
    /// <summary>
    /// Número único del tipo de operación que se utilizan en la interface de los sistemas de información, La cual hace referencia generalmente a Insertar, Actualizar, Borrar.
    /// </summary>
    public byte OperacionTipoNumero { get; set; }

    /// <summary>
    /// Nombre del  tipo de operación que se utilizan en la interface de los sistemas de información, La cual hace referencia generalmente a Insertar, Actualizar, Borrar.
    /// </summary>
    public string OperacionTipoNombre { get; set; } = null!;

    /// <summary>
    /// Breve explicación del nombre del  tipo de operación que se utilizan en la interface de los sistemas de información, La cual hace referencia generalmente a Insertar, Actualizar, Borrar.
    /// </summary>
    public string OperacionTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<SistemasControlesCatum> SistemasControlesCata { get; set; } = new List<SistemasControlesCatum>();
}
