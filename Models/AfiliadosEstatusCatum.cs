using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los diferentes  estado en que puede quedar un afiliado en el proceso de afiliación a una ARS, su fuente de alimentación son las vistas estadísticas de UNIPAGO.
/// </summary>
public partial class AfiliadosEstatusCatum
{
    /// <summary>
    /// Número único que representa el estado de  un afiliado,  entre ellos (OK, PE, BAJA, etc.), su objetivo es ser utilizados en futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte AfiliadoEstadoNumero { get; set; }

    /// <summary>
    /// Código único que representa el estado de  un afiliado,  entre ellos (OK, PE, BAJA, etc.).
    /// </summary>
    public string AfiliadoEstadoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del estado de  un afiliado,  entre ellos (OK, PE, BAJA, etc.).
    /// </summary>
    public string AfiliadoEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del estado de  un afiliado,  entre ellos (OK, PE, BAJA, etc.).
    /// </summary>
    public string AfiliadoEstadoExplicacion { get; set; } = null!;

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

    public virtual ICollection<AfiliadosSfsMaster> AfiliadosSfsMasters { get; set; } = new List<AfiliadosSfsMaster>();
}
