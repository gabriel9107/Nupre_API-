using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene el código internacional de enfermedades (diagnósticos) de la OPS OMS, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesCie10Catum
{
    /// <summary>
    /// Es el código de una enfermedad o padecimiento y pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
    /// </summary>
    public string Cie10Codigo { get; set; } = null!;

    /// <summary>
    /// Código de un grupo de enfermedades o padecimientos, pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
    /// </summary>
    public byte Cie10Grupo { get; set; }

    /// <summary>
    /// Es la descripción de una enfermedad o padecimiento y pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
    /// </summary>
    public string Cie10Descripcion { get; set; } = null!;

    /// <summary>
    /// Nos indica con S ó N, si la enfermedades o padecimientos del CIE10 en este catálogo fue seleccionada o no para el Sistema de Subsidio de enfermedad común
    /// </summary>
    public string Cie10Seleccionado { get; set; } = null!;

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

    public virtual ICollection<SubgruposCie10Catum> SubgruposCie10Cata { get; set; } = new List<SubgruposCie10Catum>();
}
