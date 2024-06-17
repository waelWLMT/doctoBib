using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class PraticienReadDto : UserReadDto
    {        
        #region navigation properties
      
        public SpecialiteReadDto Specialite { get; set; }

        public virtual List<RendezVousReadDto> Appointments { get; set; }

        #endregion
    }
}
