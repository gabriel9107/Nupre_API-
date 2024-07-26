using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catalogo con los tipos de instituciones que participan en el SDSS, su fuente de datos son los sistemas internos de la SISALRIL a partir del estándar del SUIR.
/// </summary>
public partial class InstitucionesTipoCatum
{
    /// <summary>
    /// Tipificación del número de la institución (3 = Administradora de Riesgos de Salud).
    /// </summary>
    public byte InstitucionTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de institución. (Para este caso es 3 = Administradora de Riesgos de Salud).
    /// </summary>
    public string InstitucionTipoDescripcion { get; set; } = null!;

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

    public virtual ICollection<InstitucionesMaster> InstitucionesMasters { get; set; } = new List<InstitucionesMaster>();

    public virtual ICollection<SeguimientosEsquemasInstitucionesTipoCatum> SeguimientosEsquemasInstitucionesTipoCata { get; set; } = new List<SeguimientosEsquemasInstitucionesTipoCatum>();
}
