using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo de los diferentes tipo de afiliados para el SFS, su fuente de alimentación son las vistas estadísticas de UNIPAGO.
/// </summary>
public partial class AfiliadosTipoCatum
{
    /// <summary>
    /// Es el código que clasifica los afiliados en T = Titulares (Quien representa al núcleo familiar) D = Dependientes  (Hijos y Conjugues) y A = Adicionales (Padres, Hijos con mayoría de edad cumplida 18 o 21, otros familiares dependientes económicamente).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Clasifica los afiliados en Titulares (Quien representa al núcleo familiar) dependientes directos (Hijos y Conjugues) y Adicionales (Padres, Hijos con mayoría de edad cumplida 18 o 21, otros familiares dependientes económicamente).
    /// </summary>
    public string AfiliadoTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de la clasificación de los afiliados en Titulares (Quien representa al núcleo familiar) dependientes directos (Hijos y Conjugues) y Adicionales (Padres, Hijos con mayoría de edad cumplida 18 o 21, otros familiares dependientes económicamente).
    /// </summary>
    public string AfiliadoTipoExplicacion { get; set; } = null!;

    /// <summary>
    /// Es la descripción abreviada que clasifica los afiliados en TIT=Titulares, DEP=Dependientes y ADI=Adicionales.
    /// </summary>
    public string AfiliadoTipoDescripcionCorta { get; set; } = null!;

    /// <summary>
    /// Es la descripción que clasifica los afiliados en Titulares, Dependientes y Adicionales.
    /// </summary>
    public string AfiliadoTipoTitulo { get; set; } = null!;

    /// <summary>
    /// Número único de clasificación de afiliado (Titular, Dependiente y Adicional), , su objetivo es ser utilizados en futuras conversiones hacia el DATA WAREHOUSE.
    /// </summary>
    public byte AfiliadoTipoNumero { get; set; }

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

    public virtual ICollection<AfiliadosPlanesComplementariosTran> AfiliadosPlanesComplementariosTrans { get; set; } = new List<AfiliadosPlanesComplementariosTran>();

    public virtual ICollection<AfiliadosSfsMaster> AfiliadosSfsMasters { get; set; } = new List<AfiliadosSfsMaster>();

    public virtual ICollection<AfiliadosVoluntariosEspecialesTran> AfiliadosVoluntariosEspecialesTrans { get; set; } = new List<AfiliadosVoluntariosEspecialesTran>();

    public virtual ICollection<TraspasosFormulariosCdeTran> TraspasosFormulariosCdeTrans { get; set; } = new List<TraspasosFormulariosCdeTran>();
}
