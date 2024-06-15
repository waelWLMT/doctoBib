using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The praticien.
    /// </summary>
    public class Praticien : User
    {
        #region Properties
        #endregion

        #region navigation properties
        /// <summary>
        /// Gets or sets the id specialite.
        /// </summary>

        [ForeignKey(nameof(Specialite))]
        public int SpecialiteId { get; set; }
        /// <summary>
        /// Gets or sets the specialite.
        /// </summary>
        public Specialite Specialite { get; set; }

        public virtual List<RendezVous> Appointments { get; set; }

        #endregion
    }
}
