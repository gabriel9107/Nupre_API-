using AutoMapper;
using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Utilidades
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<Crear_Profesionales_SolicitudesDTO, Profesionales_Solicitudes_Tran>().ForMember(x => x.Profesional_Documento,
                opciones => opciones.Ignore());
                
            CreateMap<Profesionales_Solicitudes_Tran, Crear_Profesionales_SolicitudesDTO>();




            CreateMap<CrearProfesion_Especialidad_DTO, Profesionales_Solicitudes_Especialidades_Trans>();
            CreateMap<Profesionales_Solicitudes_Especialidades_Trans, Profesionales_Solicitud_Especialidad_transDTO>();
        }

    }
}
