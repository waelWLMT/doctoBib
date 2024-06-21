using BLL.Pattern;
using Core.Models;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices
{
    public interface IPatientReadService : IReadServicePattern<Patient>
    {
    }
}
