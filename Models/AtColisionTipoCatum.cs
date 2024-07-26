using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtColisionTipoCatum
{
    /// <summary>
    /// Número de colisión por accidente de transito.
    /// </summary>
    public byte ColisionTipoNumero { get; set; }

    /// <summary>
    /// Descripción de la colisión por accidente de transito.
    /// </summary>
    public string ColisionTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la colisión por accidente de transito.
    /// </summary>
    public string ColisionTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<AtHechosCieCatum> AtHechosCieCata { get; set; } = new List<AtHechosCieCatum>();

    public virtual ICollection<AtMaster> AtMasters { get; set; } = new List<AtMaster>();
}
