using Microsoft.EntityFrameworkCore;
using SeriesPersonajesApp.Data;
using SeriesPersonajesApp.Models;

namespace SeriesPersonajesApp.Services
{
    public class PersonajeService
    {
        private readonly ApplicationDbContext _context;

        public PersonajeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Personaje>> GetPersonajesAsync()
        {
            return await _context.Personajes.Include(p => p.Serie).ToListAsync();
        }

        public async Task<Personaje> GetPersonajeByIdAsync(int id)
        {
            return await _context.Personajes.Include(p => p.Serie).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task CreatePersonajeAsync(Personaje personaje)
        {
            _context.Personajes.Add(personaje);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePersonajeAsync(Personaje personaje)
        {
            _context.Entry(personaje).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePersonajeAsync(int id)
        {
            var personaje = await _context.Personajes.FindAsync(id);
            if (personaje != null)
            {
                _context.Personajes.Remove(personaje);
                await _context.SaveChangesAsync();
            }
        }
    }
}