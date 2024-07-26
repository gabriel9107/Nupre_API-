﻿using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de las poblaciones estimadas por año y ARS, para calcular las metas trimestrales para el seguimiento del PYP a través del esquema 40, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PypPoblacionesAnualesTran
{
    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Año correspondiente a la información o hechos que deben ser reportados mediante una carga de informe (Esquema) para un número de seguimiento específico.
    /// </summary>
    public short SeguimientoAnio { get; set; }

    /// <summary>
    /// Número único de la población objetiva, la cual se agrupo por  edades y sexo enfocados en un programa de salud o que puede recibir servicios médicos (Coberturas) específicas.
    /// </summary>
    public byte PoblacionObjetivaNumero { get; set; }

    /// <summary>
    /// Nos indica cual será la población proyectada de afiliados para una ARS, en un año y población objetiva especifica.
    /// </summary>
    public int PoblacionObjetivaAnual { get; set; }

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual PypProblacionesObjetivasCatum PoblacionObjetivaNumeroNavigation { get; set; } = null!;

    public virtual ICollection<PypSeguimientosActividadesTran> PypSeguimientosActividadesTrans { get; set; } = new List<PypSeguimientosActividadesTran>();

    public virtual ICollection<PypSeguimientosMensualesTran> PypSeguimientosMensualesTrans { get; set; } = new List<PypSeguimientosMensualesTran>();

    public virtual ICollection<PypSeguimientosTrimestralesTran> PypSeguimientosTrimestralesTrans { get; set; } = new List<PypSeguimientosTrimestralesTran>();
}
