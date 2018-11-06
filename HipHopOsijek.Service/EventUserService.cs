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
    public class EventUserService :  IEventUserService
    {
        protected IEventUserRepository Repository { get; private set; }


        public EventUserService(IEventUserRepository repository)
        {
            this.Repository = repository;
        }


        public Task<List<IEventUser>> GetAsync(EventUserFilter filter = null)
        {
            throw new NotImplementedException();
        }

        Task<IEventUser> IEventUserService.GetAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        Task<List<IEventUser>> IEventUserService.GetCurrentAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}
