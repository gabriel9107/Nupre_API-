using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los códigos de cifrado para las carga de esquemas de las  ARS/ARL, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosCifradosLlavesTran
{
    /// <summary>
    /// Número único del registro de la llave del cifrado.
    /// </summary>
    public int CifradoLlavesNumero { get; set; }

    /// <summary>
    /// Número de la institución que es o a la que pertenece la ARS.
    /// </summary>
    public int InstitucionNumero { get; set; }

    /// <summary>
    /// Fecha en que fue creada la llave de cifrado.
    /// </summary>
    public DateTime CifradoLlaveFechaCreacion { get; set; }

    /// <summary>
    /// Fecha en que fue dada de baja la llave de cifrado.
    /// </summary>
    public DateTime? CifradoLlaveFechaBaja { get; set; }

    /// <summary>
    /// Fecha en que caduca la llave de cifrado.
    /// </summary>
    public DateTime CifradoLlaveFechaCaduca { get; set; }

    /// <summary>
    /// Usuario que genero la llave de cifrado.
    /// </summary>
    public string CifradoLlaveUsuarioCreacion { get; set; } = null!;

    /// <summary>
    /// Primera parte de la llave de cifrado.
    /// </summary>
    public string CifradoLlaves1 { get; set; } = null!;

    /// <summary>
    /// Segunda parte de la llave de cifrado.
    /// </summary>
    public string CifradoLlaves2 { get; set; } = null!;

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

    public virtual InstitucionesMaster InstitucionNumeroNavigation { get; set; } = null!;
}
