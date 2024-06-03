using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    /// <summary>
    /// The base entity.
    /// </summary>
    public class BaseEntity : IEntity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Column(Order = 0)]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        [Column(Order = 1)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        /// <summary>
        /// Gets or sets the last modif at.
        /// </summary>
        [Column(Order = 2)]
        public DateTime LastModifAt { get; set; } = DateTime.Now;
    }
}
