using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtPosicionLesionadoCatum
{
    /// <summary>
    /// Número que define la posición que ocupaba el afiliado al momento del accidente de transito.
    /// </summary>
    public byte PosicionLesionadoNumero { get; set; }

    /// <summary>
    /// Descripción de la posición del lesionado por accidente de transito.
    /// </summary>
    public string PosicionLesionadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la posición del lesionado por accidente de transito.
    /// </summary>
    public string PosicionLesionadoExplicacion { get; set; } = null!;

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
