using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Repository.Common
{
    public interface IEventUserRepository
    {
        Task<List<IEventUser>> GetAsync(EventUserFilter filter = null);
        Task<IEventUser> GetAsync(Guid? id);
        Task<List<IEventUser>> GetCurrentAsync();
        Task<int> DeleteAsync(Guid? id);
    }
}
