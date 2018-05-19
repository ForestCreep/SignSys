using System.Runtime.Serialization;

namespace Person
{
    [DataContract]
    public class PersonInfo 
    {
     
        private string _userNickName;
        [DataMember]
        public string UserNickName { get => _userNickName; set { _userNickName = value;  } }    
        private string _userRealName;
        [DataMember]
        public string UserRealName { get => _userRealName; set { _userRealName = value;  } }
        private string _passWord;
        [DataMember]
        public string PassWord { get => _passWord; set { _passWord = value; } }
        private string _macAddress;
        [DataMember]
        public string MacAddress { get => _macAddress; set { _macAddress = value; } }

    }
}
