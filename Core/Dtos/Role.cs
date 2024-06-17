using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class RoleReadDto : BaseEntityReadDto
    {

        #region Properties
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        #endregion


        #region Navigation Properties
        public virtual List<MenuReadDto> Menus { get; set; }

        #endregion
    }
}
