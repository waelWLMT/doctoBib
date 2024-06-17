using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class AdresseReadDto : BaseEntityReadDto
    {  
        public int Numero { get; set; }
        public string RueBoulevard { get; set; }

        #region Navigation properties
        public int DepartementId { get; set; }
        public DepartementReadDto? Departement { get; set; }
        public int VilleId { get; set; }
        public VilleReadDto? Ville { get; set; }

        #endregion

    }
}
