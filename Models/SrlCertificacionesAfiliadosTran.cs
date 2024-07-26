using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class SrlCertificacionesAfiliadosTran
{
    public int CertificacionSecuencia { get; set; }

    public int CertificacionSiniestroFecha { get; set; }

    public int CertificacionConcrecionFecha { get; set; }

    public int ArlRemiteComisionMedicaFecha { get; set; }

    public int DictamenFecha { get; set; }

    public string DocumentoCodigo { get; set; } = null!;

    public int RecepcionSisalrilFecha { get; set; }

    public long CiudadanoNss { get; set; }

    public byte CertificacionEdadAnios { get; set; }

    public byte ComisionMedicaNumero { get; set; }

    public string ArlssNumero { get; set; } = null!;

    public decimal PorcientoDiscapacidadPrimeraEvaluacion { get; set; }

    public string CertificacionDiagnosticoDescripcion { get; set; } = null!;

    public string RegionAnatomicaCodigo { get; set; } = null!;

    public int ArlssObjecionFecha { get; set; }

    public byte CertificacionNumero { get; set; }

    public byte CertificacionEstadoNumero { get; set; }

    public decimal PorcientoDiscapacidadCertificada { get; set; }

    public string RegistroEstado { get; set; } = null!;

    public string RegistroUsuario { get; set; } = null!;

    public DateTime RegistroFecha { get; set; }

    public virtual SrlCertificacionesEstadosCatum CertificacionEstadoNumeroNavigation { get; set; } = null!;

    public virtual SrlCertificacionesMaster CertificacionNumeroNavigation { get; set; } = null!;

    public virtual TssCiudadanosMaster CiudadanoNssNavigation { get; set; } = null!;

    public virtual SrlComisionesMedicasMaster ComisionMedicaNumeroNavigation { get; set; } = null!;

    public virtual SrlCertificacionesRegionesAnatomicasCatum RegionAnatomicaCodigoNavigation { get; set; } = null!;
}
