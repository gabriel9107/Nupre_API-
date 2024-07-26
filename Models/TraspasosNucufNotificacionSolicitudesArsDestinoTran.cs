using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNucufNotificacionSolicitudesArsDestinoTran
{
    public int SeguimientoNumero { get; set; }

    public string RegistroTipoCodigo { get; set; } = null!;

    public byte TraspasoTipoCodigo { get; set; }

    public long Nucuf { get; set; }

    public byte RechazoNumero { get; set; }

    public long AfiliadoNss { get; set; }

    public string AfiliadoCedula { get; set; } = null!;

    public string ActaNacimientoMunicipio { get; set; } = null!;

    public string ActaNacimientoOficialia { get; set; } = null!;

    public string ActaNacimientoLibro { get; set; } = null!;

    public string ActaNacimientoFolio { get; set; } = null!;

    public string ActaNacimientoNumero { get; set; } = null!;

    public string ActaNacimientoAnio { get; set; } = null!;

    public string AfiliadoSexo { get; set; } = null!;

    public byte ParentescoNumero { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string MotivoRespuesta { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
