using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SysDiagramsProfesionale
{
    public string Name { get; set; } = null!;

    public int PrincipalId { get; set; }

    public int DiagramId { get; set; }

    public int? Version { get; set; }

    public byte? Definition { get; set; }
}
