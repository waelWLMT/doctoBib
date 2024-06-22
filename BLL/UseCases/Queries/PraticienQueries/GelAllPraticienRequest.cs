using Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.UseCases.Queries.PraticienQueries
{
    public class GelAllPraticienRequest : IRequest<List<Praticien>>
    {

    }
}
