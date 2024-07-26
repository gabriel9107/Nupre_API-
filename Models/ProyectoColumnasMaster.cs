using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de las columnas de la mayoría de las tablas anteriores y nuevas, su fuente de datos son los procesos del proyecto de mejorar de base de datos. 
/// </summary>
public partial class ProyectoColumnasMaster
{
    /// <summary>
    /// Nombre de la columna (Campo, Atributo) de las tablas de datos.
    /// </summary>
    public string ColumnaNombre { get; set; } = null!;

    /// <summary>
    /// Nombre de la entidad o proceso con la que esta relacionada el nombre de la columna (Campo, Atributo) de las tablas de datos.
    /// </summary>
    public string ColumnaEntidad { get; set; } = null!;

    /// <summary>
    /// Descripción general de la columna (Campo, Atributo) de las tablas de datos.
    /// </summary>
    public string ColumnaDescripcion { get; set; } = null!;

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

    public virtual ICollection<ProyectoColumnasAliasTran> ProyectoColumnasAliasTrans { get; set; } = new List<ProyectoColumnasAliasTran>();
}
