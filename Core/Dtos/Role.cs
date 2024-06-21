using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    /// <summary>
    /// The role read data transfer object.
    /// </summary>
    public class RoleReadDto : BaseEntityReadDto
    {
        #region Properties
        /// <summary>
        /// Gets or sets the libelle.
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        #endregion

        #region Navigation Properties
        /// <summary>
        /// Gets or sets the menus.
        /// </summary>
        public virtual List<MenuReadDto> Menus { get; set; }

        #endregion
    }
}
