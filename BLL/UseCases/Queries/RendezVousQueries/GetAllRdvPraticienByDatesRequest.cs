using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.RendezVousQueries
{
    public class GetAllRdvPraticienByDatesRequest : IRequest<List<RendezVous>>
    {
        public int IdPraticien { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
    }
}
