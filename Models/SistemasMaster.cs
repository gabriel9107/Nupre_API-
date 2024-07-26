using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro donde se registran los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL en el proceso de desarrollo.
/// </summary>
public partial class SistemasMaster
{
    /// <summary>
    /// Número único del sistema de información.
    /// </summary>
    public short SistemaNumero { get; set; }

    /// <summary>
    /// Nombre oficial (Titulo)  del sistema de información.
    /// </summary>
    public string SistemaNombre { get; set; } = null!;

    /// <summary>
    /// Nombre del menú principal del sistema de información.
    /// </summary>
    public string SistemaMenuNombre { get; set; } = null!;

    /// <summary>
    /// Breve descripción del sistema de información.
    /// </summary>
    public string SistemaDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de la descripción del sistema de información.
    /// </summary>
    public string SistemaExplicacion { get; set; } = null!;

    /// <summary>
    /// Dirección donde se encuentran los objetos de ejecución y/o desarrollo del sistema de información.
    /// </summary>
    public string SistemaUrl { get; set; } = null!;

    /// <summary>
    /// Dirección donde se encuentra la imagen del logo del sistema de información.
    /// </summary>
    public string SistemaLogoImage { get; set; } = null!;

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

    public virtual ICollection<AcreditacionesExamenesLogsTran> AcreditacionesExamenesLogsTrans { get; set; } = new List<AcreditacionesExamenesLogsTran>();

    public virtual ICollection<SeguridadGruposCatum> SeguridadGruposCata { get; set; } = new List<SeguridadGruposCatum>();

    public virtual ICollection<SistemasDocumentosTran> SistemasDocumentosTrans { get; set; } = new List<SistemasDocumentosTran>();

    public virtual ICollection<SistemasModulosMaster> SistemasModulosMasters { get; set; } = new List<SistemasModulosMaster>();
}
