using APIEleicao.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Repositories
{
    public class MarcaRepository : IMarcaRepository
    {
        public readonly EleicaoContext _context;

        public MarcaRepository(EleicaoContext context)
        {
            _context = context;
        }

        public async Task<Marca> Create(Marca marca)
        {
            _context.Marcas.Add(marca);
            await _context.SaveChangesAsync();

            return marca;
        }

        public async Task Delete(int Id)
        {
            try
            {
                var marcaDelete = await _context.Marcas.FindAsync(Id);

                _context.Remove(marcaDelete);

                await _context.SaveChangesAsync();
            }
            catch (InvalidOperationException inv)
            {
                throw new Exception(inv.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Marca>> Get()
        {
            return await _context.Marcas.ToListAsync();
        }

        public async Task<Marca> GetById(int Id)
        {
            return await _context.Marcas.FindAsync(Id);
        }

        public async Task Update(Marca marca)
        {
            _context.Entry(marca).State = EntityState.Modified;
            _ = await _context.SaveChangesAsync();
        }
    }
}
