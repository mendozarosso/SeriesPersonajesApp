using Microsoft.EntityFrameworkCore;
using SeriesPersonajesApp.Data;
using SeriesPersonajesApp.Models;

namespace SeriesPersonajesApp.Services
{
    public class SerieService
    {
        private readonly ApplicationDbContext _context;

        public SerieService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Serie>> GetSeriesAsync()
        {
            return await _context.Series.ToListAsync();
        }

        public async Task<Serie> GetSerieByIdAsync(int id)
        {
            return await _context.Series.FindAsync(id);
        }

        public async Task CreateSerieAsync(Serie serie)
        {
            _context.Series.Add(serie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSerieAsync(Serie serie)
        {
            _context.Entry(serie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSerieAsync(int id)
        {
            var serie = await _context.Series.FindAsync(id);
            if (serie != null)
            {
                _context.Series.Remove(serie);
                await _context.SaveChangesAsync();
            }
        }
    }
}