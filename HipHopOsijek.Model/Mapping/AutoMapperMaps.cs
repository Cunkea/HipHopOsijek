using HipHopOsijek.DAL.Entities;
using HipHopOsijek.Model.Common;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace HipHopOsijek.Model
{
    public class AutoMapperMaps : Profile
    {
        public AutoMapperMaps()
        {
            CreateMap<Comment, CommentPoco>().ReverseMap();
            CreateMap<Comment, IComment>().ReverseMap();
            CreateMap<IComment, CommentPoco>().ReverseMap();

            CreateMap<Event, EventPoco>().ReverseMap();
            CreateMap<Event, IEvent>().ReverseMap();
            CreateMap<IEvent, EventPoco>().ReverseMap();

            CreateMap<Event_User, Event_UserPoco>().ReverseMap();
            CreateMap<Event_User, IEvent_User>().ReverseMap();
            CreateMap<IEvent_User, Event_UserPoco>().ReverseMap();

            CreateMap<User, UserPoco>().ReverseMap();
            CreateMap<User, IUser>().ReverseMap();
            CreateMap<IUser, UserPoco>().ReverseMap();
        }
    }
}
