using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con las clase (Personas  y Entidades) clasificadas en el sistema de acreditación,  su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AcreditacionesClaseCatum
{
    /// <summary>
    /// Número único que identifica que quien se está acreditando es una persona o entidad.
    /// </summary>
    public byte AcreditacionClaseNumero { get; set; }

    /// <summary>
    /// Descripción de que quien se está acreditando es una persona o entidad.
    /// </summary>
    public string AcreditacionClaseDescripcion { get; set; } = null!;

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

    public virtual ICollection<AcreditacionesCategoriasClasesCatum> AcreditacionesCategoriasClasesCata { get; set; } = new List<AcreditacionesCategoriasClasesCatum>();
}
