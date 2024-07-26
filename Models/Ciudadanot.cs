using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class Ciudadanot
{
    public long CiudadanoNss { get; set; }

    public string CiudadanoNombres { get; set; } = null!;

    public string CiudadanoPrimerApellido { get; set; } = null!;

    public string CiudadanoSegundoApellido { get; set; } = null!;

    public string EstadoCivilCodigo { get; set; } = null!;

    public string CiudadanoFechaNacimiento { get; set; } = null!;

    public DateTime CiudadanoFechaNacimientoDti { get; set; }

    public string CiudadanoNoDocumento { get; set; } = null!;

    public string DocumentoTipoCodigo { get; set; } = null!;

    public string CiudadanoSexo { get; set; } = null!;

    public short ProvinciaNumero { get; set; }

    public byte SangreTipoNumero { get; set; }

    public short CausaInhabilidadNumero { get; set; }

    public short NacionalidadNumero { get; set; }

    public string CiudadanoNoDocumentoAnterior { get; set; } = null!;

    public string CiudadanoNssEstatus { get; set; } = null!;

    public string CausaTipoCodigo { get; set; } = null!;

    public string CiudadanoActaNacimientoMunicipio { get; set; } = null!;

    public string CiudadanoActaNacimientoAnio { get; set; } = null!;

    public string CiudadanoActaNacimientoNumero { get; set; } = null!;

    public string CiudadanoActaNacimientoFolio { get; set; } = null!;

    public string CiudadanoActaNacimientoLibro { get; set; } = null!;

    public string CiudadanoActaNacimientoOficialia { get; set; } = null!;

    public DateTime FechaActualizacionTss { get; set; }

    public string CiudadanoCedulaFormateada { get; set; } = null!;

    public string CiudadanoNombreCompleto { get; set; } = null!;

    public string CiudadanoActaNacimientoUnida { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
