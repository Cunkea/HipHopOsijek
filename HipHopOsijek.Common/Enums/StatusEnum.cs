using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipHopOsijek.Common.Enums
{
    public enum StatusEnum
    {
        [Description("Active")]
        active = 1,
        [Description("Inactive")]
        inactive = 2,
        [Description("Banned")]
        banned = 3
    }
}
