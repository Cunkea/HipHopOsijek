using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using HipHopOsijek.DAL;
using HipHopOsijek.Model.Common;

namespace HipHopOsijek.Model
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IComment>().To<CommentPoco>();
            Bind<IEventUser>().To<EventUserPoco>();
            Bind<IEvent>().To<EventPoco>();
            Bind<IPerson>().To<PersonPoco>();
        }
    }
}
