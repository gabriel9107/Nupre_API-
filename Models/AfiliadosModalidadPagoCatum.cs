using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AfiliadosModalidadPagoCatum
{
    public byte ModalidadPagoNumero { get; set; }

    public string ModalidadPagoDescripcion { get; set; } = null!;

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

    public virtual ICollection<AfiliadosTitularesPlanesVoluntariosTran> AfiliadosTitularesPlanesVoluntariosTrans { get; set; } = new List<AfiliadosTitularesPlanesVoluntariosTran>();

    public virtual ICollection<AfiliadosVoluntariosEspecialesTran> AfiliadosVoluntariosEspecialesTrans { get; set; } = new List<AfiliadosVoluntariosEspecialesTran>();
}
