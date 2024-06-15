using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Role : BaseEntity
    {
        #region Properties
        public string Libelle { get; set; }
        public string Description { get; set; }        

        #endregion


        #region Navigation Properties
        public virtual List<Menu> Menus { get; set; }

        #endregion
    }
}
