using APIEleicao.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Repositories
{
    public class VotoRepository : IVotoRepository
    {
        private readonly EleicaoContext _context;

        public VotoRepository(EleicaoContext context)
        {
            _context = context;
        }
        public async Task<Voto> Create(Voto voto)
        {
            _context.Votos.Add(voto);
            await _context.SaveChangesAsync();
            return voto;
        }

        public async Task Delete(Guid Id_voto)
        {
            var votoDelete = await _context.Votos.FindAsync(Id_voto);

            if (votoDelete != null)
            {
                _context.Remove(votoDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Voto>> Get()
        {
            return await _context.Votos.ToListAsync();
        }

        public async Task<Voto> GetById(Guid Id_voto)
        {
            return await _context.Votos.FindAsync(Id_voto);
        }

        public async Task Update(Voto voto)
        {
            _context.Entry(voto).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
