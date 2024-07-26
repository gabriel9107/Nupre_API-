using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosReferenciasTipoCatum
{
    /// <summary>
    /// Número que identifica el tipo de Referencia.
    /// </summary>
    public byte ReferenciaTipoNumero { get; set; }

    /// <summary>
    /// Descripción del Tipo de Referencia, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string ReferenciaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación del Tipo de Referencia, especifica si el servicio fue prestado por una Emergencia, Programado o por un Accidente de Tránsito.
    /// </summary>
    public string ReferenciaTipoExplicacion { get; set; } = null!;

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
}
