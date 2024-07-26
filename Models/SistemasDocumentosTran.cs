using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional  donde se registran todo los documentos y con cual sistema de información se relacionan,   para su publicación a los usuarios del sistema, su fuente de datos los sistemas internos de la SISALRIL.
/// </summary>
public partial class SistemasDocumentosTran
{
    /// <summary>
    /// Número único del sistema de información.
    /// </summary>
    public short SistemaNumero { get; set; }

    /// <summary>
    /// Es el código único que representa el documento dentro del sistema.
    /// </summary>
    public short DocumentoCodigo { get; set; }

    /// <summary>
    /// Número de orden en el que debe ser desplegado un documento para un sistema de información específico.
    /// </summary>
    public byte DocumentoOrden { get; set; }

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
}
