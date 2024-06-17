using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class VilleReadDto : BaseEntityReadDto
    {
        #region Properties
        public string NomVille { get; set; }       
        public string CodePostal { get; set; }        
        public string Libelle { get; set; }        
        public string Canton { get; set; }        
        public string Borough { get; set; }
        public float Lat { get; set; }        
        public float Lng { get; set; }

        #endregion
      
    }
}
