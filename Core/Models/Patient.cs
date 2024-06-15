using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The patient.
    /// </summary>
    public class Patient : User
    {
        /// <summary>
        /// Gets or sets the date naissance.
        /// </summary>
        public DateTime DateNaissance { get; set; }

        #region Navigation properties

        public virtual List<RendezVous> Appointments { get; set; }


        #endregion
    }
}
