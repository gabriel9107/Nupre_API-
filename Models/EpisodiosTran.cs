using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class EpisodiosTran
{
    public byte ArsNumero { get; set; }

    public int PrestadoraNumero { get; set; }

    public long AfiliadoNss { get; set; }

    public int EpisodioFechaRealizacion { get; set; }

    public int EpisodioFechaPago { get; set; }

    public int EpisodioDetalleSecuencia { get; set; }

    public int EpisodioFechaAutorizacion { get; set; }

    public int EpisodioFechaApertura { get; set; }

    public int EpisodioFechaEgreso { get; set; }

    public string AtencionTipoCodigo { get; set; } = null!;

    public string ServicioTipoCodigo { get; set; } = null!;

    public string PlanNumero { get; set; } = null!;

    public string SubGrupoCodigo { get; set; } = null!;

    public short CoberturaNumero { get; set; }

    public decimal EpisodioDetalleMontoReclamado { get; set; }

    public decimal EpisodioDetalleMontoPagadoArs { get; set; }

    public decimal EpisodioDetalleMontoPagadoAfiliado { get; set; }

    public string EgresoTipoCodigo { get; set; } = null!;

    public long SeguimientoCodigo { get; set; }

    public byte SeguimientoLote { get; set; }

    public long EpisodioNumero { get; set; }

    public string EpisodioAutorizacionNumero { get; set; } = null!;

    public long AfiliadoNumeroUnico { get; set; }

    public string EpisodioRecienNacido { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual TssCiudadanosMaster AfiliadoNssNavigation { get; set; } = null!;

    public virtual EpisodiosAtencionesTipoCatum AtencionTipoCodigoNavigation { get; set; } = null!;

    public virtual CoberturasMaster CoberturaNumeroNavigation { get; set; } = null!;

    public virtual EpisodiosEgresosTipoCatum EgresoTipoCodigoNavigation { get; set; } = null!;

    public virtual PrestadorasMaster PrestadoraNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;

    public virtual EpisodiosServiciosTipoCatum ServicioTipoCodigoNavigation { get; set; } = null!;
}
