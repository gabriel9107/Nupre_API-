using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosSeguimientosProblemaImagenTran
{
    /// <summary>
    /// Número único que representa la carga de un Archivo de Traspaso por Problema de Imagen y/o Condición de Enfermedad, reportado por el SUIR.
    /// </summary>
    public long SeguimientoNumero { get; set; }

    /// <summary>
    /// Número Único de Control de Traspaso con el cual fue autorizado el traspaso mediante consulta al Webservices de autorización de Traspaso de Salud.
    /// </summary>
    public int Nuct { get; set; }

    /// <summary>
    /// Lote de referencia asignado por el SUIR al archivo de notificación de enfermedad donde se reportó a la SISALRIL cada afiliado.
    /// </summary>
    public long NotificacionLoteSuirNumero { get; set; }

    /// <summary>
    /// Número de Respuesta del lote del archivo reportado por el SUIR.
    /// </summary>
    public long RespuestaLoteSuirNumero { get; set; }

    /// <summary>
    /// Código que indica la acción de SISALRIL (1 = Detener el traspaso, 2 = Continuar con el flujo del traspaso sin tomar en cuenta la notificación de enfermedad de la ARS Origen).
    /// </summary>
    public byte AccionNumero { get; set; }

    /// <summary>
    /// Número único de repuesta dada, después de la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public byte RespuestaNumero { get; set; }

    /// <summary>
    /// Código que indica el detalle de la acción tomada por la SISALRIL (ver catalogo de motivos de acción Problema Imagen).
    /// </summary>
    public byte MotivoNumero { get; set; }

    /// <summary>
    /// Número total de registros que contiene el archivo incluyendo el encabezado, el detalle y el sumario.
    /// </summary>
    public byte PosicionRegistroNumero { get; set; }

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string SeguimientoEstadoCodigo { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que dió repuesta, después de la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public string RespuestaUsuario { get; set; } = null!;

    /// <summary>
    /// Indica la fecha en la cual se dió repuesta, después de la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public DateTime RespuestaFecha { get; set; }

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

    public virtual TraspasosAccionesCatum AccionNumeroNavigation { get; set; } = null!;

    public virtual TraspasosRespuestasCatum RespuestaNumeroNavigation { get; set; } = null!;

    public virtual TraspasosSeguimientosMaster SeguimientoNumeroNavigation { get; set; } = null!;
}
