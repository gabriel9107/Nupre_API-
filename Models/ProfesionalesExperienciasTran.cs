using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesExperienciasTran
{
    /// <summary>
    /// Número único del prestador de servicio de salud que entrego los servicio (Institucional o Médico).
    /// </summary>
    public int ProfesionalNumero { get; set; }

    public byte ExperienciaTipoNumero { get; set; }

    public string ExperienciaLaboraActualmente { get; set; } = null!;

    public byte ExperienciaLaborAnios { get; set; }

    public byte ExperienciaLaborMeses { get; set; }

    public string ExperienciaLabor { get; set; } = null!;

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

    public virtual ProfesionalesExperienciasTiposTran ExperienciaTipoNumeroNavigation { get; set; } = null!;

    public virtual ProfesionalesMaster ProfesionalNumeroNavigation { get; set; } = null!;
}
