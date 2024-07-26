using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los regímenes que aplican de ley para el SFS y el SRL, su fuente de alimentación es vía sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesRegimenesCatum
{
    /// <summary>
    /// Número único que identifica cada uno de los regímenes definidos en la ley 87-01, (Contributivo, Subsidiado y Contributivo Subsidiado).
    /// </summary>
    public byte RegimenNumero { get; set; }

    /// <summary>
    /// Descripción de los regímenes definidos en la ley 87-01, (Contributivo, Subsidiado y Contributivo Subsidiado). Cada uno es representado por un número de régimen.
    /// </summary>
    public string RegimenDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de los regímenes definidos en la ley 87-01, (Contributivo, Subsidiado y Contributivo Subsidiado). Cada uno es representado por un número de régimen.
    /// </summary>
    public string RegimenExplicacion { get; set; } = null!;

    /// <summary>
    /// Siglas de los regímenes definidos en la ley 87-01, (RC = Régimen Contributivo, RS = Régimen Subsidiado y CS = Régimen  Contributivo Subsidiado). Cada uno es representado por un número de régimen.
    /// </summary>
    public string RegimenSiglas { get; set; } = null!;

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

    public virtual ICollection<ArsMaster> ArsMasters { get; set; } = new List<ArsMaster>();

    public virtual ICollection<IndicadoresPssVisitasMaster> IndicadoresPssVisitasMasters { get; set; } = new List<IndicadoresPssVisitasMaster>();
}
