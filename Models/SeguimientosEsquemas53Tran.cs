using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosEsquemas53Tran
{
    public long SeguimientoCodigo { get; set; }

    public int SeguimientoLote { get; set; }

    public long ArchivoLinea { get; set; }

    public string RncOCedula { get; set; } = null!;

    public string NoDocumentoTrabajador { get; set; } = null!;

    public string NoDocumentoBeneficiario { get; set; } = null!;

    public string InstitucionCodigo { get; set; } = null!;

    public string ExpedienteArlNumero { get; set; } = null!;

    public string SalarioNotificadoSuirCalculado { get; set; } = null!;

    public string PrestacionTipoNumero { get; set; } = null!;

    public string MontoCalculadoPrestacionEconomica { get; set; } = null!;

    public string FechaInicioPago { get; set; } = null!;

    public string MontoPrimerPago { get; set; } = null!;

    public string CantidadPagosRetroactivosAcum { get; set; } = null!;

    public string MontoRetroactivo { get; set; } = null!;

    public string FechaUltimoPago { get; set; } = null!;

    public string RegistroValidacionEstado { get; set; } = null!;

    public string RegistroValidacionErrores { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
