using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AtHechosCieCatum
{
    /// <summary>
    /// Código CIE para accidentes de transito.
    /// </summary>
    public string HechosCieCodigo { get; set; } = null!;

    /// <summary>
    /// Código del grupo CIE para accidentes de transito.
    /// </summary>
    public string HechosCieGrupo { get; set; } = null!;

    /// <summary>
    /// Descripción del código CIE para accidentes de transito.
    /// </summary>
    public string HechosCieDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del código CIE para accidentes de transito.
    /// </summary>
    public string HechosCieExplicacion { get; set; } = null!;

    /// <summary>
    /// Número único que identifica el tipo de vehiculo.
    /// </summary>
    public byte VehiculoTipoNumero { get; set; }

    /// <summary>
    /// Número único que identifica el tipo de lesionado.
    /// </summary>
    public byte PosicionLesionadoNumero { get; set; }

    /// <summary>
    /// Número único que identifica el tipo de colisión.
    /// </summary>
    public byte ColisionTipoNumero { get; set; }

    /// <summary>
    /// Estado. A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de Registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual AtColisionTipoCatum ColisionTipoNumeroNavigation { get; set; } = null!;

    public virtual AtPosicionLesionadoCatum PosicionLesionadoNumeroNavigation { get; set; } = null!;

    public virtual AtVehiculoTipoCatum VehiculoTipoNumeroNavigation { get; set; } = null!;
}
