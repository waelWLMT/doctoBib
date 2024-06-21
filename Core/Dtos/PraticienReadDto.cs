using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    /// <summary>
    /// The praticien read data transfer object.
    /// </summary>
    public class PraticienReadDto : UserReadDto
    {
        #region navigation properties

        /// <summary>
        /// Gets or sets the specialite.
        /// </summary>
        public SpecialiteReadDto Specialite { get; set; }

        /// <summary>
        /// Gets or sets the appointments.
        /// </summary>
        public virtual List<RendezVousReadDto> Appointments { get; set; }

        #endregion
    }
}
