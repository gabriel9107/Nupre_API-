﻿using Microsoft.EntityFrameworkCore;
using Nupre_API.Entidades;
using Nupre_API.Migrations;

namespace Nupre_API.Repositorio
{
    public class RepositorioProfesionalesSolcitiudesTrans : IRepositorioProfesionalesSolicitudesTrans
    {
        private readonly ApplicationDbContext context;
        public RepositorioProfesionalesSolcitiudesTrans(ApplicationDbContext context)
        {
            this.context = context; 
        }
        public async Task<ProfesionalesSolicitudesTran> ObtenerPorId(int id)
        {
            return await context.profesionalesSolicitudesTrans.FirstOrDefaultAsync(x => x.ProfesionalesSolicitudesTranId == id);
        }
        public Task<List<ProfesionalesSolicitudesTran>> ObtenerTodos()
        {
            return context.profesionalesSolicitudesTrans.ToListAsync();
        }
        public async Task<int> Crear(ProfesionalesSolicitudesTran trans)
        {
            context.Add(trans); 
            await context.SaveChangesAsync();
            return trans.ProfesionalesSolicitudesTranId; 
        }
        public async Task Actualizar(ProfesionalesSolicitudesTran profesionales)
        {
            context.Update(profesionales);
            await context.SaveChangesAsync();
        }
        public async Task<bool> Existe(int id)
        {
            return await context.profesionalesSolicitudesTrans.AnyAsync( x => x.ProfesionalesSolicitudesTranId == id);   
        }

      
    }   
}
