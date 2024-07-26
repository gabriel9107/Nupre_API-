using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssTrabajadoresVistum
{
    /// <summary>
    /// Es el número único que le asigna la Tesorería de la Seguridad Social a cada uno de los empleadores que se registran en dicha institución.    
    /// </summary>
    public int EmpleadorRegistroPatronal { get; set; }

    /// <summary>
    /// Número único que identifica a una persona dentro del SDSS, sobre la cual se nos reporta o registramos un hecho o situación.
    /// </summary>
    public long TrabajadorNss { get; set; }
}
