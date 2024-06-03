using BLL.Pattern.Impl;
using Core.Models;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ReadServices.Impl
{
    public class UserReadService : ReadServicePattern<User>, IUserReadService
    {
        public UserReadService(IReadRepository<User> readRepository) : base(readRepository) { }

    }
}
