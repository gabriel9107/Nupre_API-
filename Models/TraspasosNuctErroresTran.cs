using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional que contiene los diferentes errores de los NUCT durante su validación.
/// </summary>
public partial class TraspasosNuctErroresTran
{
    /// <summary>
    /// Secuencia para identifica cada error en un proceso de carga de esquema especifica (Seguimiento + Lote).
    /// </summary>
    public long ErrorSecuencia { get; set; }

    /// <summary>
    /// Número único de control de traspaso, número asignado a cada traspaso desde su solicitud hasta su operación final.
    /// </summary>
    public long Nuct { get; set; }

    /// <summary>
    /// Número único del error relacionado con una columna (Campo), utilizado para documentar en el proceso de validación de la carga de un esquema o de la solicitud de un traspaso.
    /// </summary>
    public byte ErrorNumero { get; set; }

    /// <summary>
    /// Nombre del campo que arrojó el error durante la validación de los NUCT.
    /// </summary>
    public string ErrorCampo { get; set; } = null!;

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
