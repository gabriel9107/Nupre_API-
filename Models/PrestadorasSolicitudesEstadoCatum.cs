using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los estados de procesos que pude sufrir una solicitud registros  las Prestadoras de Servicios de Salud (PSS) institucionales que realizan las ARS/ARL, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasSolicitudesEstadoCatum
{
    /// <summary>
    /// Número único que indica el estado de proceso en que se encuentra la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL
    /// </summary>
    public byte PrestadoraSolicitudEstadoNumero { get; set; }

    /// <summary>
    /// Código único que indica el estado de proceso en que se encuentra la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL.
    /// </summary>
    public string PrestadoraSolicitudEstadoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del estado de proceso en que se encuentra la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL.
    /// </summary>
    public string PrestadoraSolicitudEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación  de la descripción del estado de proceso en que se encuentra la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL.
    /// </summary>
    public string PrestadoraSolicitudEstadoExplicacion { get; set; } = null!;

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

    public virtual ICollection<PrestadorasSolicitudTran> PrestadorasSolicitudTrans { get; set; } = new List<PrestadorasSolicitudTran>();
}
