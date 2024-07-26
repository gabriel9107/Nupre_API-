using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipo de Sede que aplican para el registro de una PSS Institucional, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasSedeCatum
{
    /// <summary>
    /// Número único que indica si la prestadora institucional es una sede principal o una sucursal.
    /// </summary>
    public byte PrestadoraSedeNumero { get; set; }

    /// <summary>
    /// Descripción de la sede de la prestadora institucional, indica si es una sede principal o una sucursal.
    /// </summary>
    public string PrestadoraSedeDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción de la sede de la prestadora institucional, indica si es una sede principal o una sucursal.
    /// </summary>
    public string PrestadoraSedeExsplicacion { get; set; } = null!;

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

    public virtual ICollection<PrestadorasInstitucionalesMaster> PrestadorasInstitucionalesMasters { get; set; } = new List<PrestadorasInstitucionalesMaster>();

    public virtual ICollection<PrestadorasSolicitudesTipoCatum> PrestadorasSolicitudesTipoCata { get; set; } = new List<PrestadorasSolicitudesTipoCatum>();
}
