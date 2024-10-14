using AutoMapper;
using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Utilidades
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {

            //Solicitudes 
            CreateMap<crearSolicituDTO, Profesionales_Solicitudes_Tran>();
            CreateMap<Profesionales_Solicitudes_Tran, crearSolicituDTO>();

            CreateMap<Profesionales_Solicitudes_Tran, Solicitud_ListadoDTO>();
            CreateMap<Solicitud_ListadoDTO, Profesionales_Solicitudes_Tran>(); 


            //Titulacion - (Grado, especialidades) 
            CreateMap<CrearProfesion_Especialidad_DTO, Profesionales_Solicitudes_Especialidades_Trans>();
            CreateMap<Profesionales_Solicitudes_Especialidades_Trans, CrearProfesion_Especialidad_DTO>();

            //asosiaciones
            CreateMap<Profesionales_Solicitudes_Asociaciones_Tran, CrearAsociacion_DTO>();
            CreateMap<CrearAsociacion_DTO, Profesionales_Solicitudes_Asociaciones_Tran>();


            //actvidades 
            CreateMap<Solicitudes_Actividades_Trans, CrearSolicitudes_ActividadesDTO>();
            CreateMap<CrearSolicitudes_ActividadesDTO,Solicitudes_Actividades_Trans>();


            //localides 
            CreateMap<Profesionales_Solicitudes_Localidades_Tran, Crear_Localidades_DTO>(); 
            CreateMap<Crear_Localidades_DTO, Profesionales_Solicitudes_Localidades_Tran>();


            //ciudadano 
            CreateMap<TssCiudadanosMaster, Ciudadano_master_DTO>();
            CreateMap<Ciudadano_master_DTO, TssCiudadanosMaster>(); 
        }

    }
}
