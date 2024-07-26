using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los tipo de Colisiones relacionados con los Accidentes de Transito no laborales), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AccidentesColisionesTipoCatum
{
    /// <summary>
    /// Número que identifica con que Colisionó el afiliado.
    /// </summary>
    public byte ColisionTipoNumero { get; set; }

    /// <summary>
    /// Descripción de la colisión ocurrida durante el accidente.
    /// </summary>
    public string ColisionTipoDescripcion { get; set; } = null!;

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

    public virtual ICollection<AccidentesTransitoArsTran> AccidentesTransitoArsTrans { get; set; } = new List<AccidentesTransitoArsTran>();
}
