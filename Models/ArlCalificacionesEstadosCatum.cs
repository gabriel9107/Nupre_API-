using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla catálogo que contiene los tipos de estado de la calificación por Accidente de Trabajo y/o Enfermedad Profecional (1= Aprobado , 2 = Declinado) publicados por la ARLSS, ver catálogo de Estado de Calificación, su fuente de datos es el  esquema 62 procesado por el Robot Simon. 
/// </summary>
public partial class ArlCalificacionesEstadosCatum
{
    /// <summary>
    /// 1= Aprobado, 2 = Declinado.
    /// </summary>
    public byte CalificacionEstadoNumero { get; set; }

    /// <summary>
    /// Descripción de cada estado en el que se encuentra la  certificación de discapacidad otorgada bajo el Seguro de Riesgos Laborales.
    /// </summary>
    public string CalificacionEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de cada estado en el que se encuentra la  certificación de discapacidad otorgada bajo el Seguro de Riesgos Laborales.
    /// </summary>
    public string CalificacionEstadoExplicacion { get; set; } = null!;

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
