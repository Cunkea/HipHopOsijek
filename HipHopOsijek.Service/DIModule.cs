﻿using HipHopOsijek.Service.Common;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Service
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommentService>().To<CommentService>();
            Bind<IEventService>().To<EventService>();
            Bind<IEvent_UserService>().To<Event_UserService>();
            Bind<IUserService>().To<UserService>();
        }
    }
}