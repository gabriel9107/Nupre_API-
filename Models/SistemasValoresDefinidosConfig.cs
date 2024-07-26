using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla de configuración donde se registran los valores definidos  y los catálogos a los que pertenecen para ser utilizados en los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL en el proceso de desarrollo.
/// </summary>
public partial class SistemasValoresDefinidosConfig
{
    /// <summary>
    /// Número único del catálogo (Tabla) donde están contenidos los valores.
    /// </summary>
    public short CatalogoNumero { get; set; }

    /// <summary>
    /// Nombre del catálogo (Tabla) donde están contenidos los valores.
    /// </summary>
    public string CatalogoTabla { get; set; } = null!;

    /// <summary>
    /// Nombre de la columna del catálogo (Tabla) donde están contenidos los valores.
    /// </summary>
    public string CatalogoTablaColumna { get; set; } = null!;

    /// <summary>
    /// Código único del catálogo (Tabla) donde están contenidos los valores.
    /// </summary>
    public string CatalogoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del catálogo (Tabla) donde están contenidos los valores.
    /// </summary>
    public string CatalogoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación sobre del catálogo (Tabla) donde están contenidos los valores.
    /// </summary>
    public string CatalogoExplicacion { get; set; } = null!;

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
