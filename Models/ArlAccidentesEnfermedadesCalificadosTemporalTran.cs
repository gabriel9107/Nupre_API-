using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ArlAccidentesEnfermedadesCalificadosTemporalTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Para reportar el número de expediente dado por la ARL SS.
    /// </summary>
    public long ExpedienteArlNumero { get; set; }

    /// <summary>
    /// Fecha de Calificación del AT /EP, contendrá el siguiente formato DDMMYYYY.
    /// </summary>
    public DateTime CalificacionFecha { get; set; }

    /// <summary>
    /// 1= Aprobado, 2 = Declinado.
    /// </summary>
    public byte CalificacionEstadoNumero { get; set; }

    /// <summary>
    /// Código valido para reportar el tipo de contingencia de acuerdo al accidente reportado.   
    /// </summary>
    public byte ContingenciaTipoNumero { get; set; }

    /// <summary>
    /// Para identificar el tipo de notificación 1 .Notificación AT y 2. Notificación E.P.
    /// </summary>
    public byte NotificacionTipoNumero { get; set; }

    /// <summary>
    /// Fecha en la que sucedió el  AT o Diagnostico de EP. Contendrá el siguiente formato DDMMYYYY.
    /// </summary>
    public DateTime EventoFecha { get; set; }

    /// <summary>
    /// Hora en la que sucedió el accidente contendrá el siguiente formato hh:mm, hora marina, será válido para el tipo de notificación 1. Caso contrario en blanco.
    /// </summary>
    public string AccidenteHora { get; set; } = null!;

    /// <summary>
    /// Fecha en la salió de sus labores previo a el  accidente de trabajo contendrá el siguiente  formato DDMMYYYY. Esto solo aplica para el tipo de notificación 1, caso contrario en blanco.
    /// </summary>
    public DateTime DejoTrabajarFecha { get; set; }

    /// <summary>
    /// Para especificar si se tiene identificado la PSS de atención,  indicar S o N.
    /// </summary>
    public string PrestadoraIdentificada { get; set; } = null!;

    /// <summary>
    /// Indica número de PSS donde se le brindo la atención al trabajador. Sera validada la PSS cuando el tipo de notificación sea  1, en caso contrario deberá ser reportado en 0.
    /// </summary>
    public int PrestadoraNumero { get; set; }

    /// <summary>
    /// Código del diagnostico, Según codificación CIE-10.
    /// </summary>
    public string Cie10Codigo { get; set; } = null!;

    /// <summary>
    /// Identifica el número único asignado de PSS al Medico en el SIMON. Ver Catálogo de PSS (SIMON).
    /// </summary>
    public int PrestadoraNumeroMedicoTratante { get; set; }

    /// <summary>
    /// Código valido para reportar  el  tipo de lesión de acuerdo al accidente reportado.
    /// </summary>
    public byte LesionGradoNumero { get; set; }

    /// <summary>
    /// Tipo de proceso en el cual se encuentra la solicitud AT /EP. Ver catálogo Tipo Proceso.
    /// </summary>
    public byte ProcesoTipoNumero { get; set; }

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
