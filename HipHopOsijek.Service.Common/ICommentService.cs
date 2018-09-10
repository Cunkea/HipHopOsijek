using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Service.Common
{
    public interface ICommentService
    {
        Task<List<IComment>> GetAsync(CommentFilter filter = null);
        Task<IComment> GetAsync(Guid? id);
        Task<List<IComment>> GetCurrentAsync();
        Task<int> DeleteAsync(Guid? id);
    }
}
