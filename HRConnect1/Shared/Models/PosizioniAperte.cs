using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class PosizioniAperte
    {
        public int ID { get; set; }
        public string? Descrizione { get; set; }

        public virtual ICollection<Colloquio> Colloquios { get; set; } = new List<Colloquio>();
        public Contratto? ContrattoNavigation { get;set; }
        
    }
}
