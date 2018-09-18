using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Repository.Common
{
    public interface IEventRepository
    {
        Task<List<IEvent>> GetAsync(EventFilter filter = null);
        Task<IEvent> GetAsync(Guid? id);
        Task<List<IEvent>> GetCurrentAsync();
        Task<int> DeleteAsync(Guid? id);
        Task<int> UpdateAsync(IEvent e);
        Task<List<IComment>> GetCurrentAsync(Guid? id);
    }
}
