using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class Dipendente
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public int SedeID { get; set; }
       
       

        public virtual ICollection<Benefit> Benefits { get; set; }= new List<Benefit>();
        public Sede? SedeNavigation { get; set; } = null;
    }
}
