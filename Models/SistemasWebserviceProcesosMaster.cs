using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro donde se registran todo los procedimientos  de BDD que se relacionas con los Servicios WEB (WEB SERVICE) , utilizados en todos los sistemas , su fuente de datos los sistemas internos de la SISALRIL.
/// </summary>
public partial class SistemasWebserviceProcesosMaster
{
    /// <summary>
    /// Nombre del procedimiento de BDD.
    /// </summary>
    public string ProcesoNombre { get; set; } = null!;

    /// <summary>
    /// Nombre público del procedimiento de BDD.
    /// </summary>
    public string ProcesoNombrePublico { get; set; } = null!;

    /// <summary>
    /// Descripción del procedimiento de BDD.
    /// </summary>
    public string ProcesoDescripcion { get; set; } = null!;

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

    public virtual ICollection<SeguridadGruposProcesosTran> SeguridadGruposProcesosTrans { get; set; } = new List<SeguridadGruposProcesosTran>();

    public virtual ICollection<SistemasWebserviceProcesosLogTran> SistemasWebserviceProcesosLogTrans { get; set; } = new List<SistemasWebserviceProcesosLogTran>();

    public virtual ICollection<SistemasWebserviceProcesosParametrosTran> SistemasWebserviceProcesosParametrosTrans { get; set; } = new List<SistemasWebserviceProcesosParametrosTran>();
}
