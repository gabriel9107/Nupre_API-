using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas32Tran
{
    public long SeguimientoCodigo { get; set; }

    public int SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public int InstitucionNumero { get; set; }

    public string? PlanNumero { get; set; }

    public string? PolizaTitularNumero { get; set; }

    public string? NumeroAfiliado { get; set; }

    public string? NumeroDocumentoProbatorioTitular { get; set; }

    public string? NumeroDocumentoProbatorioDependiente { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? FechaNacimiento { get; set; }

    public string? Sexo { get; set; }

    public string? Parentesco { get; set; }

    public string? TipoAfiliado { get; set; }

    public string? TipoDependiente { get; set; }

    public string? Discapacitado { get; set; }

    public string? NacionalidadNumero { get; set; }

    public string? InicioVigencia { get; set; }

    public string? FechaUltimoPagoFactura { get; set; }

    public string? PrimaComercialMensual { get; set; }

    public string? ModalidadPago { get; set; }

    public string? ClaveAgentePromotor { get; set; }

    public string? Estado { get; set; }

    public string RegistroValidacionEstado { get; set; } = null!;

    public string RegistroValidacionErrores { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
