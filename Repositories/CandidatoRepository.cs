using APIEleicao.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Repositories
{
    public class CandidatoRepository : ICandidatoRepository
    {
        public readonly EleicaoContext _context;

        public CandidatoRepository(EleicaoContext context)
        {
            _context = context;
        }

        public async Task<Candidato> Create(Candidato candidato)
        {
            _context.Candidatos.Add(candidato);
            await _context.SaveChangesAsync();

            return candidato;
        }

        public async Task Delete(int Id_candidato)
        {
            try
            {
                var candidatoDelete = await _context.Candidatos.FindAsync(Id_candidato);
                //var stockTransfertDtail = await _context.StockTransfertDetail.Where(w => w.StockTransfertId == id);
                var candidatoDetail = _context.Candidatos.Where(w => w.Id_candidato == Id_candidato);


                _context.Remove(candidatoDelete.Id_candidato);
                _context.Remove(candidatoDetail);

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

        public async Task<IEnumerable<Candidato>> Get()
        {
            return await _context.Candidatos.ToListAsync();
        }

        public async Task<Candidato> GetById(int Id_candidato)
        {
            return await _context.Candidatos.FindAsync(Id_candidato);
        }

        public async Task Update(Candidato candidato)
        {
            _context.Entry(candidato).State = EntityState.Modified;
            //var candidatoResult = await _context.Candidato.FindAsync(candidato.Id_candidato);

            //candidatoResult.Nome = candidato.Nome;
            //candidatoResult.Vice = candidato.Vice;
            //candidatoResult.Legenda = candidato.Legenda;
            //candidatoResult.Codigo = candidato.Codigo;

            await _context.SaveChangesAsync();
        }

    }
}
