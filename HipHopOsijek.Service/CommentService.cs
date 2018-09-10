using HipHopOsijek.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;

namespace HipHopOsijek.Service
{
    class CommentService : ICommentService
    {
        protected ICommentService Repository { get; private set; }


        public CommentService(ICommentService repository)
        {
            this.Repository = repository;
        }

        public Task<int> DeleteAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<IComment> GetAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IComment>> GetAsync(CommentFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<IComment>> GetCurrentAsync()
        {
            throw new NotImplementedException();
        }
    }
}
