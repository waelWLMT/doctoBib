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
    /// The user read data transfer object.
    /// </summary>
    public class UserReadDto : BaseEntityReadDto
    {
        #region Propeties
        /// <summary>
        /// Gets or sets the nom.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Gets or sets the prenom.
        /// </summary>
        public string Prenom { get; set; }        
        
        /// <summary>
        /// Gets or sets the mail adress.
        /// </summary>
        public string MailAdress { get; set; }
        /// <summary>
        /// Gets or sets the tel.
        /// </summary>
        public string Tel { get; set; }

        #endregion

        #region Navigation properties         
        /// <summary>
        /// Gets or sets the adresse id.
        /// </summary>
        public int AdresseId { get; set; }
        /// <summary>
        /// Gets or sets the adresse.
        /// </summary>
        public AdresseReadDto? Adresse { get; set; }
        /// <summary>
        /// Gets or sets the menus.
        /// </summary>
        public List<MenuReadDto>? Menus { get; set; }

        #endregion
    }
}
