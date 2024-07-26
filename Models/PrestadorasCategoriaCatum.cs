using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las categoría de PSS, clasifica el maestro de PSS, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasCategoriaCatum
{
    /// <summary>
    /// Es  un número único que representa  la categoría  de los prestadores de servicio de salud (PSS),    Prestadora Institucional  o  Médico Independiente),  su objetivo es ser utilizados en futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte PrestadoraCategoriaNumero { get; set; }

    /// <summary>
    /// Es un código que nos indica si prestador de servicio de salud (PSS) es un  P = Prestadora Institucional (Hospital, Laboratorio, centro Diagnósticos,  etc.) o es un M = Médico Independiente.
    /// </summary>
    public string PrestadoraCategoriaCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripción de la categoría que nos indica si el prestador de servicio de salud (PSS) es un  P = Prestadora Institucional (Hospital, Laboratorio, centro Diagnósticos,  etc.) o es un M = Médico Independiente.
    /// </summary>
    public string PrestadoraCategoriaDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación de la descripción de la categoría que nos indica si el prestador de servicio de salud (PSS) es un P = Prestadora Institucional (Hospital, Laboratorio, centro Diagnósticos,  etc.) o es un M = Médico Independiente.
    /// </summary>
    public string PrestadoraCategoriaExplicacion { get; set; } = null!;

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
}
