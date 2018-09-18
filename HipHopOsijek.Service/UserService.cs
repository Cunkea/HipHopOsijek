using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HipHopOsijek.Service.Common;
using HipHopOsijek.Repository.Common;
using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;

namespace HipHopOsijek.Service
{
    public class UserService : IUserService
    {
        protected IUserRepository Repository { get; private set; }
        

        public UserService(IUserRepository repository)
        {
            this.Repository = repository;
        }


        public Task<List<IUser>> GetAsync(UserFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IUser> GetAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IUser>> GetCurrentAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

    }
}
