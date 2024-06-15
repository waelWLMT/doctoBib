using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Menu : BaseEntity
    {
        public string Libelle { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

        #region Navigation properties
        public virtual List<Role> Roles { get; set; }

        #endregion
    }
}
