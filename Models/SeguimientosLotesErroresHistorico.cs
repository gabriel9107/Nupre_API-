using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SeguimientosLotesErroresHistorico
{
    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public byte EventoSecuencia { get; set; }

    public long ErrorSecuencia { get; set; }

    public long ArchivoLinea { get; set; }

    public short ErrorNumero { get; set; }

    public string EventoCampoError { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
