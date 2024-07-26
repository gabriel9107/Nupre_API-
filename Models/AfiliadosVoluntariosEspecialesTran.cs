using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional que contiene los detalles de los afiliados extranjeros  titulares y dependientes a planes voluntarios en  los planes y carteras de las ARS, su fuente de datos es el  esquema 32  y procesado por el Robot Simon. 
/// </summary>
public partial class AfiliadosVoluntariosEspecialesTran
{
    public int SeguimientoPeriodo { get; set; }

    /// <summary>
    /// Número único que identifica a la ARS que reporto el hecho o a la cual pertenecía el afiliado sobre el cual se reporto o registro un hecho o situación.
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Código único de la versión del Plan de servicios de Salud (PDSS) al cual pertenece el Subgrupo.
    /// </summary>
    public string PlanNumero { get; set; } = null!;

    public string AfiliadoTitularDocumento { get; set; } = null!;

    public string AfiliadoDependienteDocumento { get; set; } = null!;

    /// <summary>
    /// Número de contrato o póliza que asigna cada ARS a cada uno de sus afiliados, puede ser representado por el número acreditado de formulario de afiliación.
    /// </summary>
    public string AfiliadoTitularPoliza { get; set; } = null!;

    /// <summary>
    /// Número de contrato o póliza que asigna cada ARS a cada uno de sus afiliados, puede ser representado por el número acreditado de formulario de afiliación.
    /// </summary>
    public string AfiliadoNumero { get; set; } = null!;

    /// <summary>
    /// Nombre completo del afiliado que está en el proceso de traspaso donde  se determino una  condición de enfermedad (CDE).
    /// </summary>
    public string AfiliadoNombre { get; set; } = null!;

    /// <summary>
    /// Es la fecha de nacimiento de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public DateTime AfiliadoFechaNacimiento { get; set; }

    /// <summary>
    /// Sexo de la persona (Afiliado)  (F=femenino, M=masculino).
    /// </summary>
    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Número único que representa el parentesco entre un dependiente y el titular de un núcleo familiar en el Seguro Familiar de Salud (SFS).
    /// </summary>
    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Es el código que clasifica los afiliados en T = Titulares (Quien representa al núcleo familiar) D = Dependientes  (Hijos y Conjugues) y A = Adicionales (Padres, Hijos con mayoría de edad cumplida 18 o 21, otros familiares dependientes económicamente).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    public string AfiliadoPlanTipo { get; set; } = null!;

    /// <summary>
    /// Número único que representa la nacionalidad de la persona o afiliado.
    /// </summary>
    public short NacionalidadNumero { get; set; }

    public int InicioVigenciaFecha { get; set; }

    public int UltimoPagoFactura { get; set; }

    public decimal PrimaComercialMensual { get; set; }

    public byte ModalidadPagoNumero { get; set; }

    /// <summary>
    /// Indica con (S/N) si el afiliado es un discapacitado.
    /// </summary>
    public string AfiliadoDiscapacitado { get; set; } = null!;

    /// <summary>
    /// Documento de identificación personal del promotor de servicio de salud que gestiono la afiliación del afiliado a la ARS.
    /// </summary>
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

    public virtual AfiliadosTipoCatum AfiliadoTipoCodigoNavigation { get; set; } = null!;

    public virtual ArsMaster ArsNumeroNavigation { get; set; } = null!;

    public virtual AfiliadosModalidadPagoCatum ModalidadPagoNumeroNavigation { get; set; } = null!;

    public virtual TssNacionalidadesCatum NacionalidadNumeroNavigation { get; set; } = null!;

    public virtual AfiliadosParentescoCatum ParentescoNumeroNavigation { get; set; } = null!;

    public virtual PlanesMaster PlanNumeroNavigation { get; set; } = null!;

    public virtual SeguimientosLotesTran Seguimiento { get; set; } = null!;
}
