using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TssPensionadosMaster
{
    /// <summary>
    /// Codigó del pensionado
    /// </summary>
    public int PensionadoNumero { get; set; }

    /// <summary>
    /// Codigó de la institución donde fue pensionado
    /// </summary>
    public byte InstitucionNumero { get; set; }

    /// <summary>
    /// Número de documento provisto por SEH (Cédula en el caso de Dominicano) 
    /// </summary>
    public string PensionadoDocumentoNo { get; set; } = null!;

    /// <summary>
    /// Nombre del pensionado
    /// </summary>
    public string PensionadoNombre { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento (Es necesario para los indocumentados)
    /// </summary>
    public DateTime? PensionadoFechaNacimiento { get; set; }

    /// <summary>
    /// Direccion provista por la SEH
    /// </summary>
    public string PensionadoDireccion { get; set; } = null!;

    /// <summary>
    /// Número provisto por la SEH
    /// </summary>
    public string PensionadoTelefono { get; set; } = null!;

    /// <summary>
    /// OK= Avtivo, BA= Debaja de la cartera, AF = Pendiente de ser afiliado,  PE = Pendiente de completar la documentacion electronica, CA= Cancelado
    /// </summary>
    public string StatusCodigo { get; set; } = null!;

    /// <summary>
    /// ID que representa el numero de seguridad social creado en la tabla SRS_CIAUDADANOS_T
    /// </summary>
    public long CiudadanoNss { get; set; }

    /// <summary>
    /// ARS que le corresponde segun el decreto y procedimiento establecido
    /// </summary>
    public byte ArsNumero { get; set; }

    /// <summary>
    /// Fecha en la que se completo la afiliacion
    /// </summary>
    public DateTime? PensionadoFechaAfiliacion { get; set; }

    /// <summary>
    /// Fecha en la que se dio de baja de la base de datos de pensionados
    /// </summary>
    public DateTime? PensionadoFechaBajaSeh { get; set; }

    /// <summary>
    /// Fecha en la que se desafilio el pensionado de la ARS
    /// </summary>
    public DateTime? PensionadoFechaDesafiliacion { get; set; }

    /// <summary>
    /// Fecha en la que se registro el pensionado en la ARS, pendiente de envio de documentos.
    /// </summary>
    public DateTime? PensionadoFechaRegistroTss { get; set; }

    /// <summary>
    /// Monto de la pension del pensionado
    /// </summary>
    public decimal PensionadoMontoPension { get; set; }

    /// <summary>
    /// A= Activo, I= Inactivo
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Nombre del usuario 
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha del registro 
    /// </summary>
    public DateTime RegistroFecha { get; set; }

    public virtual TssPensionadosStatusCatum StatusCodigoNavigation { get; set; } = null!;

    public virtual ICollection<TssPensionadosDispersionesTran> TssPensionadosDispersionesTrans { get; set; } = new List<TssPensionadosDispersionesTran>();

    public virtual ICollection<TssPensionadosHistorico> TssPensionadosHistoricos { get; set; } = new List<TssPensionadosHistorico>();

    public virtual ICollection<TssPensionadosNovedadesDetallesTran> TssPensionadosNovedadesDetallesTrans { get; set; } = new List<TssPensionadosNovedadesDetallesTran>();
}
