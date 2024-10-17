using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.StaticFiles;
using Nupre_API.DTOs;
using Nupre_API.Entidades;
using Nupre_API.Models;
using Nupre_API.Repositorio;
using Nupre_API.Servicios;
using System.Threading.Tasks;

namespace Nupre_API.Endpoints
{
    public static class SolicitudesEndpoints
    {
        private static readonly string contenedor = "solicitud";
        public static RouteGroupBuilder mapSolicitudes(this RouteGroupBuilder group)
        {



            group.MapGet("/", ObtenerTodos).CacheOutput(c => c.Expire(TimeSpan.FromSeconds(15)).Tag("solicitudes-get")); ;


            group.MapGet("downloadFile/{id}", (int id, IRepositorioComunesDocumentosMaster repositorio) =>
            {

                var ruta = repositorio.obtenerRutaDocumentoByid(id).Result;

                if (ruta is null)
                {
                    return null;

                };


                return Results.File(ruta.ToString()!, "application/pdf", "report.pdf");
            });

            group.MapGet("obtenerSolicitud", ObtenerTodosFiltrada);
            group.MapGet("obtenerSolicitudPorId/{id:int}", ObtenerPorId);
            group.MapPost("/", Crear);

            group.MapGet("someterSolicitud", someterSolicitud);
            group.MapPost("crearSolicituDocumento", CrearSolicitudDocumento)

                .DisableAntiforgery();

            group.MapPost("prueba", CrearSolicitudPrueba)
                .DisableAntiforgery();
            ;
            group.MapPost("actualizar", Actualizar).DisableAntiforgery(); ;
            return group;
        }


        static async Task<Created<crearSolicituDTO>> CrearSolicitudPrueba([FromForm]
        crearSolicituDTO solicitudes,
            IRepositorioProfesionalesSolicitudesTrans repositorio,
                        IOutputCacheStore outputCacheStore,

            IMapper mapper, IAlmacenadorArchivos almacenadorArchivos, IRepositorioComunesDocumentosMaster repositorioDocumento, IRepositorioProfesionalesActividadesTrans actividades)
        {


            CrearDocumentoComun_DTO _numeroDocumentoCedula;
            int _nomeDocumentoCedula;
            CrearDocumentoComun_DTO _numeroDocumentoExequatur;
            int _nomeDocumentoExequatur;





            var _solicitud = mapper.Map<Profesionales_Solicitudes_Tran>(solicitudes);
            var id = await repositorio.Crear(_solicitud);

            if (solicitudes.Archivo_Cedula is not null && solicitudes.Archivo_Exequatur is not null)
            {
                _numeroDocumentoCedula = await almacenadorArchivos.Almacenar_NombreArchivo(contenedor, solicitudes.Archivo_Cedula);
                if (_numeroDocumentoCedula is not null)

                    _numeroDocumentoCedula.Tipo_Documento = 1;
                _numeroDocumentoCedula.solicitud_numero = id;

                _nomeDocumentoCedula = await repositorioDocumento.CrearDocumento(_numeroDocumentoCedula);


                _numeroDocumentoExequatur = await almacenadorArchivos.Almacenar_NombreArchivo(contenedor, solicitudes.Archivo_Exequatur);
                if (_numeroDocumentoExequatur is not null)
                    _numeroDocumentoExequatur.Tipo_Documento = 2;
                _numeroDocumentoExequatur.solicitud_numero = id;
                _nomeDocumentoExequatur = await repositorioDocumento.CrearDocumento(_numeroDocumentoCedula);

                _solicitud.Profesional_Documento_Cedula_Numero = _nomeDocumentoCedula;
                _solicitud.Solicitud_Certificado_Numero = _nomeDocumentoExequatur.ToString();
            }

            var actividad = new Solicitudes_Actividades_Trans()
            {
                //Actividad_Secuencia = 1,
                Actividad_Numero = 1,
                Solicitud_Numero = _solicitud.Solicitud_Numero,
                Solicitud_Tipo_Numero = 1,
                Actividad_Contenido = "N/A",
                Sometimiento_Secuencia = 1,
                RegistroUsuario = _solicitud.Registro_Usuario,
                RegistroEstado = "A"

            };

            await actividades.Crear(actividad);


            await outputCacheStore.EvictByTagAsync("solicitudes-get", default);

            var actorDto = mapper.Map<crearSolicituDTO>(_solicitud);




            return TypedResults.Created($"/{id}", actorDto);
        }




        static async Task<Ok<List<Profesionales_Solicitudes_Tran>>> ObtenerTodosFiltrada(
             IRepositorioProfesionalesSolicitudesTrans repositorio
            , [AsParameters] Profesionales_Filtro_Listado_DTO filtros, IMapper mapper
            )
        {


            filtros.PageIndex = filtros.PageSize * (filtros.Draw - 1);
            var resultado = await repositorio.getrequestsbyuser(filtros);

            return TypedResults.Ok(resultado);




        }

        static async Task<Ok<List<Profesionales_Solicitudes_Tran>>> ObtenerTodos(IRepositorioProfesionalesSolicitudesTrans repositorio)
        {
            var profesionales = await repositorio.ObtenerTodos();
            return TypedResults.Ok(profesionales);

        }



        static async Task<Results<Ok<Profesionales_Solicitudes_Tran>, NotFound>> ObtenerPorId(IRepositorioProfesionalesSolicitudesTrans repositorio, int id)
        {
            var profesionales = await repositorio.ObtenerPorId(id);
            if (profesionales is null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(profesionales);
        }

        static async Task<Created<Crear_Profesionales_SolicitudesDTO>> CrearSolicitudDocumento([FromForm] Crear_Profesionales_SolicitudesDTO solicitudes,
            IRepositorioProfesionalesSolicitudesTrans repositorio, IOutputCacheStore outputCacheStore,
            IMapper mapper)
        {




            var _solicitud = mapper.Map<Profesionales_Solicitudes_Tran>(solicitudes);

            if (solicitudes.Profesional_Documento is not null)
            {
                //var url = await almacenadorArchivos.Almacenar_NombreArchivo(contenedor, solicitudes.Profesional_Documento);
            }




            //Completar datos para prueba 




            var id = await repositorio.Crear(_solicitud);

            await outputCacheStore.EvictByTagAsync("solicitudes-get", default);

            var actorDto = mapper.Map<Crear_Profesionales_SolicitudesDTO>(_solicitud);
            return TypedResults.Created($"/{id}", actorDto);
        }


        static async Task<Results<NoContent, NotFound>> someterSolicitud(int solicitud, IRepositorioProfesionalesSolicitudesTrans repositorio,
            IRepositorioProfesionalesActividadesTrans actividades,
            IOutputCacheStore outputCacheStore)
        {



            var id = await repositorio.SometerSolicitud(solicitud);



            if (id == false)
            {
                return TypedResults.NotFound();
            }
            var actividad = new Solicitudes_Actividades_Trans()
            {
                //Actividad_Secuencia = 1,
                Actividad_Numero = 8,
                Solicitud_Numero = solicitud,
                Solicitud_Tipo_Numero = 1,
                Actividad_Contenido = "N/A",
                Sometimiento_Secuencia = 1,
                RegistroUsuario = "g.montero",

                RegistroEstado = "A"

            };

            await actividades.Crear(actividad);

            return TypedResults.NoContent();
        }
        static async Task<Created<Profesionales_Solicitudes_Tran>> Crear(Profesionales_Solicitudes_Tran solicitudes, IRepositorioProfesionalesSolicitudesTrans repositorio, IOutputCacheStore outputCacheStore)
        {



            var id = await repositorio.Crear(solicitudes);

            await outputCacheStore.EvictByTagAsync("solicitudes-get", default);
            return TypedResults.Created($"/{id}", solicitudes);
        }


        //static async Task<File, NoContent> downloadFile(IRepositorioComunesDocumentosMaster repositorio,Documento_filtro filtro)
        //{
        //   var ruta = await  repositorio.obtenerRutaDocumento(filtro);

        //    if (!File.Exists(ruta))
        //    {
        //        return Results.NoContent();
        //    }
        //    var fileBytes = await File.ReadAllBytesAsync(ruta);

        //    // Create a FileToDownload object
        //    var fileToDownload = new FileToDownload
        //    {
        //        FileName = $"Documento{filtro.Solicitud_numero}",
        //        FilePath = ruta,
        //        FileContent = fileBytes
        //    };

        //    var contentType = "sk";

        //    // Set the appropriate content type based on the file extension


        //    return Results.File(fileToDownload.FileContent, contentType, fileToDownload.FileName, true);




        //}
        private static string GetContentType(string filename)
        {
            var provider = new FileExtensionContentTypeProvider();
            string contentType;
            if (!provider.TryGetContentType(filename, out contentType))
            {
                contentType
         = "application/octet-stream"; // Default content type
            }
            return contentType;
        }
        static async Task<Results<NoContent, NotFound>> Actualizar(IRepositorioProfesionalesSolicitudesTrans repositorio,

            //AlmacenadorArchivosLocal RepositorioArchivos,
            Update_Solicitud_DTO trans, IOutputCacheStore outputCacheStore,  IMapper mapper)
        {
            if (trans.Solicitud_Numero == null)
            {
                return TypedResults.NoContent();
            }

            var existe = await repositorio.Existe(trans.Solicitud_Numero);
            if (!existe)
            {
                return TypedResults.NotFound();
            }

            var update = mapper.Map<Profesionales_Solicitudes_Tran>(trans); 
           
            await repositorio.Actualizar(update);

            //verficiamos que exista un archivo adjunto.  
             
            
            await outputCacheStore.EvictByTagAsync("solicitudes-get", default);
            return TypedResults.NoContent();

        }
    }
}
