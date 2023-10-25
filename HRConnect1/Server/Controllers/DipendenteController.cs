using HRConnect1.Server.Repository;
using HRConnect1.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect1.Server.Controllers
{
    [Route("Api/Dipendente")]
    [ApiController]
    public class DipendenteController : ControllerBase
    {
        private readonly DipendenteRepository _repository; //Questa dichiarazione indica che la classe
                                                           //ha una dipendenza da un'istanza di DipendenteRepository
                                                           //che sarà utilizzata per l'accesso ai dati dei dipendenti.

        public DipendenteController(DipendenteRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("{ID}")]
        public IActionResult GetDipendenteById(int id)
        {
            var dipendente = _repository.GetById(id);

            if (dipendente == null)
            {
                return NotFound(); // Ritorna una risposta 404 se il dipendente non è stato trovato.
            }

            return Ok(dipendente); // Ritorna il dipendente trovato come risposta JSON.
        }

        [HttpGet("{Name}")]
        public IActionResult GetDipendenteByName(string nome)
        {
            var dipendente = _repository.GetByName(nome);

            if (dipendente == null)
            {
                // Dipendente non trovato, restituisci una risposta 404 Not Found
                return NotFound();
            }

            // Dipendente trovato, restituisci una vista o un JSON con il dipendente
            return Ok(dipendente); // O return Ok(dipendente) per JSON
        }

        [HttpPost]
        public IActionResult AddDipendente([FromBody] Dipendente nuovoDipendente)
        {
            if(nuovoDipendente == null)
            {
                return BadRequest("I dati del dipendente sono nulli");

            }

            _repository.Add(nuovoDipendente);

            return Ok();
        }
    }
}
