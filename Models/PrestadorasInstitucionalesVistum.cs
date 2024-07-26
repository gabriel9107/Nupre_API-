using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PrestadorasInstitucionalesVistum
{
    public int PrestadoraNumero { get; set; }

    public string PrestadoraNombre { get; set; } = null!;

    public string PrestadoraTelefono1 { get; set; } = null!;

    public string PrestadoraTelefono2 { get; set; } = null!;

    public string PrestadoraTelefono3 { get; set; } = null!;

    public string PrestadoraWebsite { get; set; } = null!;

    public string PrestadoraDireccion { get; set; } = null!;

    public byte PrestadoraTipoNumero { get; set; }

    public string PrestadoraTipoDescripcion { get; set; } = null!;

    public byte PrestadoraClaseNumero { get; set; }

    public string PrestadoraClaseDescripcion { get; set; } = null!;

    public short MunicipioNumero { get; set; }

    public string MunicipioNombre { get; set; } = null!;

    public short ProvinciaNumero { get; set; }

    public string ProvinciaNombre { get; set; } = null!;

    public byte RegionSaludNumero { get; set; }

    public string RegionSaludNombre { get; set; } = null!;

    public short PrestadoraMedicos { get; set; }

    public string PrestadoraPrimerNivel { get; set; } = null!;

    public string PrestadoraSegundoNivel { get; set; } = null!;

    public string PrestadoraTercerNivel { get; set; } = null!;

    public string PrestadoraCodigoSespas { get; set; } = null!;

    public string PrestadoraCodigoSespasProvisional { get; set; } = null!;

    public int InstitucionNumero { get; set; }

    public string InstitucionNombre { get; set; } = null!;

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
}
