using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ComunesFechasMaster
{
    public int FechaNumero { get; set; }

    public int PeriodoNumero { get; set; }

    public DateTime Fecha { get; set; }

    public int Anio { get; set; }

    public int Mes { get; set; }

    public int Dia { get; set; }

    public int Semana { get; set; }

    public int Cuatrimestre { get; set; }

    public int Trimestre { get; set; }

    public int DiaAnio { get; set; }

    public int DiaSemana { get; set; }

    public string MesLetra { get; set; } = null!;

    public string MesLetraCorto { get; set; } = null!;

    public string DiaSemanaLetra { get; set; } = null!;

    public string DiaSemanaLetraCorto { get; set; } = null!;

    public string DiaFeriado { get; set; } = null!;

    public string FechaLetra { get; set; } = null!;
}
