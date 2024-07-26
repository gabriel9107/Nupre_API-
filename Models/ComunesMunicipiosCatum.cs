using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los municipios de la República Dominicana, según codificación de la JCS, su fuente de alimentación son las vistas estadísticas de UNIPAGO.
/// </summary>
public partial class ComunesMunicipiosCatum
{
    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Nombre del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public string MunicipioNombre { get; set; } = null!;

    /// <summary>
    /// Número único de la provincia según catálogo de la JCE.  (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public short ProvinciaNumero { get; set; }

    public string MunicipioProvinciaNombre { get; set; } = null!;

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

    public virtual ICollection<AfiliadosSfsMaster> AfiliadosSfsMasters { get; set; } = new List<AfiliadosSfsMaster>();

    public virtual ICollection<ComunesCiudadesCatum> ComunesCiudadesCata { get; set; } = new List<ComunesCiudadesCatum>();

    public virtual ICollection<ComunesSectoresParajesCatum> ComunesSectoresParajesCata { get; set; } = new List<ComunesSectoresParajesCatum>();

    public virtual ICollection<PrestadorasInstitucionalesMaster> PrestadorasInstitucionalesMasters { get; set; } = new List<PrestadorasInstitucionalesMaster>();

    public virtual ICollection<PrestadorasMedicosMaster> PrestadorasMedicosMasters { get; set; } = new List<PrestadorasMedicosMaster>();

    public virtual ICollection<PrestadorasMedicosSolicitudesTran> PrestadorasMedicosSolicitudesTrans { get; set; } = new List<PrestadorasMedicosSolicitudesTran>();

    public virtual ICollection<PrestadorasSolicitudTran> PrestadorasSolicitudTrans { get; set; } = new List<PrestadorasSolicitudTran>();

    public virtual ICollection<ProfesionalesMaster> ProfesionalesMasters { get; set; } = new List<ProfesionalesMaster>();

    public virtual ICollection<ProfesionalesSolicitudesTran> ProfesionalesSolicitudesTrans { get; set; } = new List<ProfesionalesSolicitudesTran>();

    public virtual ComunesProvinciasCatum ProvinciaNumeroNavigation { get; set; } = null!;
}
