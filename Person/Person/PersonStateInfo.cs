using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    [DataContract]
    public enum PersonStateInfo
    {
        [EnumMember]
        上课,
        [EnumMember]
        请假
    }
}
