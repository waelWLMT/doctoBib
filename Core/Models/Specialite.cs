using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The specialite.
    /// </summary>
    public class Specialite : BaseEntity
    {

        #region Properties
        /// <summary>
        /// Gets or sets the libelle.
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description  { get; set; }
        /// <summary>
        /// Gets or sets the motifs.
        /// </summary>
        public virtual List<Motif> Motifs { get; set; }

        #endregion

        #region Navigation Properties

        /// <summary>
        /// Gets or sets the praticiens.
        /// </summary>
        public virtual List<Praticien> Praticiens { get; set; }

        #endregion

    }
}
