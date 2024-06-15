using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The adresse.
    /// </summary>
    public class Adresse : BaseEntity
    {
        /// <summary>
        /// Gets or sets the numero.
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Gets or sets the rue boulevard.
        /// </summary>
        public string RueBoulevard { get; set; }  

        #region Navigation properties

        /// <summary>
        /// Gets or sets the departement id.
        /// </summary>
        [ForeignKey(nameof(Departement))]
        public int DepartementId { get; set; }
        /// <summary>
        /// Gets or sets the departement.
        /// </summary>
        public virtual Departement? Departement { get; set; }

        /// <summary>
        /// Gets or sets the ville id.
        /// </summary>
        [ForeignKey(nameof(Ville))]
        public int VilleId { get; set; }

        /// <summary>
        /// Gets or sets the ville.
        /// </summary>
        public virtual Ville? Ville { get; set; }

        #endregion

    }
}
