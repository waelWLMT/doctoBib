using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The menu.
    /// </summary>
    public class Menu : BaseEntity
    {
        /// <summary>
        /// Gets or sets the libelle.
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        #region Navigation properties
        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        public virtual List<Role> Roles { get; set; }

        #endregion
    }
}
