using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro donde se registran los módulos de los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL en el proceso de desarrollo.
/// </summary>
public partial class SistemasModulosMaster
{
    /// <summary>
    /// Número único del sistema de información.
    /// </summary>
    public short SistemaNumero { get; set; }

    /// <summary>
    /// Número único de modulo del sistema de información.
    /// </summary>
    public short ModuloNumero { get; set; }

    /// <summary>
    /// Nombre oficial (Titulo)  del sistema de información.
    /// </summary>
    public string ModuloNombre { get; set; } = null!;

    /// <summary>
    /// Nombre del menú principal del módulo del sistema de información.
    /// </summary>
    public string ModuloNombreMenu { get; set; } = null!;

    /// <summary>
    /// Indica si menú principal del módulo del sistema de información se va a mostrar por defecto.
    /// </summary>
    public string ModuloMenuMostrar { get; set; } = null!;

    /// <summary>
    /// Indica el orden en que se va a mostrar el menú principal del módulo del sistema de información.
    /// </summary>
    public int ModuloMenuOrden { get; set; }

    /// <summary>
    /// Breve descripción del módulo del sistema de información.
    /// </summary>
    public string ModuloDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de la descripción del módulo del sistema de información.
    /// </summary>
    public string ModuloExplicacion { get; set; } = null!;

    /// <summary>
    /// Dirección donde se encuentran los objetos de ejecución y/o desarrollo del módulo  del sistema de información.
    /// </summary>
    public string ModuloUrl { get; set; } = null!;

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

    public virtual SistemasMaster SistemaNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SistemasModulosFuncionesTran> SistemasModulosFuncionesTrans { get; set; } = new List<SistemasModulosFuncionesTran>();
}
