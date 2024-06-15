using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{

    /// <summary>
    /// The user.
    /// </summary>
    public class User : BaseEntity
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
        /// Gets or sets the login.
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Gets or sets the crypted password.
        /// </summary>
        public string CryptedPassword { get; set; }
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

        [ForeignKey(nameof(Adresse))]
        public int AdresseId { get; set; }
        public virtual Adresse Adresse { get; set; }
        public virtual List<Menu> Menus { get; set; }

        #endregion

    }
}
