using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran traspaso donde se determino una  condición de enfermedad (CDE), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosFormulariosCdeTran
{
    /// <summary>
    /// Número único del formulario de condición de enfermedad (CDE) con el cual se registro el caso para el afiliado en el proceso de traspaso.
    /// </summary>
    public int FormularioCdeNumero { get; set; }

    /// <summary>
    /// Número único de control de traspaso, número asignado a cada traspaso desde su solicitud hasta su operación final.
    /// </summary>
    public int Nuct { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Es el código que clasifica los afiliados en T = Titulares (Quien representa al núcleo familiar) D = Dependientes  (Hijos y Conjugues) y A = Adicionales (Padres, Hijos con mayoría de edad cumplida 18 o 21, otros familiares dependientes económicamente).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Nombre completo del afiliado que está en el proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string AfiliadoNombreCompleto { get; set; } = null!;

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public int ArsNumero { get; set; }

    /// <summary>
    /// Indica si el afiliado tiene o no una cirugía electiva pendiente para un traspaso donde se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string FormularioCdeCirugiaElectivaPe { get; set; } = null!;

    /// <summary>
    /// Detalles del tratamiento indicado al afiliado en un proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string FormularioCdeTratamientoEc { get; set; } = null!;

    /// <summary>
    /// Número de cédula de identidad del afiliado que está en el proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string FormularioCdeMedicoCedula { get; set; } = null!;

    /// <summary>
    /// Nombre completo del Médico que realizó el diagnostico e indicación para el afiliado del  proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string FormularioCdeMedicoNombre { get; set; } = null!;

    /// <summary>
    /// Especialidad del Médico que realizó el diagnostico e indicación para el afiliado del  proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string FormularioCdeMedicoEspecialidad { get; set; } = null!;

    /// <summary>
    /// Dirección del consultorio del Médico que realizó el diagnostico e indicación para el afiliado del  proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string FormularioCdeMedicoDireccion { get; set; } = null!;

    /// <summary>
    /// Número de teléfono  del Médico que realizó el diagnostico e indicación para el afiliado del  proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string FormularioCdeMedicoTelefono { get; set; } = null!;

    /// <summary>
    /// Dirección de correo electrónico del Médico que realizó el diagnostico e indicación para el afiliado del proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string FormularioCdeMedicoEmail { get; set; } = null!;

    /// <summary>
    /// Observaciones del formulario de condición de enfermedad para los procesos de traspaso.
    /// </summary>
    public string FormularioCdeObservaciones { get; set; } = null!;

    /// <summary>
    /// Número único de repuesta dada, después de la evaluación de un formulario de reclamo en un proceso de traspaso.
    /// </summary>
    public byte RespuestaNumero { get; set; }

    /// <summary>
    /// Número único de cada acción,  acciones que se aplican en los proceso de evaluación de traspasos con reclamos de la ARS o por solicitudes del usuario.
    /// </summary>
    public byte AccionNumero { get; set; }

    /// <summary>
    /// Comentario relacionado con la acción aplicada al traspaso donde se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string ComentarioAccion { get; set; } = null!;

    /// <summary>
    /// Número único de sanción aplicada después de la evaluación de un caso de reclamo en un proceso de traspaso.
    /// </summary>
    public byte SancionNumero { get; set; }

    /// <summary>
    /// Comentario relacionado con la sanción aplicada al traspaso donde se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string ComentarioSancion { get; set; } = null!;

    /// <summary>
    /// Detalles del usuario de la ARS  y IP donde se registro una  condición de enfermedad (CDE) del proceso de traspaso.
    /// </summary>
    public string FormularioCdeUsuario { get; set; } = null!;

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

    public virtual TssCiudadanosMaster AfiliadoNssNavigation { get; set; } = null!;

    public virtual AfiliadosTipoCatum AfiliadoTipoCodigoNavigation { get; set; } = null!;

    public virtual TraspasosMaster NuctNavigation { get; set; } = null!;

    public virtual TraspasosRespuestasCatum RespuestaNumeroNavigation { get; set; } = null!;

    public virtual TraspasosSancionesCatum SancionNumeroNavigation { get; set; } = null!;

    public virtual ICollection<TraspasosFormulariosCdeDetallesTran> TraspasosFormulariosCdeDetallesTrans { get; set; } = new List<TraspasosFormulariosCdeDetallesTran>();
}
