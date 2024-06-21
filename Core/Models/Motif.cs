using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The motif.
    /// </summary>
    public class Motif : BaseEntity
    {
        /// <summary>
        /// Gets or sets the libelle.
        /// </summary>
        public string Libelle { get; set; }
        /// <summary>
        /// Gets or sets the desciption.
        /// </summary>
        public string Desciption { get; set; }

    }
}
