using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CambiosExcepcionesSolicitudesTran
{
    public int SeguimientoNumero { get; set; }

    public string RegistroTipoCodigo { get; set; } = null!;

    public byte MotivoCambioNumero { get; set; }

    public int SolicitudCambioNumero { get; set; }

    public string AfiliadoTipoCodigo { get; set; } = null!;

    public long AfiliadoTitularNss { get; set; }

    public string AfiliadoTitularCedula { get; set; } = null!;

    public long AfiliadoDependienteNss { get; set; }

    public string AfiliadoDependienteCedula { get; set; } = null!;

    public DateTime AfiliadoFechaNacimiento { get; set; }

    public string AfiliadoSexo { get; set; } = null!;

    public short ArsOrigenNumero { get; set; }

    public short ArsDestinoNumero { get; set; }

    public long AfiliadoTitularNuevoNss { get; set; }

    public string AfiliadoTitularNuevoCedula { get; set; } = null!;

    public short ParentescoNumeroAAfiliarse { get; set; }

    public string AfiliadoDependienteTipoCodigoAAfiliarse { get; set; } = null!;

    public string AfiliadoEstudiante { get; set; } = null!;

    public string AfiliadoDiscapacitado { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RespuestaCodigo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster SeguimientoNumeroNavigation { get; set; } = null!;
}
