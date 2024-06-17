using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    /// <summary>
    /// The menu read data transfer object.
    /// </summary>
    public class MenuReadDto
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

    }
}
