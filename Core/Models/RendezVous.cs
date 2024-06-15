using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The rendez vous.
    /// </summary>
    public class RendezVous : BaseEntity
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
        [ForeignKey(nameof(Patient))]
        public int PatientId { get; set; }
        /// <summary>
        /// Gets or sets the patient.
        /// </summary>
        public required virtual Patient Patient { get; set; }

        /// <summary>
        /// Gets or sets the praticien id.
        /// </summary>
        [ForeignKey(nameof(Praticien))]
        public int PraticienId { get; set; }
        /// <summary>
        /// Gets or sets the praticien.
        /// </summary>
        public required virtual Praticien Praticien { get; set; }

        /// <summary>
        /// Gets or sets the motif id.
        /// </summary>
        [ForeignKey(nameof(Motif))]
        public int MotifId { get; set; }
        /// <summary>
        /// Gets or sets the motif.
        /// </summary>
        public virtual Motif Motif { get; set; }

        #endregion

    }
}
