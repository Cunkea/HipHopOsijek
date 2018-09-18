using HipHopOsijek.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;
using HipHopOsijek.Repository.Common;

namespace HipHopOsijek.Service
{
    public class EventService : IEventService
    {
        protected IEventRepository Repository { get; private set; }


        public EventService(IEventRepository repository)
        {
            this.Repository = repository;
        }

        

        public Task<int> DeleteAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEvent> GetAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IEvent>> GetAsync(EventFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<IEvent>> GetCurrentAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(IEvent e)
        {
            throw new NotImplementedException();
        }

        public Task<List<IComment>> GetCommentsAsync(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}
