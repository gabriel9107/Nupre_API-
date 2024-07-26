using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla transaccional que contiene los detalles de cada uno de los lotes que se generan para un seguimiento de carga, su fuente de datos es el proceso de carga del Robot Simon. 
/// </summary>
public partial class SeguimientosLotesTran
{
    /// <summary>
    /// Número único que representa la carga de un informe (esquemas), que debe realizar cada ARS/ARL para un período específico
    /// </summary>
    public long SeguimientoCodigo { get; set; }

    /// <summary>
    /// Número único que se genera cada vez que se procesa un seguimiento de la carga de informe (esquemas), que debe realizar cada ARS/ARL, para un mismo seguimiento podrán existir de 1 a N lotes.
    /// </summary>
    public byte SeguimientoLote { get; set; }

    /// <summary>
    /// Es un número que representa el estado de procesamiento en que se encuentra un seguimiento de carga de esquema.
    /// </summary>
    public byte SeguimientoEstadoNumero { get; set; }

    /// <summary>
    /// Nombre de archivo físico remitido por las ARS/ARL  para un  proceso de una carga de esquema de un lote específico.
    /// </summary>
    public string SeguimientoLoteNombreArchivo { get; set; } = null!;

    /// <summary>
    /// Cantidad de registros (líneas) procesados en un  proceso de una carga de esquema de un lote.
    /// </summary>
    public int SeguimientoLoteRegistros { get; set; }

    /// <summary>
    /// Usuario que  remitió el archivo desde  la ARS/ARL,  para un  proceso de una carga de esquema de un lote específico.
    /// </summary>
    public string SeguimientoLoteUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha en la que inició un  proceso de una carga de esquema de un lote específico.
    /// </summary>
    public DateTime SeguimientoLoteFechaInicio { get; set; }

    /// <summary>
    /// Fecha en la que finalizó un  proceso de una carga de esquema de un lote específico.
    /// </summary>
    public DateTime SeguimientoLoteFechaFin { get; set; }

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

    public virtual ICollection<AccidentesTransitoArsTran> AccidentesTransitoArsTrans { get; set; } = new List<AccidentesTransitoArsTran>();

    public virtual ICollection<AfiliadosDependientesPlanesVoluntariosTran> AfiliadosDependientesPlanesVoluntariosTrans { get; set; } = new List<AfiliadosDependientesPlanesVoluntariosTran>();

    public virtual ICollection<AfiliadosPlanesComplementariosTran> AfiliadosPlanesComplementariosTrans { get; set; } = new List<AfiliadosPlanesComplementariosTran>();

    public virtual ICollection<AfiliadosTitularesPlanesVoluntariosTran> AfiliadosTitularesPlanesVoluntariosTrans { get; set; } = new List<AfiliadosTitularesPlanesVoluntariosTran>();

    public virtual ICollection<AfiliadosVoluntariosEspecialesTran> AfiliadosVoluntariosEspecialesTrans { get; set; } = new List<AfiliadosVoluntariosEspecialesTran>();

    public virtual ICollection<ArlPrestacionesEconomicasTran> ArlPrestacionesEconomicasTrans { get; set; } = new List<ArlPrestacionesEconomicasTran>();

    public virtual ICollection<EpisodiosDiagnosticosSubsidiadosTran> EpisodiosDiagnosticosSubsidiadosTrans { get; set; } = new List<EpisodiosDiagnosticosSubsidiadosTran>();

    public virtual ICollection<EpisodiosSubsidiadosTran> EpisodiosSubsidiadosTrans { get; set; } = new List<EpisodiosSubsidiadosTran>();

    public virtual ICollection<EpisodiosTran> EpisodiosTrans { get; set; } = new List<EpisodiosTran>();

    public virtual ICollection<FinancierosBalanceComprobacionTran> FinancierosBalanceComprobacionTrans { get; set; } = new List<FinancierosBalanceComprobacionTran>();

    public virtual ICollection<FinancierosPagosComisionesTran> FinancierosPagosComisionesTrans { get; set; } = new List<FinancierosPagosComisionesTran>();

    public virtual ICollection<FinancierosReclamacionesArsTran> FinancierosReclamacionesArsTrans { get; set; } = new List<FinancierosReclamacionesArsTran>();

    public virtual ICollection<PrestadorasInstitucionalesArsServiciosTran> PrestadorasInstitucionalesArsServiciosTrans { get; set; } = new List<PrestadorasInstitucionalesArsServiciosTran>();

    public virtual ICollection<PrestadorasInstitucionalesArsTran> PrestadorasInstitucionalesArsTrans { get; set; } = new List<PrestadorasInstitucionalesArsTran>();

    public virtual ICollection<PrestadorasMedicosArsTran> PrestadorasMedicosArsTrans { get; set; } = new List<PrestadorasMedicosArsTran>();

    public virtual ICollection<PypServiciosTran> PypServiciosTrans { get; set; } = new List<PypServiciosTran>();

    public virtual SeguimientosMaster SeguimientoCodigoNavigation { get; set; } = null!;

    public virtual SeguimientosEstadosCatum SeguimientoEstadoNumeroNavigation { get; set; } = null!;

    public virtual ICollection<SeguimientosLotesErroresSistemasTran> SeguimientosLotesErroresSistemasTrans { get; set; } = new List<SeguimientosLotesErroresSistemasTran>();

    public virtual ICollection<SeguimientosLotesEventosTran> SeguimientosLotesEventosTrans { get; set; } = new List<SeguimientosLotesEventosTran>();
}
