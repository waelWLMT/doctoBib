using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    /// <summary>
    /// The motif read data transfer object.
    /// </summary>
    public class MotifReadDto : BaseEntityReadDto
    {
        /// <summary>
        /// Gets or sets the libelle.
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// Gets or sets the desciption.
        /// </summary>
        public string Desciption { get; set; }

    }
}
