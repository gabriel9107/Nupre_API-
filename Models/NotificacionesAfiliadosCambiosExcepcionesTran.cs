using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class NotificacionesAfiliadosCambiosExcepcionesTran
{
    public int SeguimientoNumero { get; set; }

    public string TipoRegistro { get; set; } = null!;

    public byte MotivoCambio { get; set; }

    public int NumeroSolicitudCambio { get; set; }

    public string TipoAfiliado { get; set; } = null!;

    public long NssAfiliadoSolicitado { get; set; }

    public string CedulaAfiliadoSolicitado { get; set; } = null!;

    public string OficialiaActaNacimiento { get; set; } = null!;

    public string LibroActaNacimiento { get; set; } = null!;

    public string FolioActaNacimiento { get; set; } = null!;

    public string NumeroActaNacimiento { get; set; } = null!;

    public string AnioActaNacimiento { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public long NssAfiliadoTitularNuevo { get; set; }

    public string CedulaAfiliadoTitularNuevo { get; set; } = null!;

    public byte ParentescoAAfiliarse { get; set; }

    public string TipoDependienteAAfiliarse { get; set; } = null!;

    public string AfiliadoEstudianteAAfiliarse { get; set; } = null!;

    public string AfiliadoDiscapacitadoAAfiliarse { get; set; } = null!;

    public string PrimerNombre { get; set; } = null!;

    public string SegundoNombre { get; set; } = null!;

    public string PrimerApellido { get; set; } = null!;

    public string SegundoApellido { get; set; } = null!;

    public string Provincia { get; set; } = null!;

    public string Municipio { get; set; } = null!;
}
