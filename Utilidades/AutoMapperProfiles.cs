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


            //Titulacion - (Grado, especialidades) 
            CreateMap<CrearProfesion_Especialidad_DTO, Profesionales_Solicitudes_Especialidades_Trans>();
            CreateMap<Profesionales_Solicitudes_Especialidades_Trans, CrearProfesion_Especialidad_DTO>();


        }

    }
}
