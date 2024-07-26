using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los tipos de esquemas  que deben cargar las ARS/ARL para su supervisión y seguimiento y su relación con tipo de institución, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class SeguimientosEsquemasInstitucionesTipoCatum
{
    /// <summary>
    /// Tipificación del número de la institución (3 = Administradora de Riesgos de Salud).
    /// </summary>
    public byte InstitucionTipoNumero { get; set; }

    /// <summary>
    /// Número único que representa cada  esquema.
    /// </summary>
    public byte EsquemaNumero { get; set; }

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

    public virtual InstitucionesTipoCatum InstitucionTipoNumeroNavigation { get; set; } = null!;
}
