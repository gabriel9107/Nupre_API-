using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtAutorizacionCalendarioTran
{
    /// <summary>
    /// Número unico que identifica a la ARS que reporte el accidente de transito.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Fecha en la cual la ARS reporto el accidente de tránsito a la SISALRIL.
    /// </summary>
    public DateTime AtInformeFecha { get; set; }

    /// <summary>
    /// Fecha Tope del informe por accidente de transito.
    /// </summary>
    public DateTime AtInformeFechaTope { get; set; }

    /// <summary>
    /// Estado. A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del Usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de Registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual AtCalendarioTran AtInformeFechaNavigation { get; set; } = null!;
}
