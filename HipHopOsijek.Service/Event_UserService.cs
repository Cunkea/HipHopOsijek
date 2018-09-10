using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;
using HipHopOsijek.Repository.Common;
using HipHopOsijek.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Service
{
    public class Event_UserService :  IEvent_UserService
    {
        protected IEvent_UserRepository Repository { get; private set; }


        public Event_UserService(IEvent_UserRepository repository)
        {
            this.Repository = repository;
        }


        public Task<List<IEvent_User>> GetAsync(Event_UserFilter filter = null)
        {
            throw new NotImplementedException();
        }

        Task<IEvent_User> IEvent_UserService.GetAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        Task<List<IEvent_User>> IEvent_UserService.GetCurrentAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}
