using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosHistorico
{
    /// <summary>
    /// Número único de control de traspaso, número asignado a cada traspaso desde su solicitud hasta su operación final.
    /// </summary>
    public int Nuct { get; set; }

    /// <summary>
    /// Número único de cada estado, relacionado con los diferentes procesos de investigación o notificación del SUIR, que pueden aplicar sobre  los traspasos.
    /// </summary>
    public byte NuctEstadoNumero { get; set; }

    /// <summary>
    /// Número único que especifica el tipo de traspaso.
    /// </summary>
    public byte TraspasoTipoNumero { get; set; }

    /// <summary>
    /// Número único que especifica el tipo de vencimiento de traspaso.
    /// </summary>
    public byte TraspasoVencimientoTipoNumero { get; set; }

    /// <summary>
    /// Fecha en la cual fue realizada la solicitud del traspaso por el afiliado en la ARS Destino.
    /// </summary>
    public DateTime TraspasoSolicitudFecha { get; set; }

    /// <summary>
    /// Fecha en la cual se culmino el proceso de traspaso.
    /// </summary>
    public DateTime? TraspasoEfectividadFecha { get; set; }

    /// <summary>
    /// Número único que identifica a un afiliado titular dentro del SFS, sobre el cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Es nombre completo (Nombres  y Apellidos) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoTitularNombreCompleto { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsDestino { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsOrigen { get; set; }

    /// <summary>
    /// Estatus en el que se encuentra el proceso de traspaso, (RE u OK), reportado por el SUIR.
    /// </summary>
    public string TraspasoEstatus { get; set; } = null!;

    /// <summary>
    /// Nombre del archivo  de  la imagen de traspaso.
    /// </summary>
    public string ImagenNombre { get; set; } = null!;

    /// <summary>
    /// Indica sí o no  la imagen de traspaso fue encontrada en la ruta indicada.
    /// </summary>
    public string ImagenEncontrada { get; set; } = null!;

    /// <summary>
    /// Dirección donde se encuentran almacenado el archivo de la imagen de traspaso.
    /// </summary>
    public string ImagenRuta { get; set; } = null!;

    /// <summary>
    /// Observaciones sobre los problemas detectados en  la imagen de traspaso.
    /// </summary>
    public string TraspasoObservacion { get; set; } = null!;

    /// <summary>
    /// Número único de cada acción,  acciones que se aplican en los proceso de evaluación de traspasos con reclamos de la ARS o por solicitudes del usuario.
    /// </summary>
    public byte AccionNumero { get; set; }

    /// <summary>
    /// Número único de repuesta dada, después de la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public byte RespuestaNumero { get; set; }

    public DateTime? TraspasoNotificacionArsOrigenFecha { get; set; }

    public DateTime? TraspasoVencimientoReporteProblemaImagenFecha { get; set; }

    public DateTime? TraspasoVencimientoReporteCondicionEnfermedadFecha { get; set; }

    /// <summary>
    /// Número único de repuesta dada, después de la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public byte SansionNumero { get; set; }

    /// <summary>
    /// Número del Caso.
    /// </summary>
    public int CasoNumero { get; set; }

    public string? TraspasoTelefonoEmpresa { get; set; }

    public string? TraspasoTelefonoResidencia { get; set; }

    public string? TraspasoTelefonoCelular { get; set; }

    public string? TraspasoEmail { get; set; }

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

    public string RegistroUsuarioHistorico { get; set; } = null!;

    public DateTime RegistroFechaHistorico { get; set; }

    public virtual TraspasosMaster NuctNavigation { get; set; } = null!;
}
