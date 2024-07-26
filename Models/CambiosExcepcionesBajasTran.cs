using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class CambiosExcepcionesBajasTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public int SeguimientoNumero { get; set; }

    /// <summary>
    /// Identificador del tipo de registro (Constante = D).
    /// </summary>
    public string RegistroTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Código del tipo de motivo de cambio por el cual el afiliado cambió de ARS o de tipo.
    /// </summary>
    public byte MotivoCambioNumero { get; set; }

    /// <summary>
    /// Número único de Solicitud de Cambio por Excepción con el cual fue autorizado el cambio.
    /// </summary>
    public int SolicitudCambioNumero { get; set; }

    /// <summary>
    /// Indica el tipo de afiliado (T = Titular, D = Dependiente Directo, A = Dependiente Adicional).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del titular que solicitó el cambio de ARS o Tipo.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Cédula del titular que solicitó el cambio de ARS o tipo.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del dependiente solicitante o solicitado para el cambio de ARS o tipo
    /// </summary>
    public long AfiliadoDependienteNss { get; set; }

    /// <summary>
    /// Cédula del Dependiente solicitante o solicitado para el cambio de ARS o de tipo.
    /// </summary>
    public string AfiliadoDependienteCedula { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento del afiliado.
    /// </summary>
    public DateTime AfiliadoFechaNacimiento { get; set; }

    /// <summary>
    /// Sexo del afiliado.
    /// </summary>
    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Código del parentesco que identifica la relación de un dependiente con su titular.
    /// </summary>
    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Número del lote donde se cargó el afiliado (Solo tendrá valor cuando el tipo del afiliado dea Pendiente o corresponda a un afiliado que haya sido validado contra nómina.
    /// </summary>
    public int LoteCargaNumero { get; set; }

    /// <summary>
    /// Número de Id registro de la posición donde se encuentra el afiliado cargado (Solo tendrá valor cuando el tipo del afiliado dea Pendiente o corresponda a un afiliado que haya sido validado contra nómina).
    /// </summary>
    public int RegistroCargaId { get; set; }

    /// <summary>
    /// Indica el estatus en que será marcado el registro por ser rechazado (RE = Rechazado).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el motivo del rechazo del registro en el SUIR según catálogo de motivos del SUIR.
    /// </summary>
    public string MotivoRechazo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster SeguimientoNumeroNavigation { get; set; } = null!;
}
