using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class Colloquio
    {
        public int Id { get; set; }
        
        public int CandidatiID { get; set; }
        
        public int HRID { get; set; }
        
        public int PosizioniAperteID { get; set; }
       
       
        public int SedeID { get; set; }

        public Candidati? CandidatiNavigation { get; set; } = null;
        public HR? HRNavigation { get; set; } = null;

        public PosizioniAperte? PosizioniAperteNavigation { get; set; } = null;
        public Sede? SedeNavigation { get; set; } = null;




    }
}
