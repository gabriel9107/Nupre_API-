using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosNucufAltasTran
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
    /// Número de Seguridad Social del Dependiente del titular que solicitó el traspaso por unificación familiar.
    /// </summary>
    public long AfiliadoDependienteNss { get; set; }

    /// <summary>
    /// Cédula del Dependiente del titular que solicitó el traspaso por unificación familiar.
    /// </summary>
    public string AfiliadoDependienteCedula { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el municipio en que fue elaborada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoMunicipio { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará la oficialia en donde fue elaborada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoOficialia { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el libro en donde está registrada el acta de nacimiento.
    /// </summary>
    public string ActaNacimientoLibro { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el folio del acta de nacimiento.
    /// </summary>
    public string ActaNacimientoFolio { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el número del acta de nacimiento.
    /// </summary>
    public string ActaNacimientoNumero { get; set; } = null!;

    /// <summary>
    /// Cuando sea un dependiente sin cédula, se proporcionará el año del acta de nacimiento.
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
    /// Código del parentesco que identifica la relación de un dependiente con su titular.
    /// </summary>
    public byte ParentescoNumero { get; set; }

    /// <summary>
    /// Primer nombre del afiliado.
    /// </summary>
    public string AfiliadoPrimerNombre { get; set; } = null!;

    /// <summary>
    /// Segundo nombre del afiliado.
    /// </summary>
    public string AfiliadoSegundoNombre { get; set; } = null!;

    /// <summary>
    /// Primer apellido del afiliado.
    /// </summary>
    public string AfiliadoPrimerApellido { get; set; } = null!;

    /// <summary>
    /// Segundo apellido del afiliado.
    /// </summary>
    public string AfiliadoSegundoApellido { get; set; } = null!;

    /// <summary>
    /// Indica si el dependiente es estudiante. S = SI y N = NO. (Este campo será obligatorio para el tipo de afiliado dependiente).
    /// </summary>
    public string AfiliadoEstudiante { get; set; } = null!;

    /// <summary>
    /// Indica si el dependiente es o no discapacitado. S = SI y N = NO. (Este campo será obligatorio para el tipo de afiliado dependiente).
    /// </summary>
    public string AfiliadoDiscapacitado { get; set; } = null!;

    /// <summary>
    /// Provincia donde reside el afiliado.
    /// </summary>
    public short ProvinciaNumero { get; set; }

    /// <summary>
    /// Municipio donde reside el afiliado.
    /// </summary>
    public short MunicipioNumero { get; set; }

    /// <summary>
    /// Fecha en que la persona se afilió por primera vez a una ARS.
    /// </summary>
    public DateTime AfiliadoFechaAfiliacionSuir { get; set; }

    /// <summary>
    /// Cantidad de cotizaciones del titular solicitado como dependiente o titular del dependiente solicitado.
    /// </summary>
    public int AfiliadoCantidadCotizaciones { get; set; }

    public virtual SistemasSeguimientosMaster? SistemasSeguimientosMaster { get; set; }
}
