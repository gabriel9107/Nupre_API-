using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los estructuras (Columnas) de los archivos de los esquemas  que deben cargar las ARS/ARL para su supervisión y seguimiento, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosEsquemasEstructurasCatum
{
    /// <summary>
    /// Número único que representa cada  esquema.
    /// </summary>
    public byte EsquemaNumero { get; set; }

    /// <summary>
    /// Secuencia de la columna (Campo) dentro de la estructura de datos del esquema.
    /// </summary>
    public short EstructuraSecuencia { get; set; }

    /// <summary>
    /// Nombre de la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public string EstructuraColumna { get; set; } = null!;

    /// <summary>
    /// Tipo de datos de la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public string EstructuraTipoDatos { get; set; } = null!;

    /// <summary>
    /// Longitud de la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public short EstructuraLongitud { get; set; }

    /// <summary>
    /// Indica si la columna (Campo) de la estructura de datos del esquema es obligatoria.
    /// </summary>
    public string EstructuraRequerido { get; set; } = null!;

    /// <summary>
    /// Posición inicial de la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public short EstructuraPosicionInicial { get; set; }

    /// <summary>
    /// Posición final de la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public short EstructuraPosicionFinal { get; set; }

    /// <summary>
    /// Observaciones sobre la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public string EstructuraObservacion { get; set; } = null!;

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

    public virtual SeguimientosEsquemasCatum EsquemaNumeroNavigation { get; set; } = null!;
}
