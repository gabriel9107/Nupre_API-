using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los procesos donde se generan los  errores relacionados con cada uno de los pasos y actividades que se ejecutan en  los procesos de las cargas de los esquemas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosLotesErroresProcesosCatum
{
    /// <summary>
    /// Número único del proceso con el cual se relaciona un número de error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema.
    /// </summary>
    public byte ErrorProcesoNumero { get; set; }

    /// <summary>
    /// Descripción del proceso con el cual se relaciona un número de error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema.
    /// </summary>
    public string ErrorProcesoDescripcion { get; set; } = null!;

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

    public virtual ICollection<SeguimientosLotesErroresCatum> SeguimientosLotesErroresCata { get; set; } = new List<SeguimientosLotesErroresCatum>();
}
