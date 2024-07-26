using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los tipos de problemas de imágenes de traspasos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosProblemasImagenCatum
{
    /// <summary>
    /// Número único que representa los problemas detectados en la imagen de traspaso.
    /// </summary>
    public byte ProblemaImagenNumero { get; set; }

    /// <summary>
    /// Descripción de los problemas detectados en  la imagen de traspaso.
    /// </summary>
    public string ProblemaImagenDescripcion { get; set; } = null!;

    /// <summary>
    /// Número único de repuesta dada, después de la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public byte RespuestaNumero { get; set; }

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

    public virtual TraspasosRespuestasCatum RespuestaNumeroNavigation { get; set; } = null!;

    public virtual ICollection<TraspasosProblemasImagenDetallesTran> TraspasosProblemasImagenDetallesTrans { get; set; } = new List<TraspasosProblemasImagenDetallesTran>();
}
