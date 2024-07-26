using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las categorías de las ARS/ARL , su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ArsCategoriaCatum
{
    /// <summary>
    /// Código único que representa la calsificación de las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public string ArsCategoriaCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción que clasifica las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public string ArsCategoriaDescripcion { get; set; } = null!;

    /// <summary>
    /// Descripción que clasifica las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public string? ArsCategoriaTitulo { get; set; }

    /// <summary>
    /// Descripción que clasifica las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public string? ArsCategoriaSeguro { get; set; }

    public short? ArsCategoriaNumero { get; set; }

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

    public virtual ICollection<ArsMaster> ArsMasters { get; set; } = new List<ArsMaster>();
}
