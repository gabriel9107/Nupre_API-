using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipos de servicios que pueden ser contratados por las PSS, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasServiciosCatum
{
    /// <summary>
    /// Número único del servicio que pueden ser contratados por las ARS/ARL a las PSS..
    /// </summary>
    public byte PrestadoraServicioNumero { get; set; }

    /// <summary>
    /// Descripcion de los servicios que pueden ser contratados por las ARS/ARL a las PSS.
    /// </summary>
    public string PrestadoraServicioDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripcion de los servicios que pueden ser contratados por las ARS/ARL a las PSS.
    /// </summary>
    public string PrestadoraServicioExplicacion { get; set; } = null!;

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

    public virtual ICollection<PrestadorasInstitucionalesArsServiciosTran> PrestadorasInstitucionalesArsServiciosTrans { get; set; } = new List<PrestadorasInstitucionalesArsServiciosTran>();

    public virtual ICollection<PrestadorasServiciosSaludArsTran> PrestadorasServiciosSaludArsTrans { get; set; } = new List<PrestadorasServiciosSaludArsTran>();

    public virtual ICollection<PrestadorasSolicitudesServiciosTran> PrestadorasSolicitudesServiciosTrans { get; set; } = new List<PrestadorasSolicitudesServiciosTran>();

    public virtual ICollection<PrestadorasTipoServiciosCatum> PrestadorasTipoServiciosCata { get; set; } = new List<PrestadorasTipoServiciosCatum>();
}
