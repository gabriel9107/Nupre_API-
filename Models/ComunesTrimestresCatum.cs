using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los trimestres del año, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesTrimestresCatum
{
    /// <summary>
    /// Corresponde al período de tres meses de un año
    /// </summary>
    public byte TrimestreNumero { get; set; }

    /// <summary>
    /// Corresponde al período de tres meses de un año
    /// </summary>
    public string TrimestreDescripcion { get; set; } = null!;

    /// <summary>
    /// Es el número único de 1 a 12 que representa el mes con el que inicia el trimestre.
    /// </summary>
    public byte MesNumeroInicia { get; set; }

    /// <summary>
    /// Es el número único de 1 a 12 que representa el mes con el que termina el trimestre.
    /// </summary>
    public byte MesNumeroTermina { get; set; }

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

    public virtual ICollection<ComunesMesesCatum> ComunesMesesCata { get; set; } = new List<ComunesMesesCatum>();

    public virtual ICollection<PypMetasTrimestralesMaster> PypMetasTrimestralesMasters { get; set; } = new List<PypMetasTrimestralesMaster>();
}
