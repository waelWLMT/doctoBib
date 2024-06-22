using BLL.UseCases.Commands.CalendrierCmd;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Usefull.Impl
{
    public class CalendrierBuilder : ICalendrierBuilder
    {
        /// <summary>
        /// Build from calendrier cmd.
        /// </summary>
        /// <param name="cmd">The cmd.</param>
        /// <returns>A Calendrier</returns>
        public Calendrier BuildFromCalendrierCmd(CreateCalendrierCommand cmd)
        {
            var calendrier = new Calendrier();

            calendrier.DateDebut = cmd.DateDebut;
            calendrier.DateFin = cmd.DateFin;
            calendrier.HeureDebut = cmd.HeureDebut;
            calendrier.HeureFin = cmd.HeureFin;

            calendrier.Lundi = cmd.Lundi;
            calendrier.Mardi = cmd.Mardi;
            calendrier.Mercredi = cmd.Mercredi;
            calendrier.Jeudi = cmd.Jeudi;
            calendrier.Vendredi = cmd.Vendredi;
            calendrier.Samedi = cmd.Samedi;
            calendrier.Dimanche = cmd.Dimanche;

            calendrier.PraticienId = cmd.PraticienId;

            return calendrier;

        }
    }
}
