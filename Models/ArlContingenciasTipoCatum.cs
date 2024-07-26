using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipo de contingencias utilizado por la ARL para reportar los detalles de los accidentes de trabajos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ArlContingenciasTipoCatum
{
    /// <summary>
    /// Código valido para reportar el tipo de contingencia de acuerdo al accidente reportado.
    /// </summary>
    public byte ContingenciaTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de contingencia de acuerdo al accidente reportado.
    /// </summary>
    public string ContingenciaTipoDescripcion { get; set; } = null!;

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
