using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PlanesArsVistum
{
    public string PlanNumero { get; set; } = null!;

    public byte ArsNumero { get; set; }

    public string ArsNombre { get; set; } = null!;

    public string PlanNombre { get; set; } = null!;

    public string PlanEstadoCodigo { get; set; } = null!;

    public string PlanTipoCodigo { get; set; } = null!;

    public string PlanTipoDescripcion { get; set; } = null!;

    public byte PlanModalidadNumero { get; set; }

    public string PlanModalidadDescripcion { get; set; } = null!;

    public string PlanDescripcion { get; set; } = null!;

    public DateTime PlanFechaAprobacion { get; set; }

    public DateTime PlanFechaInicioAplicacion { get; set; }

    public DateTime PlanFechaTerminoAplicacion { get; set; }

    public decimal PlanPrimaAnual { get; set; }
}
