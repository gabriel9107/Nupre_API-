using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los detalles de los meses del año, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesMesesCatum
{
    /// <summary>
    /// Es el número único de 1 a 12 que representa el mes de una fecha o período.
    /// </summary>
    public byte MesNumero { get; set; }

    /// <summary>
    /// Es el nombre completo del mes. (Enero, Febrero, Marzo..., Diciembre).
    /// </summary>
    public string MesLetra { get; set; } = null!;

    /// <summary>
    /// Son las primeras tres letras del nombre del mes. (Ene, Feb, Mar... , Dic.).
    /// </summary>
    public string MesLetraCorto { get; set; } = null!;

    /// <summary>
    /// Corresponde al período de tres meses de un año
    /// </summary>
    public byte TrimestreNumero { get; set; }

    /// <summary>
    /// Número del cuatrimestre dentro del año (1 a 3) al cual corresponde la Fecha o el Mes del hecho o la situación reportada.
    /// </summary>
    public byte CuatrimestreNumero { get; set; }

    /// <summary>
    /// Día mínimo al cual corresponde la Fecha o el Mes del hecho o la situación reportada.
    /// </summary>
    public byte DiaMinimo { get; set; }

    /// <summary>
    /// Día máximo al cual corresponde la Fecha o el Mes del hecho o la situación reportada.
    /// </summary>
    public byte DiaMaximo { get; set; }

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

    public virtual ComunesTrimestresCatum TrimestreNumeroNavigation { get; set; } = null!;
}
