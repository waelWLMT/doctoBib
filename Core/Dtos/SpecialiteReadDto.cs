using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class SpecialiteReadDto : BaseEntityReadDto
    {
        #region Properties       
        public string Libelle { get; set; }        
        public string Description { get; set; }  
        #endregion
    }
}
