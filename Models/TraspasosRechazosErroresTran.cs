using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los errores de las solicitudes de traspasos que son rechazadas, no llegan al proceso de asignación de NUCT, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosRechazosErroresTran
{
    /// <summary>
    /// Número único de rechazo a una solicitud de traspaso, cuando este es mayor que cero es porque no se genero el NUCT.
    /// </summary>
    public int RechazoNumero { get; set; }

    /// <summary>
    /// Número único del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema o de la solicitud de un traspaso.
    /// </summary>
    public byte ErrorNumero { get; set; }

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

    public virtual TraspasosErroresCatum ErrorNumeroNavigation { get; set; } = null!;

    public virtual TraspasosRechazosTran RechazoNumeroNavigation { get; set; } = null!;
}
