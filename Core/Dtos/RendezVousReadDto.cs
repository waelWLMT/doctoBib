using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class RendezVousReadDto
    {
        #region Properties       

        public DateTime Date { get; set; }     
        public TimeSpan Heure { get; set; }       
        public String Recaputulatif { get; set; }     
        public string Remarque { get; set; }

        #endregion

        #region Navigation properties  

        public int PatientId { get; set; }        
        public PatientReadDto Patient { get; set; } 
        public int PraticienId { get; set; }       
        public PraticienReadDto Praticien { get; set; }
        public int MotifId { get; set; }
        public MotifReadDto Motif { get; set; }

        #endregion

    }
}
