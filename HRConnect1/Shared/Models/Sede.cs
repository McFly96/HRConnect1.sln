using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class Sede
    {
        public int Id { get; set; }
        public string? Indirizzo { get; set; }
        public int CittàID { get; set; }

        public Citta? CittaNavigation { get; set; } = null;
        public virtual ICollection<Colloquio> Colloquios { get; set; } = new List<Colloquio>();
        public virtual ICollection<Dipendente>Dipendentes { get; set; }=new List<Dipendente>();
        public virtual ICollection<HR> HRs { get; set; } = new List<HR>();

    }
}
