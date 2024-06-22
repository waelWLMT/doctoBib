using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Commands.CalendrierCmd
{
    /// <summary>
    /// The create calendrier command.
    /// </summary>
    public class CreateCalendrierCommand : IRequest<Calendrier>
    {

        /// <summary>
        /// Gets or sets the date debut.
        /// </summary>
        public DateTime DateDebut { get; set; }
        /// <summary>
        /// Gets or sets the date fin.
        /// </summary>
        public DateTime DateFin { get; set; }
        /// <summary>
        /// Gets or sets the heure debut.
        /// </summary>
        public TimeSpan HeureDebut { get; set; }
        /// <summary>
        /// Gets or sets the heure fin.
        /// </summary>
        public TimeSpan HeureFin { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to lundi.
        /// </summary>
        public bool Lundi { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to mardi.
        /// </summary>
        public bool Mardi { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to mercredi.
        /// </summary>
        public bool Mercredi { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to jeudi.
        /// </summary>
        public bool Jeudi { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to vendredi.
        /// </summary>
        public bool Vendredi { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to samedi.
        /// </summary>
        public bool Samedi { get; set; }
        /// <summary>
        /// Gets or sets  a value indicating whether to dimanche.
        /// </summary>
        public bool Dimanche { get; set; }
        /// <summary>
        /// Gets or sets the praticien id.
        /// </summary>
        public int PraticienId { get; set; }
      


       
    }
}
