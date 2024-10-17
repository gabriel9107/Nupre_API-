using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nupre_API.DTOs;
using Nupre_API.Entidades;

namespace Nupre_API.Repositorio
{
    public class RepositorioProfesionalesEspecialidadesTrans : IRepositorioProfesionalesEspecialidadesTrans
    {
        private readonly ApplicationDbContext context;
        IMapper mapper;
        public RepositorioProfesionalesEspecialidadesTrans(ApplicationDbContext context)
        {
            this.context = context;
        }



        public async Task<Profesionales_Solicitudes_Especialidades_Trans> obtenerTitulacionPorId(int numero_Solicitud)
        {
            return await context.Profesionales_Solicitudes_Especialidades_Trans.Where(x => x.Solicitud_Numero == numero_Solicitud && x.Registro_Estado == "A").FirstOrDefaultAsync();
        }

        public async Task<List<DetalleProfesionales_DTO>> ObtenerTitulacionPorSolicitud(int numero_Solicitud)
        {

           

            


            var query = await context.Profesionales_Solicitudes_Especialidades_Trans.
                Include(p => p.Especialidades_Cata).Where(x => x.Solicitud_Numero ==
                numero_Solicitud && x.Registro_Estado == "A").ToListAsync();





            var result =   (from pa in query
                         select new DetalleProfesionales_DTO
                         {
                             Especialidad_Descripcion = pa.Especialidades_Cata.Especialidad_Descripcion,
                             Registro_Fecha = pa.Registro_Fecha,
                             Especialidad_Periodo = pa.Especialidad_Periodo.ToString(),
                             Especialidad_Tipo_Numero = pa.Especialidad_Tipo_Numero,
                             Registro_Estado = pa.Registro_Estado,
                             Solicitud_Numero = pa.Solicitud_Numero
                         }).ToList();

                                



            //context.Profesionales_Solicitudes_Especialidades_Trans.Where(x => x.Solicitud_Numero == numero_Solicitud && x.Registro_Estado == "A").ToListAsync();


            return result;
        }

        public async Task<int> Crear(Profesionales_Solicitudes_Especialidades_Trans trans)
        {



            //var cata = new Profesionales_Especialidades_Cata()
            //{

            //    Especialidad_Numero = trans.Especialidad_Numero
            //};

           var cata = await context.Profesionales_Especialidades_Cata.Where(x => x.Especialidad_Numero == trans.Especialidad_Numero).FirstOrDefaultAsync(); 

            
            trans.Especialidades_Cata = cata!;
            trans.Registro_Usuario = "g.montero";
            trans.Registro_Estado = "A";
            trans.Especialidad_Estado_Numero = 1;
            trans.Registro_Fecha = DateTime.Now;
            trans.Especialidad_Estado_Fecha = DateTime.Now;
            


            byte Especialidad_Tipo_Numero = await context.Profesionales_Especialidades_Cata.Where(x => x.Especialidad_Numero == trans.Especialidad_Numero).Select(s => s.Especialidad_Tipo_Numero).FirstOrDefaultAsync();
            trans.Especialidad_Tipo_Numero = Especialidad_Tipo_Numero;

            context.Add(trans);
            await context.SaveChangesAsync();
            return trans.Solicitud_Numero;
        }

        public async Task Actualizar(Profesionales_Solicitudes_Especialidades_Trans trans)
        {
            context.Update(trans);
            await context.SaveChangesAsync();
        }

        public Task<DetalleProfesionales_DTO> ObtenerPorId(int numero_Solicitud)
        {
            throw new NotImplementedException();
        }

        //public async Task<DetalleProfesionales_DTO> ObtenerPorId(int numero_Solicitud)
        //{
        //    var query = await context.Profesionales_Solicitudes_Especialidades_Trans.Where(x => x.Id == numero_Solicitud).FirstOrDefaultAsync();


        //}
    }
}
