using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla de configuración donde se registran la cantidad de instancias del ROBOT SIMON que pueden ser ejecutadas a la mima vez,  su fuente de datos son los sistemas  de la SISALRIL.
/// </summary>
public partial class SeguimientosRobotInstanciasConfig
{
    /// <summary>
    /// Número de instancia del robot que esta ejecutándose en un mismo momento.
    /// </summary>
    public byte RobotInstanciasNumero { get; set; }

    /// <summary>
    /// Número máximo de instancia del robot que pueden estar ejecutándose en un mismo momento.
    /// </summary>
    public byte RobotInstanciasMaxima { get; set; }

    /// <summary>
    /// Número de instancia del robot que se  están  ejecutándose en este momento.
    /// </summary>
    public byte RobotInstanciasOperando { get; set; }

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
