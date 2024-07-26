using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional donde se registran los detalles relacionados con un  traspaso donde se determino una  condición de enfermedad (CDE), su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class TraspasosFormulariosCdeDetallesTran
{
    /// <summary>
    /// Número único del formulario de condición de enfermedad (CDE) con el cual se registro el caso para el afiliado en el proceso de traspaso.
    /// </summary>
    public int FormularioCdeNumero { get; set; }

    /// <summary>
    /// Número único del grupo al cual pertenece el Subgrupo del PDSS.
    /// </summary>
    public byte GrupoNumero { get; set; }

    /// <summary>
    /// Numero único de cobertura que representa un  insumo, procedimiento médico, material, fármaco,  servicio  general que fue o puede ser prestado.
    /// </summary>
    public int CoberturaNumero { get; set; }

    /// <summary>
    /// Fecha en que fue diagnosticado el afiliado que está en el proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public DateTime FormularioCdeFechaDiagnostico { get; set; }

    /// <summary>
    /// Fecha programada para la intervención o tratamiento que se va a aplicar al afiliado que está en el  proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public DateTime FormularioCdeFechaProgramada { get; set; }

    public string FormularioArchivoNombre { get; set; } = null!;

    /// <summary>
    /// Detalles del usuario de la ARS  y IP donde se registro una  condición de enfermedad (CDE) del proceso de traspaso.
    /// </summary>
    public string FormularioCdeUsuario { get; set; } = null!;

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

    public virtual TraspasosFormulariosCdeTran FormularioCdeNumeroNavigation { get; set; } = null!;

    public virtual TraspasosProcedimientosVistum TraspasosProcedimientosVistum { get; set; } = null!;
}
