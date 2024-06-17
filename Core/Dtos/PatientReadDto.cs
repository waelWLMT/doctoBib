using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    /// <summary>
    /// The patient read data transfer object.
    /// </summary>
    public class PatientReadDto : UserReadDto
    {
        /// <summary>
        /// Gets or sets the date naissance.
        /// </summary>
        public DateTime DateNaissance { get; set; }
    }
}
