using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    [DataContract]
    public class PictureInfo
    {
        private string _userNickName;
        private byte[] _picture;

        private TimetableAndExpPic _ttAndEP;

        public TimetableAndExpPic TtAndEP { get => _ttAndEP; set { _ttAndEP = value;} }

        public string UserNickName { get => _userNickName; set { _userNickName = value;  } }
        public byte[] Picture { get => _picture; set { _picture = value; } }
    }
    [DataContract]
    public enum TimetableAndExpPic
    {
        [EnumMember]
        课程表,
        [EnumMember]
        实验表
    }
}
