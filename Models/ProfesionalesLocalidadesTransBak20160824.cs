using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesLocalidadesTransBak20160824
{
    public int ProfesionalNumero { get; set; }

    public int ProfesionalLocalidadSecuencia { get; set; }

    public int PrestadoraNumero { get; set; }

    public short MunicipioNumero { get; set; }

    public string ProfesionalLocalidadDireccion { get; set; } = null!;

    public string ProfesionalLocalidadConsultorio { get; set; } = null!;

    public string ProfesionalLocalidadServicios { get; set; } = null!;

    public string ProfesionalLocalidadTelefono1 { get; set; } = null!;

    public string ProfesionalLocalidadTelefono2 { get; set; } = null!;

    public string ProfesionalLocalidadMensajes { get; set; } = null!;

    public byte ProfesionalAtencionTipoNumero { get; set; }

    public byte ProfesionalLocalidadHorarioLunes { get; set; }

    public byte ProfesionalLocalidadHorarioMartes { get; set; }

    public byte ProfesionalLocalidadHorarioMiercoles { get; set; }

    public byte ProfesionalLocalidadHorarioJueves { get; set; }

    public byte ProfesionalLocalidadHorarioViernes { get; set; }

    public byte ProfesionalLocalidadHorarioSabado { get; set; }

    public byte ProfesionalLocalidadHorarioDomingo { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
