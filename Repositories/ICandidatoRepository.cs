using APIEleicao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Repositories
{
    public interface ICandidatoRepository
    {
        Task<IEnumerable<Candidato>> Get();
        Task<Candidato> GetById(int Id_candidato);
        Task<Candidato> Create(Candidato candidato);
        Task Update(Candidato candidato);
        Task Delete(int Id_candidato);
    }
}
