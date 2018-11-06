﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Model.Common
{
    public interface IEventUser
    {
        SqlInt64 Id { get; set; }
        SqlInt64 PersonId { get; set; }
        SqlInt64 EventId { get; set; }
        DateTime DateCreated { get; set; }
    }
}