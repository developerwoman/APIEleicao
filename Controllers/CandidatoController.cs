using APIEleicao.Model;
using APIEleicao.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoController(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Model.Candidato>> GetAll()
        {
            return await _candidatoRepository.Get();
        }

        [HttpGet("{Id_candidato}")]
        public async Task<ActionResult<Candidato>> GetById(int Id_candidato)
        {
            return await _candidatoRepository.GetById(Id_candidato);
        }

        [HttpPost]
        public async Task<ActionResult<Candidato>> Create([FromBody] Candidato candidato)
        {
            var newCandidato = await _candidatoRepository.Create(candidato);
            return CreatedAtAction(nameof(GetById), new { Id_candidato = newCandidato.Id_candidato }, newCandidato);
        }

        [HttpPut]
        public async Task<ActionResult> Update(int Id_candidato, [FromBody] Candidato candidato)
        {
            if (Id_candidato != candidato.Id_candidato)

                return BadRequest();

            await _candidatoRepository.Update(candidato);
            return NoContent();
        }

        [HttpDelete("{Id_candidato}")]

        public async Task<ActionResult> Delete(int Id_candidato)
        {
            var returnDelete = await _candidatoRepository.GetById(Id_candidato);

            if (returnDelete == null)
                return NotFound();

            await _candidatoRepository.Delete(Id_candidato);
            return NoContent();
        }
    }
}
