﻿using BLL.Pattern.Impl;
using Core.Models;
using Data.RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.WriteServices.Impl
{
    /// <summary>
    /// The user service.
    /// </summary>
    public class UserService : ServicePattern<User>, IUserService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="unitOfWork">The unit of work.</param>
        public UserService(IRepository<User> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
