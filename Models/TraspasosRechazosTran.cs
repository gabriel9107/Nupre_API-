using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las solicitudes de traspasos que son rechazadas, no llegan al proceso de asignación de NUCT, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosRechazosTran
{
    /// <summary>
    /// Número único de rechazo a una solicitud de traspaso, cuando este es mayor que cero es porque no se genero el NUCT.
    /// </summary>
    public int RechazoNumero { get; set; }

    /// <summary>
    /// Número único que especifica el tipo de traspaso.
    /// </summary>
    public byte TraspasoTipoNumero { get; set; }

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
    public long NssTitular { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string CedulaTitular { get; set; } = null!;

    /// <summary>
    /// Número de teléfono del lugar de residencia donde labora el Titular registrado en una solicitud de traspaso.
    /// </summary>
    public string TitularTelefonoResidencia { get; set; } = null!;

    /// <summary>
    /// Número de teléfono móvil del Titular registrado en una solicitud de traspaso.
    /// </summary>
    public string TitularTelefonoCelular { get; set; } = null!;

    /// <summary>
    /// Número de teléfono de la empresa donde labora el Titular registrado en una solicitud de traspaso.
    /// </summary>
    public string TitularTelefonoEmpresa { get; set; } = null!;

    /// <summary>
    /// Dirección de correo electrónico del Titular registrado en una solicitud de traspaso.
    /// </summary>
    public string TitularEmail { get; set; } = null!;

    /// <summary>
    /// Número de formulario de afiliación con el que se está relacionando solicitud de traspaso.
    /// </summary>
    public string TitularNumeroContrato { get; set; } = null!;

    /// <summary>
    /// Número de cedula del representante de la ARS que registro la solicitud de traspaso.
    /// </summary>
    public string RepresentanteCodigo { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsDestino { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsOrigen { get; set; }

    /// <summary>
    /// Es la descripción del tipo de sangre el Titular registrado en una solicitud de traspaso.
    /// </summary>
    public string TitularTipoSangre { get; set; } = null!;

    /// <summary>
    /// Pregunta clave seleccionada por el Titular registrado en una solicitud de traspaso.
    /// </summary>
    public string TitularPreguntaClave { get; set; } = null!;

    /// <summary>
    /// Respuesta a la pregunta clave expresada por el Titular registrado en una solicitud de traspaso.
    /// </summary>
    public string TitularRespuesta { get; set; } = null!;

    /// <summary>
    /// Estatus en el que se encuentra el proceso de traspaso, (RE u OK), reportado por el SUIR.
    /// </summary>
    public string RechazoEstatus { get; set; } = null!;

    /// <summary>
    /// Motivo por e cual se rechazo una solicitud de traspaso.
    /// </summary>
    public string RechazoMotivo { get; set; } = null!;

    /// <summary>
    /// Número que representan un lote de actualización desde una de las vista estadísticas que nos reporta UNIPAGO.
    /// </summary>
    public int NumeroSecuencia { get; set; }

    /// <summary>
    /// Número de seguimiento del envió de la solicitud de traspaso.
    /// </summary>
    public bool SeguimientoEnvio { get; set; }

    /// <summary>
    /// Número de seguimiento del reenvió de la solicitud de traspaso.
    /// </summary>
    public bool SeguimientoReenvio { get; set; }

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime FechaActualizacion { get; set; }

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

    public virtual TraspasosTipoCatum TraspasoTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<TraspasosRechazosErroresTran> TraspasosRechazosErroresTrans { get; set; } = new List<TraspasosRechazosErroresTran>();
}
