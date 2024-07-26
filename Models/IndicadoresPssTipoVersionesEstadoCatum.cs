using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las estados en que puedes estar las versiones de los formulario de visitas (grupo de preguntas definidos para un tipo de PSS), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class IndicadoresPssTipoVersionesEstadoCatum
{
    /// <summary>
    /// Es el número que representa el estado de si la versión del formulario de visitas está abierta o finalizada.
    /// </summary>
    public byte IndicadorVersionEstadoNumero { get; set; }

    /// <summary>
    /// Es la descripción del estado, que indica si la versión del formulario de visitas está abierta o finalizada.
    /// </summary>
    public string IndicadorVersionEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Es una breve explicación de la descripción del estado, que indica si la versión del formulario de visitas está abierta o finalizada.
    /// </summary>
    public string IndicadorVersionEstadoExplicacion { get; set; } = null!;

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

    public virtual ICollection<IndicadoresPssTipoVersionesCatum> IndicadoresPssTipoVersionesCata { get; set; } = new List<IndicadoresPssTipoVersionesCatum>();
}
