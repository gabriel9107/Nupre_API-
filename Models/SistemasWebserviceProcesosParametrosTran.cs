using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los parámetros de los procedimientos  de BDD que se relacionas con los Servicios WEB (WEB SERVICE) , utilizados en todos los sistemas , su fuente de datos los sistemas internos de la SISALRIL.
/// </summary>
public partial class SistemasWebserviceProcesosParametrosTran
{
    /// <summary>
    /// Nombre del procedimiento de BDD.
    /// </summary>
    public string ProcesoNombre { get; set; } = null!;

    /// <summary>
    /// Nombre del  parámetro de un procedimiento de BDD relacionado con los Servicios WEB.
    /// </summary>
    public string ProcesoParametroNombre { get; set; } = null!;

    /// <summary>
    /// Descripción del  parámetro de un procedimiento de BDD relacionado con los Servicios WEB.
    /// </summary>
    public string ProcesoParametroDescripcion { get; set; } = null!;

    /// <summary>
    /// Tipo de datos de plataforma de desarrollo del parámetro de un procedimiento de BDD relacionado con los Servicios WEB.
    /// </summary>
    public string ProcesoParametroDatoTipo { get; set; } = null!;

    /// <summary>
    /// Tipo de datos de BDD del parámetro de un procedimiento de BDD relacionado con los Servicios WEB.
    /// </summary>
    public string ProcesoParametroDbDatoTipo { get; set; } = null!;

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

    public virtual SistemasWebserviceProcesosMaster ProcesoNombreNavigation { get; set; } = null!;
}
