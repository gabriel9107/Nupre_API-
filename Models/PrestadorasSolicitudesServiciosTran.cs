using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran las solicitudes de las ARS /ARL para el registros  las Prestadoras de Servicios de Salud (PSS) institucionales y los servicios que esta pude ofrecer,  su fuente de datos son los sistemas  de la SISALRIL
/// </summary>
public partial class PrestadorasSolicitudesServiciosTran
{
    /// <summary>
    /// Número único de la solicitud de inclusión de PSS Institucional realizado por las ARS/ARL.
    /// </summary>
    public int PrestadoraSolicitudNumero { get; set; }

    /// <summary>
    /// Número único del servicio que pueden ser contratados por las ARS/ARL a las PSS..
    /// </summary>
    public byte PrestadoraServicioNumero { get; set; }

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

    public virtual PrestadorasServiciosCatum PrestadoraServicioNumeroNavigation { get; set; } = null!;

    public virtual PrestadorasSolicitudTran PrestadoraSolicitudNumeroNavigation { get; set; } = null!;
}
