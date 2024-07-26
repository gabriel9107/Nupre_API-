using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional en donde se registran los Promotores vinculado a una Promotora de Salud, en esta tabla se identifica con S si el Promotor es representan de una Promotora con una S, si este no es representante se marca con una N.
/// </summary>
public partial class AuditoresAuditorasRepresentantesTran
{
    public string PromotorCedula { get; set; } = null!;

    /// <summary>
    /// Es el número único que le asigna la Tesorería de la Seguridad Social a cada uno de los empleadores que se registran en dicha institución.    
    /// </summary>
    public int PromotoraRegistroPatronal { get; set; }

    /// <summary>
    /// Indica si el Promotor de Salud es un Representante de la Promotora (S = Si, N = No).
    /// </summary>
    public string PromotorRepresentante { get; set; } = null!;

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
}
