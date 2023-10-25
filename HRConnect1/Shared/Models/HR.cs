using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class HR
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Cognome { get; set; }
        public int SedeID { get; set; }

        public virtual ICollection<Colloquio> Colloquios { get; set; } = new List<Colloquio>();
        public Sede? SedeNavigation { get; set; } = null;
       
    }
}
