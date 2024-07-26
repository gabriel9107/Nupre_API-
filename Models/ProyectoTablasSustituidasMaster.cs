using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro que contiene las informaciones de las tablas anteriores que han sido sustituidas o descartadas, su fuente de datos son los procesos del proyecto de mejorar de base de datos. 
/// </summary>
public partial class ProyectoTablasSustituidasMaster
{
    /// <summary>
    /// Nombre de la tabla (objeto).
    /// </summary>
    public string TablaSustituidaNombre { get; set; } = null!;

    /// <summary>
    /// Nombre del servidor de base de datos donde se encuentra alojada la tabla.
    /// </summary>
    public string TablaSustituidaServidor { get; set; } = null!;

    /// <summary>
    /// Nombre de la Base de Datos donde se encuentra alojada la tabla.
    /// </summary>
    public string TablaSustituidaBdd { get; set; } = null!;

    /// <summary>
    /// Cantidad de registro con la fue que creada la tabla.
    /// </summary>
    public int TablaSustituidaRegistros { get; set; }

    /// <summary>
    /// Nombre de la tabla (objeto).
    /// </summary>
    public string TablaNuevaNombre { get; set; } = null!;

    /// <summary>
    /// Indica si el proceso de resguardo de la tabla está  incompleto o completado.
    /// </summary>
    public string TablaSustituidaTxtScrip { get; set; } = null!;

    /// <summary>
    /// Indica si el proceso de resguardo de la data en TXT   está  completado.
    /// </summary>
    public string TablaSustituidaTxtData { get; set; } = null!;

    /// <summary>
    /// Describe la información  contenida en la tabla y su propósito.
    /// </summary>
    public string TablaSustituidaComentario { get; set; } = null!;

    /// <summary>
    /// Indica si el proceso de resguardo de la tabla está  incompleto o completado.
    /// </summary>
    public string TablaSustituidaEstatus { get; set; } = null!;

    /// <summary>
    /// Fecha en que  el proceso de resguardo de la tabla fue completado.
    /// </summary>
    public DateTime TablaSustituidaFecha { get; set; }

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

    public virtual ProyectoTablasNuevasMaster TablaNuevaNombreNavigation { get; set; } = null!;
}
