using HRConnect1.Server.Data;
using HRConnect1.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HRConnect1.Server.Repository
{
    public class DipendenteRepository : IRepository<Dipendente>
    {
        private HRConnectDbContext _context;

        public DipendenteRepository(HRConnectDbContext context)
        {
            _context = context;
        }
        public void Add(Dipendente entity)
        {
            _context.Dipendentes.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Dipendentes.FirstOrDefault(d => d.ID == id);

            if (entity != null)
            {
                _context.Dipendentes.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Dipendente> GetAll()
        {
            return _context.Dipendentes.ToList();
        }

        public Dipendente GetById(int id)
        {
            return _context.Dipendentes.FirstOrDefault(d => d.ID == id);
        }

        public Dipendente GetByName(string Nome)
        {
            return _context.Dipendentes.FirstOrDefault(d => d.Nome == Nome);
        }

        public void Update(Dipendente entity)
        {
            var existingDipendente = _context.Dipendentes.FirstOrDefault(d => d.ID == entity.ID);

            if (existingDipendente != null)
            {
                existingDipendente.Nome = entity.Nome;
                existingDipendente.Cognome = entity.Cognome;
                // Aggiorna altri campi se necessario
                _context.SaveChanges();
            }
        }
    }
}