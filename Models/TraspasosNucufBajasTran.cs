using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNucufBajasTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico.
    /// </summary>
    public int SeguimientoNumero { get; set; }

    /// <summary>
    /// Identificador del tipo de registro (Constante = D).
    /// </summary>
    public string RegistroTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Indica el Número del tipo de traspaso.
    /// </summary>
    public byte TraspasoTipoNumero { get; set; }

    /// <summary>
    /// Número Unico de Control de Unificación de Núcleo Familiar con el cual fue autorizado el traspaso.
    /// </summary>
    public long Nucuf { get; set; }

    /// <summary>
    /// Indica si el afiliado es un dependiente o un titular (T = Titular, D = Dependiente, A = Dependiente Adicional).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del titular que solicitó el traspaso por unificación familiar.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Cédula del titular que solicitó el traspaso por unificación familiar.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del afiliado solicitado para el traspaso para unificación de núcleo familiar (Solo será obligatorio si el dependiente esta activo).
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Cédula del afiliado que fue solicitado para el Traspaso para Unificación del Núcleo Familiar o NUI en caso de ser dependiente menor de edad.
    /// </summary>
    public string AfiliadoCedula { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento del afiliado.
    /// </summary>
    public DateTime AfiliadoFechaNacimiento { get; set; }

    /// <summary>
    /// Sexo del afiliado.
    /// </summary>
    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Código del parentesco que identifica la relación de un dependiente con su titular (Será obligatorio si el tipo de afiliados es un dependiente).
    /// </summary>
    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Número de lote donde se cargó el afiliado (Solo tendrá valor cuando el estatus del afiliado sea Provisional (PE).
    /// </summary>
    public byte LoteCargaNumero { get; set; }

    /// <summary>
    /// Número de Id de registro de la posición donde se encuentra el afiliado cargado. (Solo tendrá valor cuando el estatus del afiliado sea Provisional PE).
    /// </summary>
    public byte RegistroCargaNumero { get; set; }

    /// <summary>
    /// Indica el estatus en que será marcado el registro por ser rechazado (constante = RE).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el motivo del rechazo del registro en el SUIR según catálogo de motivos del SUIR.
    /// </summary>
    public string RechazoMotivoCodigo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
