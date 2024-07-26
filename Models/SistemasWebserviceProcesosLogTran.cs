using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasWebserviceProcesosLogTran
{
    public long ProcesoLogSecuencia { get; set; }

    /// <summary>
    /// Nombre del procedimiento de BDD.
    /// </summary>
    public string ProcesoNombre { get; set; } = null!;

    /// <summary>
    /// Nombre del procedimiento de BDD.
    /// </summary>
    public string ProcesoSistemaNombre { get; set; } = null!;

    public string ProcesoLogUrlOrigen { get; set; } = null!;

    public string ProcesoLogObjetoOrigen { get; set; } = null!;

    public string ProcesoLogMaquina { get; set; } = null!;

    public string ProcesoLogBrowser { get; set; } = null!;

    public string ProcesoLogPlataforma { get; set; } = null!;

    public string ProcesoLogDatos { get; set; } = null!;

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
