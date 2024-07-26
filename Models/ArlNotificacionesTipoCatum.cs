using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla catálogo que contiene los tipos de Notificación de la calificación por Accidente de Trabajo y/o Enfermedad Profecional (1 .Notificación AT y 2. Notificación E.P.) publicados por la ARLSS, ver catálogo de Estado de Calificación, su fuente de datos es el  esquema 62 procesado por el Robot Simon. 
/// </summary>
public partial class ArlNotificacionesTipoCatum
{
    /// <summary>
    /// 1. Notificación AT y 2. Notificación E.P.
    /// </summary>
    public byte NotificacionTipoNumero { get; set; }

    /// <summary>
    /// 1. Notificación AT y 2. Notificación E.P.
    /// </summary>
    public string NotificacionTipoDescripcion { get; set; } = null!;

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
}
