using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las solicitudes de imágenes de traspasos realizadas a UNIPAGO,  su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosSolicitudesImagenesUnipagoTran
{
    /// <summary>
    /// Numero de la imagen de solicitud de traspaso.
    /// </summary>
    public long SolicitudImagenNumero { get; set; }

    /// <summary>
    /// Número único de control de traspaso, número asignado a cada traspaso desde su solicitud hasta su operación final.
    /// </summary>
    public int Nuct { get; set; }

    /// <summary>
    /// Tipo de documento de la imagen de solicitud de traspaso.
    /// </summary>
    public string SolicitudImagenTipoDocumentro { get; set; } = null!;

    /// <summary>
    /// Secuencia de la imagen de solicitud de traspaso.
    /// </summary>
    public string SolicitudImagenSecuencia { get; set; } = null!;

    /// <summary>
    /// Fecha que la cual se solicitó la imagen de traspaso.
    /// </summary>
    public DateTime SolicitudImagenFecha { get; set; }

    /// <summary>
    /// Estado en que se encuentra una solicitud de imagen de traspaso.
    /// </summary>
    public string SolicitudImagenEstado { get; set; } = null!;

    /// <summary>
    /// Motivo por el cual se rechazo la solicitó la imagen de traspaso.
    /// </summary>
    public string SolicitudImagenMotivoRechazo { get; set; } = null!;

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
}
