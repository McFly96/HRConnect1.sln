using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConnect1.Shared.Models
{
    public class Contratto
    {
        public int Id { get; set; }
        
        public int CandidatiID { get; set; }
        
        public int PosizioniAperteID { get; set; }

        public Candidati? CandidatiNavigation { get; set; } = null;
        public PosizioniAperte? PosizioniAperteNavigation { get; set; } = null;

        
    }
}
