using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene los tipos de empresas (Públicas, Privadas, etc.) según estándar de la TSS, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesEmpresasTipoCatum
{
    /// <summary>
    /// Código que representa el Tipo de empresa según el sector al que pertenece (Pública centralizada, Pública No Centralizada, Privada y Mixta).
    /// </summary>
    public string EmpresaTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción del Tipo de empresa según el sector al que pertenece (Pública centralizada, Pública No Centralizada, Privada y Mixta).
    /// </summary>
    public string EmpresaTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Clasifica las empresas en de Autogestión,  Mixtas, Públicas y Privadas.
    /// </summary>
    public string EmpresaTipoCategoria { get; set; } = null!;

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

    public virtual ICollection<ArsMaster> ArsMasters { get; set; } = new List<ArsMaster>();

    public virtual ICollection<InstitucionesMaster> InstitucionesMasters { get; set; } = new List<InstitucionesMaster>();
}
