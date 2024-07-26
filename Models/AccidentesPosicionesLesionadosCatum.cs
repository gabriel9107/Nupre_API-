using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de la Posición del lesionado en el Accidente relacionados con los Accidentes de Transito no laborales), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class AccidentesPosicionesLesionadosCatum
{
    /// <summary>
    /// Representa la Posición del lesionado en el Accidente. 
    /// </summary>
    public byte PosicionLesionadoNumero { get; set; }

    /// <summary>
    /// Descripción de la Posición del lesionado en el Accidente.
    /// </summary>
    public string PosicionLesionadoDescripcion { get; set; } = null!;

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
