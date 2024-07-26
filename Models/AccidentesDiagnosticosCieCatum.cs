using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla catálogo con los diagnosticos de una enfermedad o padecimiento para Accidentes de Transito reportados por las ARS y pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
/// </summary>
public partial class AccidentesDiagnosticosCieCatum
{
    /// <summary>
    /// Es el código de una enfermedad o padecimiento y pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
    /// </summary>
    public string DiagnosticoCodigoCie { get; set; } = null!;

    /// <summary>
    /// Es la descripción de una enfermedad o padecimiento y pertenece al código de la Clasificación Internacional de las enfermedades (CIE) , esta clasificación es de la Organización Mundial de la Salud (OMS).
    /// </summary>
    public string DiagnosticoCieDescripcion { get; set; } = null!;

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
