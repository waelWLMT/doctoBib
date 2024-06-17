using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    /// <summary>
    /// The departement read data transfer object.
    /// </summary>
    public class DepartementReadDto : BaseEntityReadDto
    {
        /// <summary>
        /// Gets or sets the nom deparetement.
        /// </summary>
        public string NomDeparetement { get; set; }
        /// <summary>
        /// Gets or sets the code departement.
        /// </summary>
        public string CodeDepartement { get; set; }
    }
}
