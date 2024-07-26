using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SistemasAlertasMaster
{
    public int AlertaNumero { get; set; }

    public byte? CorreoPlantillaNumero { get; set; }

    public string? AlertaDescripcion { get; set; }

    public string? AlertaExplicacion { get; set; }

    public string? AlertaMensaje { get; set; }

    public string? AlertaEnviaCorreo { get; set; }

    public byte? GrupoSeguridadNumero { get; set; }

    public DateTime? AlertaUltimaCorridaFecha { get; set; }

    public DateTime? AlertaProximaCorridaFecha { get; set; }

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

    public virtual SistemasAlertasPeriodicidadesTran AlertaNumeroNavigation { get; set; } = null!;

    public virtual SistemasCorreosPlantillasCatum? CorreoPlantillaNumeroNavigation { get; set; }

    public virtual ICollection<SistemasAlertasFrecuenciasCatum> SistemasAlertasFrecuenciasCata { get; set; } = new List<SistemasAlertasFrecuenciasCatum>();

    public virtual ICollection<SistemasAlertasTran> SistemasAlertasTrans { get; set; } = new List<SistemasAlertasTran>();
}
