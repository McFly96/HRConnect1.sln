using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class TitoloStudio
    {
        public int Id { get; set; }
        public string? NomeTitolo { get; set; }
        public bool Attivo { get; set; }

        public virtual ICollection<Candidati> Candidatis { get; set; } = new List<Candidati>();

        
    }
}
