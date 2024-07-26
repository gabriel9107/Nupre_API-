using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los detalles de los problemas de imágenes de traspasos evaluados en la SISARIL,  su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosProblemasImagenDetallesTran
{
    /// <summary>
    /// Número único de control de traspaso, número asignado a cada traspaso desde su solicitud hasta su operación final.
    /// </summary>
    public int Nuct { get; set; }

    /// <summary>
    /// Número único que representa los problemas detectados en la imagen de traspaso.
    /// </summary>
    public byte ProblemaImagenNumero { get; set; }

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

    public virtual TraspasosMaster NuctNavigation { get; set; } = null!;

    public virtual TraspasosProblemasImagenCatum ProblemaImagenNumeroNavigation { get; set; } = null!;
}
