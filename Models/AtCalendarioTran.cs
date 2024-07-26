using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtCalendarioTran
{
    /// <summary>
    /// Fecha en la cual la ARS reporto el accidente de tránsito a la SISALRIL.
    /// </summary>
    public DateTime AtInformeFecha { get; set; }

    /// <summary>
    /// Número del informe que se esta reportando, del 1 al 52.
    /// </summary>
    public short AtInformeNumero { get; set; }

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

    public virtual ICollection<AtAutorizacionCalendarioTran> AtAutorizacionCalendarioTrans { get; set; } = new List<AtAutorizacionCalendarioTran>();

    public virtual ICollection<AtMaster> AtMasters { get; set; } = new List<AtMaster>();

    public virtual ICollection<AtNotificacionNoCargaTran> AtNotificacionNoCargaTrans { get; set; } = new List<AtNotificacionNoCargaTran>();
}
