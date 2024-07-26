using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class UnisigmaImpedimentosSolicitudTraspaso
{
    public long NotificacionSecuencia { get; set; }

    public long? NotificacionImpedimentoTraspasoId { get; set; }

    public int? TipoTraspasoId { get; set; }

    public string? TipoFormularioTraspaso { get; set; }

    public long? NumeroSolicitudTraspaso { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public int? TipoParticipacion { get; set; }

    public string? CodigosImpedimentoTraspaso { get; set; }

    public string? TipoAfiliado { get; set; }

    public long? Nss { get; set; }

    public string? Cedula { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public int? ParentescoId { get; set; }

    public string? Estado { get; set; }

    public string? MotivoEstado { get; set; }

    public int? CodigoAccionEventoTraspaso { get; set; }

    public int? CodigoImpedimentoTraspaso { get; set; }
}
