using Person;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicInterfaces
{
    [Obsolete]
    public interface IReceiveInfoFromServer
    {
        /// <summary>
        /// 从服务端接收（课表信息）
        /// </summary>
        /// <returns>返回课表信息类</returns>
        PictureInfo ReceivePictureFromServer();

        /// <summary>
        /// 从服务端接收今日是否已签到
        /// </summary>
        /// <returns>返回是否已签到</returns>
        bool ReceiveSignInfoFromServer();

        /// <summary>
        /// 从服务端接收所有的签到信息
        /// </summary>
        /// <returns>返回签到信息的集合</returns>
        ObservableCollection<PersonSignInfo> ReceiveAllSignInfoFromServer();
    }
}
