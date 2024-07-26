using System;
using System.Collections.Generic;

namespace Nupre_API.Entidades;

/// <summary>
/// Es una tabla transaccional donde se registran los datos de los trabajadores de los empleadores empadronados en el  SDSS por la TSS, su fuente de datos la vista de publicadas por TSS diariamente.
/// </summary>
public partial class TssTrabajadoresTran
{
    /// <summary>
    /// Es el número único que le asigna la Tesorería de la Seguridad Social a cada uno de los empleadores que se registran en dicha institución.    
    /// </summary>
    public int EmpleadorRegistroPatronal { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long TrabajadorNss { get; set; }

    /// <summary>
    /// Fecha en que la TSS realizo el registro.
    /// </summary>
    public DateTime TrabajadorFechaRegistroTss { get; set; }

    /// <summary>
    /// Fecha ultima en que la TSS actualizo el registro.
    /// </summary>
    public DateTime TrabajadorFechaActualizacionTss { get; set; }

    /// <summary>
    /// Indica si el trabajador esta de Alta o de Baja en la TSS para un empleador específico.
    /// </summary>
    public string TrabajadorEstatus { get; set; } = null!;

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

    public virtual TssCiudadanosMaster TrabajadorNssNavigation { get; set; } = null!;
}
