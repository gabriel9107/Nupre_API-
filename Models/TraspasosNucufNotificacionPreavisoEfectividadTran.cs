using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNucufNotificacionPreavisoEfectividadTran
{
    public int SeguimientoNumero { get; set; }

    public string RegistroTipoCodigo { get; set; } = null!;

    public byte TraspasoTipoNumero { get; set; }

    public long Nucuf { get; set; }

    public long AfiliadoTitularNss { get; set; }

    public DateTime TraspasoEfectividadFecha { get; set; }

    public string AfiliadoTipoCodigo { get; set; } = null!;

    public long AfiliadoDependienteNss { get; set; }

    public string AfiliadoDependienteCedula { get; set; } = null!;

    public string ActaNacimientoMunicipio { get; set; } = null!;

    public string ActaNacimientoOficialia { get; set; } = null!;

    public string ActaNacimientoLibro { get; set; } = null!;

    public string ActaNacimientoFolio { get; set; } = null!;

    public string ActaNacimientoNumero { get; set; } = null!;

    public string ActaNacimientoAnio { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
