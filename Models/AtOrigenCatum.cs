using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtOrigenCatum
{
    /// <summary>
    /// Número único del origen que condujo al reporte del accidente (Accidente de Tránsito, Accidente laboral, SFS). 
    /// </summary>
    public byte AtOrigenNumero { get; set; }

    /// <summary>
    /// Descripción del origen real que condujo al reporte del accidente (Accidente de Tránsito, Accidente laboral, SFS, etc.). 
    /// </summary>
    public string AtOrigenDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del origen real que condujo al reporte del accidente (Accidente de Tránsito, Accidente laboral, SFS, etc.). 
    /// </summary>
    public string AtOrigenExplicacion { get; set; } = null!;

    /// <summary>
    /// Indica si el reporte del accidente debe ser cerrado, cuando por investigación de la ARS se identifica que el origen inicial con el que se reporto el accidente no es el correcto y se selecciona un origen de cambio  con esta columna con el dato (‘S’). 
    /// </summary>
    public string AtOrigenCierre { get; set; } = null!;

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

    public virtual ICollection<AtMaster> AtMasterAtOrigenNumeroCambioNavigations { get; set; } = new List<AtMaster>();

    public virtual ICollection<AtMaster> AtMasterAtOrigenNumeroNavigations { get; set; } = new List<AtMaster>();
}
