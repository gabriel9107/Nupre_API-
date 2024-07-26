using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasMedicosVistum
{
    public int PrestadoraNumero { get; set; }

    public long MedicoNss { get; set; }

    public string MedicoNombreCompleto { get; set; } = null!;

    public string MedicoNombres { get; set; } = null!;

    public string MedicoPrimerApellido { get; set; } = null!;

    public string MedicoSegundoApellido { get; set; } = null!;

    public string MedicoCedula { get; set; } = null!;

    public byte PrestadoraTipoNumero { get; set; }

    public string PrestadoraTipoDescripcion { get; set; } = null!;

    public byte PrestadoraClaseNumero { get; set; }

    public string PrestadoraClaseDescripcion { get; set; } = null!;

    public string MedicoDireccion { get; set; } = null!;

    public string MedicoExequatur { get; set; } = null!;

    public string MedicoMail { get; set; } = null!;

    public string Especialidades { get; set; } = null!;

    public short EspecialidadNumero1 { get; set; }

    public string Especialidad1Descripcion { get; set; } = null!;

    public short EspecialidadNumero2 { get; set; }

    public string Especialidad2Descripcion { get; set; } = null!;

    public short EspecialidadNumero3 { get; set; }

    public string Especialidad3Descripcion { get; set; } = null!;

    public string MedicoTelefonoExtencion { get; set; } = null!;

    public string MedicoTelefonoConsultorio { get; set; } = null!;

    public string MedicoTelefonoResidencia { get; set; } = null!;

    public string MedicoCelular { get; set; } = null!;

    public string Localidad { get; set; } = null!;

    public short MunicipioNumero { get; set; }

    public string MunicipioNombre { get; set; } = null!;

    public short ProvinciaNumero { get; set; }

    public string ProvinciaNombre { get; set; } = null!;

    public byte RegionSaludNumero { get; set; }

    public string RegionSaludNombre { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
