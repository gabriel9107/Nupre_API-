using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AfiliadosVoluntariosEspecialesTemporalTran
{
    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public byte ArsNumero { get; set; }

    public string PlanNumero { get; set; } = null!;

    public string AfiliadoTitularDocumento { get; set; } = null!;

    public string AfiliadoDependienteDocumento { get; set; } = null!;

    public string AfiliadoTitularPoliza { get; set; } = null!;

    public string AfiliadoNumero { get; set; } = null!;

    public string AfiliadoPrimerNombre { get; set; } = null!;

    public string AfiliadoSegundoNombre { get; set; } = null!;

    public string AfiliadoPrimerApellido { get; set; } = null!;

    public string AfiliadoSegundoApellido { get; set; } = null!;

    public DateTime AfiliadoFechaNacimiento { get; set; }

    public string AfiliadoSexo { get; set; } = null!;

    public byte ParentescoNumero { get; set; }

    public string AfiliadoTipoCodigo { get; set; } = null!;

    public string AfiliadoPlanTipo { get; set; } = null!;

    public short NacionalidadNumero { get; set; }

    public int InicioVigenciaFecha { get; set; }

    public int UltimoPagoFactura { get; set; }

    public decimal PrimaComercialMensual { get; set; }

    public byte ModalidadPagoNumero { get; set; }

    public string AfiliadoDiscapacitado { get; set; } = null!;

    public string PromotorDocumento { get; set; } = null!;

    public string AfiliadoEstado { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
