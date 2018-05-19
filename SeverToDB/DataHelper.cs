using Person;
using PublicInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeverToDB
{
    public class DataHelper : ISendInfoToDB
    {
        private Entities1 entities = EntityHelper.GetEntities();

        [Obsolete("已停用")]
        public bool SendChangePersonInfoToDB(PersonInfo personInfo)
        {
            throw new NotImplementedException();
        }

        public bool SendDeleteUserInfoToDB(PersonInfo person)
        {
            throw new NotImplementedException();
        }

        public bool SendNewPersonInfoToDB(PersonInfo personInfo)
        {
            if (entities.USERINFO.Where(x => x.NICKNAME == personInfo.UserNickName).ToList().Count == 1)
                return false;
            var count = entities.USERINFO.ToList().Count;
            USERINFO userInfo = new USERINFO()
            {
                NICKNAME = personInfo.UserNickName,
                REALNAME = personInfo.UserRealName,
                PASSWORD = personInfo.PassWord,
                MACADDRESS = personInfo.MacAddress,
                USERID = count + 1
            };
            entities.USERINFO.Add(userInfo);

            try
            {
                var num = entities.SaveChanges();
                if (num == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        [Obsolete("已停用")]
        public bool SendPictureInfoToDB(PictureInfo picture)
        {
            //var buffer = Encoding.Default.GetBytes();

            return false;
        }

        [Obsolete("已停用")]
        public bool SendPictureInfoToDB(PictureInfo picture, TimetableAndExpPic type)
        {
            throw new NotImplementedException();
        }

        [Obsolete("已停用")]
        public bool SendSignInfoToDB(PersonSignInfo personSign)
        {
            throw new NotImplementedException();
        }
    }
}
