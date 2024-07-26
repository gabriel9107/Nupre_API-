using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional,  que contiene los detalles de los afiliados Dependientes a planes voluntarios de las ARS,  su fuente de datos es el esquema 34 procesado por el Robot Simon. 
/// </summary>
public partial class AfiliadosDependientesPlanesVoluntariosTran
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

    /// <summary>
    /// Es único número de documento de identificación oficial (Cedula, residencia, Pasaporte, etc.) de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoDependienteDocumento { get; set; } = null!;

    public string AfiliadoTitularPoliza { get; set; } = null!;

    /// <summary>
    /// Es el nombre propio de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string AfiliadoNombre { get; set; } = null!;

    /// <summary>
    /// Sexo de la persona (Afiliado)  (F=femenino, M=masculino).
    /// </summary>
    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Número único que representa el parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public byte ParentescoNumero { get; set; }

    public string AfiliadoPlanTipo { get; set; } = null!;

    /// <summary>
    /// Número único del tipo de documento de identificación personal con el cual se registro el afiliado en la ARS para un Plan de Servicios de Salud (PDSS, Voluntarios, Complementario, Especial, etc.).
    /// </summary>
    public byte DocumentoTipoNumero { get; set; }

    /// <summary>
    /// Indica con (S/N) si el afiliado es un discapacitado.
    /// </summary>
    public string AfiliadoDiscapacitado { get; set; } = null!;

    /// <summary>
    /// Fecha en que un afiliado solicita su afiliación a una Administradora de Riesgos de Salud (ARS) para un Plan de Servicios de Salud (PDSS, Voluntarios, Complementario, Especial, etc.).
    /// </summary>
    public int InicioVigenciaFecha { get; set; }

    /// <summary>
    /// Indica con (S/N) si el afiliado es estudiante.
    /// </summary>
    public int UltimoPagoFactura { get; set; }

    /// <summary>
    /// Número único del municipio según catálogo de la JCE. (Donde está ubicado una entidad o persona, o sucedió un hecho).
    /// </summary>
    public decimal PrimaComercialMensual { get; set; }

    public byte ModalidadPagoNumero { get; set; }

    public string PromotorDocumento { get; set; } = null!;

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

    public virtual AfiliadosDocumentosTipoCatum DocumentoTipoNumeroNavigation { get; set; } = null!;

    public virtual AfiliadosModalidadPagoCatum ModalidadPagoNumeroNavigation { get; set; } = null!;

    public virtual AfiliadosParentescoCatum ParentescoNumeroNavigation { get; set; } = null!;

    public virtual PlanesMaster PlanNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
