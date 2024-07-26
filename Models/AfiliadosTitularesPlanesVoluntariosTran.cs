using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional,  que contiene los detalles de los afiliados Titulares a planes voluntarios de las ARS,  su fuente de datos es el esquema 33 procesado por el Robot Simon.
/// </summary>
public partial class AfiliadosTitularesPlanesVoluntariosTran
{
    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Código único de la versión del Plan de servicios de Salud (PDSS) al cual pertenece el Subgrupo.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    public string AfiliadoTitularPoliza { get; set; } = null!;

    /// <summary>
    /// Documento de identificación personal del promotor de servicio de salud que gestiono la afiliación del afiliado a la ARS.
    /// </summary>
    public string PromotorDocumento { get; set; } = null!;

    /// <summary>
    /// Fecha en que un afiliado solicita su afiliación a una Administradora de Riesgos de Salud (ARS) para un Plan de Servicios de Salud (PDSS, Voluntarios, Complementario, Especial, etc.).
    /// </summary>
    public int InicioVigenciaFecha { get; set; }

    /// <summary>
    /// Fecha en que la que se realiza la afiliación de un afiliado a una Administradora de Riesgos de Salud (ARS) para un Plan de Servicios de Salud (PDSS, Voluntarios, Complementario, Especial, etc.).
    /// </summary>
    public int UltimoPagoFactura { get; set; }

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public decimal PrimaComercialMensual { get; set; }

    public byte ModalidadPagoNumero { get; set; }

    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

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

    public virtual AfiliadosModalidadPagoCatum ModalidadPagoNumeroNavigation { get; set; } = null!;

    public virtual PlanesMaster PlanNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
