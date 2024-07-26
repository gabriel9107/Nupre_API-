using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasArchivosEstructurasCatum
{
    public int ArchivoNumero { get; set; }

    public int EstructuraSecuencia { get; set; }

    /// <summary>
    /// Nombre de la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public string EsctructuraColumna { get; set; } = null!;

    /// <summary>
    /// Tipo de datos de la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public string EsctructuraTipoDatos { get; set; } = null!;

    /// <summary>
    /// Longitud de la columna (Campo) de la estructura de datos del esquema.
    /// </summary>
    public short EstructuraLoguitud { get; set; }

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

    public short EstructuraOrden { get; set; }

    public string EstructuraEspaciosFaltantes { get; set; } = null!;

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

    public virtual SistemasArchivosCatum ArchivoNumeroNavigation { get; set; } = null!;
}
