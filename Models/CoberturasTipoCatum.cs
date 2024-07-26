using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene tipo de coberturas (Servicios y procedimientos de salud),  utilizado por la SISALRIL para clasificar las coberturas de los planes de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class CoberturasTipoCatum
{
    /// <summary>
    /// Número único del tipo de cobertura, clasifica las coberturas en Actos Quirúrgicos, Consultas, Fármacos, Estudios radiológicos, Etc.
    /// </summary>
    public byte CoberturaTipoNumero { get; set; }

    /// <summary>
    /// Descripción del tipo de cobertura, clasifica las coberturas en Actos Quirúrgicos, Consultas, Fármacos, Estudios radiológicos, Etc.
    /// </summary>
    public string CoberturaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Nos indica el tipo de  cobertura (insumo, procedimiento médico, material, fármaco, servicio, etc.) deben estar relacionadas a un CUPS 
    /// </summary>
    public string CoberturaTipoCups { get; set; } = null!;

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

    public virtual ICollection<CoberturasMaster> CoberturasMasters { get; set; } = new List<CoberturasMaster>();
}
