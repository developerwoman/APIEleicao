using APIEleicao.Model;
using APIEleicao.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotoController : ControllerBase
    {
        private readonly IVotoRepository _votoRepository;

        public VotoController(VotoRepository votoRespository)
        {
            _votoRepository = votoRespository;
        }

        [HttpGet]
        public async Task<IEnumerable<Voto>> GetAll()
        {
            return await _votoRepository.Get();
        }

        [HttpGet("{Id_voto}")]
        public async Task<Voto> GetById(Guid Id_voto)
        {
            return await _votoRepository.GetById(Id_voto);
        }

        [HttpPost]
        public async Task<ActionResult<Voto>> Create([FromBody] Voto voto)
        {
            var newVoto =  await _votoRepository.Create(voto);

            return CreatedAtAction(nameof(GetById), new { Id_voto = newVoto.Id_voto }, newVoto);
        }

        [HttpPut]
        public async Task<ActionResult> Update(Guid Id_voto, [FromBody] Voto voto)
        {
            if (Id_voto == voto.Id_voto)
            {
                await _votoRepository.Update(voto);
            }
            return null;
        }

        [HttpDelete("{Id_voto}")]
        public async Task<ActionResult> Delete(Guid Id_voto)
        {
            var votoDelete = await _votoRepository.GetById(Id_voto);

            if (votoDelete != null)
                await _votoRepository.Delete(Id_voto);

            return null;
        }
    }
}
