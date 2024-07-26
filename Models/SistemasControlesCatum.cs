using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los controles utilizados en los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL  en el proceso de desarrollo.
/// </summary>
public partial class SistemasControlesCatum
{
    /// <summary>
    /// Número único del control del sistema de información.
    /// </summary>
    public int ControlNumero { get; set; }

    /// <summary>
    /// Número único del tipo de operación que se utilizan en la interface de los sistemas de información, La cual hace referencia generalmente a Insertar, Actualizar, Borrar.
    /// </summary>
    public byte OperacionTipoNumero { get; set; }

    /// <summary>
    /// Nombre interno del control (Generalmente un Botón) que representan las operaciones que se utilizan en la interface  de los sistemas de información.
    /// </summary>
    public string ControlNombreInterno { get; set; } = null!;

    /// <summary>
    /// Nombre público del control (Generalmente un Botón) que representan las operaciones que se utilizan en la interface  de los sistemas de información.
    /// </summary>
    public string ControlNombrePublico { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la operación que realiza el control (Generalmente un Botón) que representan las operaciones que se utilizan en la interface  de los sistemas de información.
    /// </summary>
    public string ControlExplicacion { get; set; } = null!;

    /// <summary>
    /// Tipifica el control en el tipo de objeto que se instanciara para su uso,  los controles  control (Generalmente un Botón) que representan las operaciones que se utilizan en la interface  de los sistemas de información.
    /// </summary>
    public string ControlTipo { get; set; } = null!;

    /// <summary>
    /// Evento que se ejecutará cuando el usuario de un clic al control,  los controles  control (Generalmente un Botón) que representan las operaciones que se utilizan en la interface  de los sistemas de información.
    /// </summary>
    public string ControlEventoOnClick { get; set; } = null!;

    /// <summary>
    /// Evento que se ejecutará cuando el usuario navegue sobre el control,  los controles  control (Generalmente un Botón) que representan las operaciones que se utilizan en la interface  de los sistemas de información.
    /// </summary>
    public string ControlEventoNavegacionUrl { get; set; } = null!;

    /// <summary>
    /// Dirección de la imagen que se despliega en el objeto (Generalmente un Botón), que representan las operaciones que se utilizan en la interface  de los sistemas de información.
    /// </summary>
    public string ControlImagenUrl { get; set; } = null!;

    /// <summary>
    /// Indica si el botón validará algún dato introducido por el usuario antes de realizar la función principal del control (Generalmente un Botón).
    /// </summary>
    public bool ControlCauseValidation { get; set; }

    /// <summary>
    /// Indica el nombre del estilo contenido en el archivo de CSS (Archivo de estilo HTML) el cual se aplicara al Control. (Generalmente un Botón)
    /// </summary>
    public string ControlCss { get; set; } = null!;

    /// <summary>
    /// Indica si el control (Generalmente un Botón) se va a mostrar en una TOOL BAR.
    /// </summary>
    public bool ControlMostrarToolbar { get; set; }

    /// <summary>
    /// Indica si la interface a la cual hace referencia el Botón se mostrara un POPUP.
    /// </summary>
    public bool ControlMostrarPopup { get; set; }

    /// <summary>
    /// Indica el ancho del POPUP donde se va a mostrar la interface a la cual hace referencia el botón.
    /// </summary>
    public short ControlPopupAncho { get; set; }

    /// <summary>
    /// Indica la altura del POPUP donde se va a mostrar la interface a la cual hace referencia el botón.
    /// </summary>
    public short ControlPopupAlto { get; set; }

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

    public virtual SistemasOperacionesTipoCatum OperacionTipoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SistemasModulosControlesTran> SistemasModulosControlesTrans { get; set; } = new List<SistemasModulosControlesTran>();
}
