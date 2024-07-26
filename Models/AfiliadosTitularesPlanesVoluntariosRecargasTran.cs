using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AfiliadosTitularesPlanesVoluntariosRecargasTran
{
    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public byte ArsNumero { get; set; }

    public string AfiliadoTitularCedula { get; set; } = null!;

    public string PlanNumero { get; set; } = null!;

    public string AfiliadoTitularPoliza { get; set; } = null!;

    public string PromotorDocumento { get; set; } = null!;

    public int InicioVigenciaFecha { get; set; }

    public int UltimoPagoFactura { get; set; }

    public decimal PrimaComercialMensual { get; set; }

    public byte ModalidadPagoNumero { get; set; }

    public string AfiliadoEstado { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
