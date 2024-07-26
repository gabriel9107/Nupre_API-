using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los diferentes parentescos familiares que pueden ser registrados entre un afiliado titular y sus dependientes, su fuente de alimentación es de la vista estadística de UNIPAGO.
/// </summary>
public partial class AfiliadosParentescoCatum
{
    /// <summary>
    /// Número único que representa el parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Descripción del parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public string ParentescoDescripcion { get; set; } = null!;

    /// <summary>
    /// Breve explicación del parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public string ParentescoExplicacion { get; set; } = null!;

    /// <summary>
    /// Especifica con (S/N) si el parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS) corresponde a un Cónyuge.
    /// </summary>
    public string ParentescoConyugues { get; set; } = null!;

    /// <summary>
    /// Especifica con (S/N) si el parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS) corresponde a Hijo.
    /// </summary>
    public string ParentescoHijos { get; set; } = null!;

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

    public virtual ICollection<AfiliadosDependientesPlanesVoluntariosTran> AfiliadosDependientesPlanesVoluntariosTrans { get; set; } = new List<AfiliadosDependientesPlanesVoluntariosTran>();

    public virtual ICollection<AfiliadosPlanesComplementariosTran> AfiliadosPlanesComplementariosTrans { get; set; } = new List<AfiliadosPlanesComplementariosTran>();

    public virtual ICollection<AfiliadosSfsMaster> AfiliadosSfsMasters { get; set; } = new List<AfiliadosSfsMaster>();

    public virtual ICollection<AfiliadosVoluntariosEspecialesTran> AfiliadosVoluntariosEspecialesTrans { get; set; } = new List<AfiliadosVoluntariosEspecialesTran>();
}
