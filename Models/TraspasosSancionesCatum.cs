using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene el tipo de sanciones aplicables después de la evaluación de un traspaso, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosSancionesCatum
{
    /// <summary>
    /// Número único de sanción aplicada después de la evaluación de un caso de reclamo en un proceso de traspaso.
    /// </summary>
    public byte SancionNumero { get; set; }

    /// <summary>
    /// Descripción de la sanción aplicada después de la evaluación de un caso de reclamo en un proceso de traspaso.
    /// </summary>
    public string SancionDescripcion { get; set; } = null!;

    /// <summary>
    /// Indica el grado de falta por la cual la sanción aplicada después de la evaluación de un caso de reclamo en un proceso de traspaso.
    /// </summary>
    public byte SancionNivelNumero { get; set; }

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

    public virtual TraspasosSancionesNivelesCatum SancionNivelNumeroNavigation { get; set; } = null!;

    public virtual ICollection<TraspasosFormulariosCdeTran> TraspasosFormulariosCdeTrans { get; set; } = new List<TraspasosFormulariosCdeTran>();
}
