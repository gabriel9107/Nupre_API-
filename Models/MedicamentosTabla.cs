﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class MedicamentosTabla
{
    public long MedicamentoSecuencia { get; set; }

    public string MedicamentoRegistroSanitario { get; set; } = null!;

    public string MedicamentoProducto { get; set; } = null!;

    public string MedicamentoPrincipiosActivos { get; set; } = null!;

    public string? MedicamentoPrincipiosActivosRev { get; set; }

    public string MedicamentoFormaFarmaceutica { get; set; } = null!;

    public string MedicamentoEnvase { get; set; } = null!;

    public string MedicamentoConcentracion { get; set; } = null!;

    public DateTime MedicamentoRegistroVencimiento { get; set; }

    public string MedicamentoRegistroEstatus { get; set; } = null!;

    public string MedicamentoRepresentante { get; set; } = null!;

    public string MedicamentoTipo { get; set; } = null!;

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public string? MedicamentoPdss { get; set; }
}
