﻿using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Service.Common
{
    public interface IUserService
    {
        Task<List<IUser>> GetAsync(UserFilter filter = null);
        Task<IUser> GetAsync(Guid? id);
        Task<List<IUser>> GetCurrentAsync();
        Task<int> DeleteAsync(Guid? id);
    }
}
