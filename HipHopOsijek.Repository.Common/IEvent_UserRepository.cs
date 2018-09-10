using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Repository.Common
{
    public interface IEvent_UserRepository
    {
        Task<List<IEvent_User>> GetAsync(Event_UserFilter filter = null);
        Task<IEvent_User> GetAsync(Guid? id);
        Task<List<IEvent_User>> GetCurrentAsync();
        Task<int> DeleteAsync(Guid? id);
    }
}
