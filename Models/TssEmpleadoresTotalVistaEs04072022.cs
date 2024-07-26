using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssEmpleadoresTotalVistaEs04072022
{
    public int EmpleadorRegistroPatronal { get; set; }

    public string EmpleadorRncOCedula { get; set; } = null!;

    public string EmpleadorRazonSocial { get; set; } = null!;

    public string EmpleadorNombreComercial { get; set; } = null!;

    public short MunicipioNumero { get; set; }

    public string EmpleadorTelefono1 { get; set; } = null!;

    public string EmpleadorTelefono2 { get; set; } = null!;

    public int ActividadEconomicaNumero { get; set; }

    public string CategoriaRiesgo { get; set; } = null!;

    public string EmpresaTipoCodigo { get; set; } = null!;

    public DateTime EmpleadorFechaRegistroTss { get; set; }

    public DateTime EmpleadorFechaActualizacionTss { get; set; }

    public string EmpleadorEstatus { get; set; } = null!;

    public byte EntidadRecaudadoraNumero { get; set; }

    public byte SectorEconomicoNumero { get; set; }

    public byte SectorSalarialNumero { get; set; }

    public DateTime RegistroFecha { get; set; }
}
