using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los diferentes  formas de afiliación como puede registrarse un afiliado a una ARS, su fuente de alimentación son las vistas estadísticas de UNIPAGO.
/// </summary>
public partial class AfiliadosAfiliacionesTipoCatum
{
    /// <summary>
    /// Código único que representa el proceso por el cual se registro  una afiliación,  entre ellas (Traspasos, Afiliación Automática, Normal, etc.).
    /// </summary>
    public string AfiliacionTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del proceso por el cual se registro  una afiliación,  entre ellos (Traspasos, Afiliación Automática, Normal, etc.).
    /// </summary>
    public string AfiliacionTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del proceso por el cual se registro  una afiliación,  entre ellos (Traspasos, Afiliación Automática, Normal, etc.).
    /// </summary>
    public string AfiliacionTipoExplicacion { get; set; } = null!;

    /// <summary>
    /// Número único que representa el proceso por el cual se registro  una afiliación,  entre ellos (Traspasos, Afiliación Automática, Normal, etc.), su objetivo es ser utilizados en futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte AfiliacionTipoNumero { get; set; }

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
