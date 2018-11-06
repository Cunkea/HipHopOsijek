using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HipHopOsijek.Service.Common;
using HipHopOsijek.Repository.Common;
using HipHopOsijek.Common.Filters;
using HipHopOsijek.Model.Common;

namespace HipHopOsijek.Service
{
    public class PersonService : IPersonService
    {
        protected IPersonRepository Repository { get; private set; }
        

        public PersonService(IPersonRepository repository)
        {
            this.Repository = repository;
        }


        public Task<List<IPerson>> GetAsync(PersonFilter filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<IPerson> GetAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IPerson>> GetCurrentAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

    }
}
