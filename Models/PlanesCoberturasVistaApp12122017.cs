using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class PlanesCoberturasVistaApp12122017
{
    public string PlanNumero { get; set; } = null!;

    public string PlanNombre { get; set; } = null!;

    public byte GrupoNumero { get; set; }

    public string GrupoDescripcion { get; set; } = null!;

    public string GrupoExplicacion { get; set; } = null!;

    public byte SubGrupoNumero { get; set; }

    public string SubGrupoCodigo { get; set; } = null!;

    public string SubGrupoDescripcion { get; set; } = null!;

    public string SubgrupoExplicacion { get; set; } = null!;

    public byte SubGrupoAreaNumero { get; set; }

    public string SubGrupoAreaDescripcion { get; set; } = null!;

    public byte SubGrupoServicioNumero { get; set; }

    public string SubGrupoServicioDescripcion { get; set; } = null!;

    public byte SubGrupoPoblacionNumero { get; set; }

    public string SubGrupoPoblacionDescripcion { get; set; } = null!;

    public string ProblacionDetalle { get; set; } = null!;

    public byte SubGrupoCuotaTipoNumero { get; set; }

    public string SubGrupoCuotaTipoDescripcion { get; set; } = null!;

    public byte SubGrupoCoberturaTipoNumero { get; set; }

    public string SubGrupoCoberturaTipoDescripcion { get; set; } = null!;

    public decimal SubGrupoCoberturaTope { get; set; }

    public decimal SubgrupoCuotaArsPorciento { get; set; }

    public decimal SubGrupoCuotaAfiliadoPorciento { get; set; }

    public decimal SubGrupoCuotaAfiliadoFija { get; set; }

    public decimal SubGrupoCuotaAfiliadoTope { get; set; }

    public short CoberturaNumero { get; set; }

    public string CoberturaDescripcion { get; set; } = null!;

    public byte CoberturaTipoNumero { get; set; }

    public string CoberturaTipoDescripcion { get; set; } = null!;

    public string CupsCodigo { get; set; } = null!;

    public string CupsDetalle { get; set; } = null!;

    public string ServicioDescripcionCorta { get; set; } = null!;

    public string CoberturaPdss { get; set; } = null!;

    public string CoberturaCubreArs { get; set; } = null!;

    public string CoberturaCubreAfiliado { get; set; } = null!;

    public string CoberturaUnico { get; set; } = null!;

    public string CoberturaTexto { get; set; } = null!;
}
