using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class Citta
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Candidati> Candidatis { get; set; } = new List<Candidati>();
        public virtual ICollection<Sede> Sedes { get; set; } = new List<Sede>();

    }
}
