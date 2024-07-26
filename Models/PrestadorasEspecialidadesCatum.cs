using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene las especialidades medicas, clasifica el maestro de PSS Médicos, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PrestadorasEspecialidadesCatum
{
    /// <summary>
    /// Numero de la especialidad médica. 
    /// </summary>
    public short EspecialidadNumero { get; set; }

    /// <summary>
    /// Descripción de la especialidad médica.
    /// </summary>
    public string EspecialidadDescripcion { get; set; } = null!;

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

    public virtual ICollection<PrestadorasMedicosArsTran> PrestadorasMedicosArsTranEspecialidadNumero1Navigations { get; set; } = new List<PrestadorasMedicosArsTran>();

    public virtual ICollection<PrestadorasMedicosArsTran> PrestadorasMedicosArsTranEspecialidadNumero2Navigations { get; set; } = new List<PrestadorasMedicosArsTran>();

    public virtual ICollection<PrestadorasMedicosArsTran> PrestadorasMedicosArsTranEspecialidadNumero3Navigations { get; set; } = new List<PrestadorasMedicosArsTran>();

    public virtual ICollection<PrestadorasMedicosMaster> PrestadorasMedicosMasterEspecialidadNumero1Navigations { get; set; } = new List<PrestadorasMedicosMaster>();

    public virtual ICollection<PrestadorasMedicosMaster> PrestadorasMedicosMasterEspecialidadNumero2Navigations { get; set; } = new List<PrestadorasMedicosMaster>();

    public virtual ICollection<PrestadorasMedicosMaster> PrestadorasMedicosMasterEspecialidadNumero3Navigations { get; set; } = new List<PrestadorasMedicosMaster>();

    public virtual ICollection<PrestadorasMedicosSolicitudesTran> PrestadorasMedicosSolicitudesTranEspecialidadNumero1Navigations { get; set; } = new List<PrestadorasMedicosSolicitudesTran>();

    public virtual ICollection<PrestadorasMedicosSolicitudesTran> PrestadorasMedicosSolicitudesTranEspecialidadNumero2Navigations { get; set; } = new List<PrestadorasMedicosSolicitudesTran>();

    public virtual ICollection<PrestadorasMedicosSolicitudesTran> PrestadorasMedicosSolicitudesTranEspecialidadNumero3Navigations { get; set; } = new List<PrestadorasMedicosSolicitudesTran>();
}
