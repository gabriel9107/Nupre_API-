using AutoMapper;
using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Utilidades
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<CrearProfesion_Especialidad_DTO, Profesionales_Solicitudes_Especialidades_Trans>();
            CreateMap<Profesionales_Solicitudes_Especialidades_Trans, Profesionales_Solicitud_Especialidad_transDTO>();
        }

    }
}
