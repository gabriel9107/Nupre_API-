using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los tipos de solicitudes que pueden hacer  las ARS/ARL para el registro de una nueva Prestadoras de Servicios de Salud (PSS) institucionales, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasSolicitudesTipoCatum
{
    /// <summary>
    /// Número único del tipo de solicitud de inclusión de PSS Institucional que realizan  las ARS/ARL.
    /// </summary>
    public byte PrestadoraSolicitudTipoNumero { get; set; }

    /// <summary>
    /// Descripción  del tipo de solicitud de inclusión prestadora institucional, indica si se solicita una sede principal o una sucursal.
    /// </summary>
    public string PrestadoraSolicitudTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción  del tipo de solicitud de inclusión prestadora institucional, que indica si se solicita una sede principal o una sucursal.
    /// </summary>
    public string PrestadoraSolicitudTipoExsplicacion { get; set; } = null!;

    /// <summary>
    /// Número único que indica si la prestadora institucional es una sede principal o una sucursal.
    /// </summary>
    public byte PrestadoraSedeNumero { get; set; }

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

    public virtual PrestadorasSedeCatum PrestadoraSedeNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PrestadorasSolicitudTran> PrestadorasSolicitudTrans { get; set; } = new List<PrestadorasSolicitudTran>();
}
