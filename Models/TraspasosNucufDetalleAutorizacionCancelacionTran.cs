using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNucufDetalleAutorizacionCancelacionTran
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
    /// Número de Seguridad Social del titular que solicitó el traspaso por unificación familiar.
    /// </summary>
    public long AfiliadoTitularNss { get; set; }

    /// <summary>
    /// Cédula del titular que solicitó el traspaso por unificación familiar.
    /// </summary>
    public string AfiliadoTitularCedula { get; set; } = null!;

    /// <summary>
    /// Indica el tipo de afiliado (Posibles valores: T = Titular, D = Dependiente Directo, A = Dependiente Adicional).
    /// </summary>
    public string AfiliadoTipoCodigo { get; set; } = null!;

    /// <summary>
    /// Número de Seguridad Social del Afiliado solicitado en el traspaso.
    /// </summary>
    public long AfiliadoNss { get; set; }

    /// <summary>
    /// Cédula del afiliado que fue solicitado para el Traspaso para Unificación Núcleo Familiar o NUI en caso de ser dependiente menor de edad.
    /// </summary>
    public string AfiliadoCedula { get; set; } = null!;

    /// <summary>
    /// Cuando sea un afiliado si cédula ni NSS, se proporcionará el municipio en que fue elaborada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoMunicipio { get; set; } = null!;

    /// <summary>
    /// Cuando sea un afiliado si cédula ni NSS, se proporcionará la oficialia en que fue elaborada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoOficialia { get; set; } = null!;

    /// <summary>
    /// Cuando sea un afiliado si cédula ni NSS, se proporcionará el libro en que fue elaborada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoLibro { get; set; } = null!;

    /// <summary>
    /// Cuando sea un afiliado si cédula ni NSS, se proporcionará el folio en que fue elaborada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoFolio { get; set; } = null!;

    /// <summary>
    /// Cuando sea un afiliado si cédula ni NSS, se proporcionará el número del acta de nacimiento.
    /// </summary>
    public string ActaNacimientoNumero { get; set; } = null!;

    /// <summary>
    /// Cuando sea un afiliado si cédula ni NSS, se proporcionará el año del acta de nacimiento.
    /// </summary>
    public string ActaNacimientoAnio { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento del afiliado.
    /// </summary>
    public DateTime AfiliadoFechaNacimiento { get; set; }

    /// <summary>
    /// Sexo del afiliado.
    /// </summary>
    public string AfiliadoSexo { get; set; } = null!;

    /// <summary>
    /// Código del parentesco que identifica la relación de un dependiente con su titular (será obligatorio si el tipo de afiliado es un dependiente).
    /// </summary>
    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Código que indica la acción de SISALRIL (1 = Autorización, 2 = Cancelación, 3 = Cancelación NUCUF, 0 = No Especifiado).
    /// </summary>
    public byte AccionSisalrilNumero { get; set; }

    /// <summary>
    /// Código que indica el detalle de la acción tomada por la SISALRIL.
    /// </summary>
    public byte MotivoNumero { get; set; }

    /// <summary>
    /// Identifica cual es el tipo de ARS con relación al afiliado (posibles valores O = ARS Origen, D = ARS Destino).
    /// </summary>
    public string ArsTipoCodigo { get; set; } = null!;

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
