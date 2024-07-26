using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class AcreditacionesPersonasMasterVistum
{
    public long PersonaNss { get; set; }

    public long EmpleadorRegistroPatronal { get; set; }

    public byte ArsNumero { get; set; }

    public short EntidadNumero { get; set; }

    public string PersonaCedula { get; set; } = null!;

    public string PersonaCedulaFormateada { get; set; } = null!;

    public string PersonaNombreCompleto { get; set; } = null!;

    public short ExamenNumero { get; set; }

    public short PeriodoNumero { get; set; }

    public DateTime ExamenFechaInicio { get; set; }

    public DateTime ExamenFechaFin { get; set; }

    public byte ExamenResultado { get; set; }

    public string ArsNombre { get; set; } = null!;

    public string PersonaRepresentaPromotora { get; set; } = null!;

    public byte AcreditacionCategoriaNumero { get; set; }

    public string AcreditacionCategoriaDescripcion { get; set; } = null!;

    public byte AcreditacionClaseNumero { get; set; }

    public string? AcreditacionClaseDescripcion { get; set; }

    public string AcreditacionCategoriaClaseDescripcion { get; set; } = null!;

    public byte NivelAcademicoNumero { get; set; }

    public string NivelAcademicoDescripcion { get; set; } = null!;

    public DateTime PersonaFechaAcreditacion { get; set; }

    public DateTime PersonaFechaRenovacion { get; set; }

    public DateTime PersonaFechaVencimiento { get; set; }

    public byte AcreditacionEstadoNumero { get; set; }

    public string AcreditacionEstadoDescripcion { get; set; } = null!;

    public string PersonaObservacion { get; set; } = null!;

    public string EntidadNombre { get; set; } = null!;

    public string EntidadRnc { get; set; } = null!;

    public DateTime EntidadFechaAcreditacion { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }
}
