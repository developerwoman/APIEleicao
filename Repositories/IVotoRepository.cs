using APIEleicao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Repositories
{
    public interface IVotoRepository
    {
        Task<IEnumerable<Voto>> Get();
        Task<Voto> GetById(Guid Id_voto);
        Task<Voto> Create(Voto voto);
        Task Update(Voto voto);
        Task Delete(Guid Id_voto);
    }
}
