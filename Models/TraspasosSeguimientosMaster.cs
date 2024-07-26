using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosSeguimientosMaster
{
    /// <summary>
    /// Número único que representa la carga de un Archivo de Traspaso por Problema de Imagen y/o Condición de Enfermedad, reportado por el SUIR.
    /// </summary>
    public long SeguimientoNumero { get; set; }

    /// <summary>
    /// Nombre del Archivo de Envio que contenie los detalles de los Traspasos, ya sea por Problema de Imagen o Condición de Enfermedad.
    /// </summary>
    public string SeguimientoNombreArchivoEnvio { get; set; } = null!;

    /// <summary>
    /// Nombre del Archivo de Respuesta que contenie los detalles de los Traspasos, ya sea por Problema de Imagen o Condición de Enfermedad.
    /// </summary>
    public string SeguimientoNombreArchivoRespuesta { get; set; } = null!;

    public byte? TraspasoSeguimientoTipoNumero { get; set; }

    /// <summary>
    /// Número total de registros que contiene el archivo incluyendo el encabezado, el detalle y el sumario.
    /// </summary>
    public byte PosicionRegistroNumero { get; set; }

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string SeguimientoEstadoCodigo { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando generó el número de seguimiento.
    /// </summary>
    public DateTime SeguimientoFecha { get; set; }

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

    public virtual TraspasosSeguimientosEstadosCatum SeguimientoEstadoCodigoNavigation { get; set; } = null!;

    public virtual TraspasosSeguimientosTipoCatum? TraspasoSeguimientoTipoNumeroNavigation { get; set; }

    public virtual ICollection<TraspasosErroresRespuestasTran> TraspasosErroresRespuestasTrans { get; set; } = new List<TraspasosErroresRespuestasTran>();

    public virtual ICollection<TraspasosSeguimientosCondicionEnfermedadTran> TraspasosSeguimientosCondicionEnfermedadTrans { get; set; } = new List<TraspasosSeguimientosCondicionEnfermedadTran>();

    public virtual ICollection<TraspasosSeguimientosProblemaImagenTran> TraspasosSeguimientosProblemaImagenTrans { get; set; } = new List<TraspasosSeguimientosProblemaImagenTran>();
}
