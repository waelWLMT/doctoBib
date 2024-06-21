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
    /// The adresse read data transfer object.
    /// </summary>
    public class AdresseReadDto : BaseEntityReadDto
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
        public int DepartementId { get; set; }
        /// <summary>
        /// Gets or sets the departement.
        /// </summary>
        public DepartementReadDto? Departement { get; set; }
        /// <summary>
        /// Gets or sets the ville id.
        /// </summary>
        public int VilleId { get; set; }
        /// <summary>
        /// Gets or sets the ville.
        /// </summary>
        public VilleReadDto? Ville { get; set; }

        #endregion

    }
}
