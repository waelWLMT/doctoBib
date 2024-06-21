using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices
{
    public interface ICommuneReadService
    {
        Task<object> GetAllCommune();
        Task<object> GetCommuneByCodePostal(string codePostal);
        Task<object> GetCommuneByCodeDepartement(string codeDepartement);
        Task<object> GetCommuneByEpciCode(string epciCode);        
    }
}
