using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosDiagnosticosSubsidiadosTran
{
    public long EpisodioNumero { get; set; }

    public int SeguimientoPeriodo { get; set; }

    public byte ArsNumero { get; set; }

    public int PrestadoraNumero { get; set; }

    public long AfiliadoNss { get; set; }

    public int EpisodioFechaRealizacion { get; set; }

    public int EpisodioFechaEgreso { get; set; }

    public string PlanNumero { get; set; } = null!;

    public string EgresoTipoCodigo { get; set; } = null!;

    public string AtencionTipoCodigo { get; set; } = null!;

    public string ServicioTipoCodigo { get; set; } = null!;

    public string SubgrupoCodigo { get; set; } = null!;

    public string Cie10CodigoPrincipal { get; set; } = null!;

    public string Cie10CodigoSecundario1 { get; set; } = null!;

    public string Cie10CodigoSecundario2 { get; set; } = null!;

    public string Cie10CodigoComplicaciones { get; set; } = null!;

    public string Cie10CodigoFallecimiento { get; set; } = null!;

    public string Cie10CodigoMuerteRecienNacido { get; set; } = null!;

    public byte EpisodioRecienNacidoVivo { get; set; }

    public byte EpisodioRecienNacidoMuerto { get; set; }

    public string EpisodioMenorNoRegistrado { get; set; } = null!;

    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual TssCiudadanosMaster AfiliadoNssNavigation { get; set; } = null!;

    public virtual EpisodiosAtencionesTipoCatum AtencionTipoCodigoNavigation { get; set; } = null!;

    public virtual ComunesCie10DiagnosticosCatum Cie10CodigoPrincipalNavigation { get; set; } = null!;

    public virtual EpisodiosEgresosTipoCatum EgresoTipoCodigoNavigation { get; set; } = null!;

    public virtual PrestadorasMaster PrestadoraNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;

    public virtual EpisodiosServiciosTipoCatum ServicioTipoCodigoNavigation { get; set; } = null!;
}
