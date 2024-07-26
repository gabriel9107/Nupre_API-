using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtVehiculoTipoCatum
{
    /// <summary>
    /// Número único que representa el tipo de vehiculo en accidentes de transito.
    /// </summary>
    public byte VehiculoTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de vehiculo.
    /// </summary>
    public string VehiculoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del tipo de vehiculo.
    /// </summary>
    public string VehiculoTipoExplicacion { get; set; } = null!;

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
