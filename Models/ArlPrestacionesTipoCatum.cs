using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene el tipo de prestación económica pagada,  utilizado por la ARL para reportar los detalles de los prestaciones económicas, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ArlPrestacionesTipoCatum
{
    /// <summary>
    /// Número único asignado a tipo de prestación que califica a un pago de prestaciones económica de un trabajador o beneficiario de este,  por la ARL.
    /// </summary>
    public byte PrestacionTipoNumero { get; set; }

    /// <summary>
    /// Descripción  del tipo de prestación que califica a un pago de prestaciones económica de un trabajador o beneficiario de este,  por la ARL.
    /// </summary>
    public string PrestacionTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de la descripción  del tipo de prestación que califica a un pago de prestaciones económica de un trabajador o beneficiario de este,  por la ARL.
    /// </summary>
    public string PrestacionTipoExplicacion { get; set; } = null!;

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

    public virtual ICollection<ArlPrestacionesEconomicasTran> ArlPrestacionesEconomicasTrans { get; set; } = new List<ArlPrestacionesEconomicasTran>();
}
