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
    /// The rendez vous read data transfer object.
    /// </summary>
    public class RendezVousReadDto
    {
        #region Properties       

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the heure.
        /// </summary>
        public TimeSpan Heure { get; set; }
        /// <summary>
        /// Gets or sets the recaputulatif.
        /// </summary>
        public String Recaputulatif { get; set; }
        /// <summary>
        /// Gets or sets the remarque.
        /// </summary>
        public string Remarque { get; set; }

        #endregion

        #region Navigation properties  

        /// <summary>
        /// Gets or sets the patient id.
        /// </summary>
        public int PatientId { get; set; }
        /// <summary>
        /// Gets or sets the patient.
        /// </summary>
        public PatientReadDto Patient { get; set; }
        /// <summary>
        /// Gets or sets the praticien id.
        /// </summary>
        public int PraticienId { get; set; }
        /// <summary>
        /// Gets or sets the praticien.
        /// </summary>
        public PraticienReadDto Praticien { get; set; }
        /// <summary>
        /// Gets or sets the motif id.
        /// </summary>
        public int MotifId { get; set; }
        /// <summary>
        /// Gets or sets the motif.
        /// </summary>
        public MotifReadDto Motif { get; set; }

        #endregion

    }
}
