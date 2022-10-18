using APIEleicao.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIEleicao.Repositories
{
    public interface IMarcaRepository
    {
        Task<IEnumerable<Marca>> Get();
        Task<Marca> GetById(int Id);
        Task<Marca> Create(Marca marca);
        Task Update(Marca marca);
        Task Delete(int Id);
    }
}
