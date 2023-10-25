using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class Candidati
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Cognome { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public int CittaID { get; set; }
        public int ContrattoID { get; set; } 
        public Citta? CittaNavigation { get; set; } = null;
        
        public virtual ICollection<Colloquio> Colloquios { get; set; } = new List<Colloquio>();
        public virtual ICollection<HardSkill> HardSkills { get; set; } = new List<HardSkill>();
        public virtual ICollection<SoftSkill> SoftSkills { get; set; } = new List<SoftSkill>();
        public virtual ICollection<TitoloStudio> TitoloStudios { get; set; } = new List<TitoloStudio>();

        public Contratto? ContrattoNavigation { get; set; } = null;


    }
}
