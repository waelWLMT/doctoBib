using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The ville.
    /// </summary>
    public class Ville : BaseEntity
    {

        #region Properties
        
        /// <summary>
        /// Gets or sets the nom ville.
        /// </summary>
        public string NomVille { get; set; }
        /// <summary>
        /// Gets or sets the code postal.
        /// </summary>
        public string CodePostal { get; set; }
        /// <summary>
        /// Gets or sets the libelle.
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// Gets or sets the canton.
        /// </summary>
        public string Canton { get; set; }
        /// <summary>
        /// Gets or sets the borough.
        /// </summary>
        public string Borough { get; set; }

        /// <summary>
        /// Gets or sets the lat.
        /// </summary>
        public float Lat { get; set; }
        /// <summary>
        /// Gets or sets the lng.
        /// </summary>
        public float Lng { get; set; }

        #endregion

        #region Navigation properties

        /// <summary>
        /// Gets or sets the departement id.
        /// </summary>
        [ForeignKey(nameof(Departement))]
        public  int DepartementId { get; set; }
        /// <summary>
        /// Gets or sets the departement.
        /// </summary>
        public virtual Departement Departement { get; set; }       

        #endregion

    }
}
