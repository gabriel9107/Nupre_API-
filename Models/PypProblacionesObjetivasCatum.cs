using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de las poblaciones objetivas, a la cuales se da seguimiento del PYP a través del esquema 40, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class PypProblacionesObjetivasCatum
{
    /// <summary>
    /// Número único de la población objetiva, la cual se agrupo por  edades y sexo enfocados en un programa de salud o que puede recibir servicios médicos (Coberturas) específicas.
    /// </summary>
    public byte PoblacionObjetivaNumero { get; set; }

    /// <summary>
    /// Descripción de la población objetiva, la cual se agrupo por edades y sexo enfocados en un programa de salud o que puede recibir servicios médicos (Coberturas) específicas.
    /// </summary>
    public string PoblacionObjetivaDescripcion { get; set; } = null!;

    /// <summary>
    /// Indica si esta población objetiva aplica para el sexo F=Femenino, M=Masculino y A=Ambos (Femenino y Masculino).
    /// </summary>
    public string PoblacionObjetivaSexo { get; set; } = null!;

    /// <summary>
    /// Indica con (S/N) si esta población objetiva aplica para las Madres.
    /// </summary>
    public string PoblacionObjetivaMadres { get; set; } = null!;

    /// <summary>
    /// Indica desde cual edad (Mínima) está dentro de la población objetiva.
    /// </summary>
    public byte PoblacionObjetivaDesde { get; set; }

    /// <summary>
    /// Indica hasta cual edad (Tope) está dentro de la población objetiva.
    /// </summary>
    public byte PoblacionObjetivaHasta { get; set; }

    /// <summary>
    /// Representa para casos especiales una tasa (Factor) a ser aplicado sobre la población total que pertenece a una población objetiva. (La tasa de maternidad del total de mujeres en edad fértil).
    /// </summary>
    public decimal PoblacionObjetivaFactor { get; set; }

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

    public virtual ICollection<PypPoblacionesAnualesTran> PypPoblacionesAnualesTrans { get; set; } = new List<PypPoblacionesAnualesTran>();

    public virtual ICollection<PypSubGruposPoblacionesCatum> PypSubGruposPoblacionesCata { get; set; } = new List<PypSubGruposPoblacionesCatum>();
}
