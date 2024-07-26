using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArsAsociacionesCatum
{
    /// <summary>
    /// Código único que representa la calsificación de las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public byte ArsAsociacionNumero { get; set; }

    /// <summary>
    /// Descripción que clasifica las ARS en Públicas, Privadas y Auto gestionada.
    /// </summary>
    public string ArsAsociacionNombre { get; set; } = null!;

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
    public DateTime? RegistroFecha { get; set; }

    public virtual ICollection<ArsMaster> ArsMasters { get; set; } = new List<ArsMaster>();
}
