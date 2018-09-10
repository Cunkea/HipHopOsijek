using HipHopOsijek.Model.Common;
using HipHopOsijek.Common.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Repository.Common
{
    public interface ICommentRepository
    {
        Task<List<IComment>> GetAsync(CommentFilter filter = null);
        Task<IComment> GetAsync(Guid? id);
        Task<List<IComment>> GetCurrentAsync();
        Task<int> DeleteAsync(Guid? id);
    }
}
