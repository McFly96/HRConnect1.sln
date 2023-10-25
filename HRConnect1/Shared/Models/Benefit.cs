using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public  class Benefit
    {
        public int ID { get; set; }
        public string? Descrizione { get; set; }
        public bool Attivo { get; set; }
        
        public virtual ICollection<Dipendente> Dipendenti { get; set; }= new List<Dipendente>();
       
    }
}
