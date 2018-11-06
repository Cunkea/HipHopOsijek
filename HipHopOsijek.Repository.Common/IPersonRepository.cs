using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Repository.Common
{
    public interface IPersonRepository
    {
        Task<List<IPerson>> GetAsync(PersonFilter filter = null);
        Task<IPerson> GetAsync(Guid? id);
        Task<List<IPerson>> GetCurrentAsync();
        Task<int> DeleteAsync(Guid? id);
    }
}
