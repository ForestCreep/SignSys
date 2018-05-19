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
    /// <summary>
    /// 服务端向客户端发送信息接口
    /// </summary>
    public interface ISendInfoToClient
    {
        /// <summary>
        /// 发送（课表信息）至客户端
        /// </summary>
        /// <param name="picture">图片对象</param>
        bool SendPictureToClint(PictureInfo picture);

        /// <summary>
        /// 发送（是否签到）至客户端
        /// </summary>
        /// <param name="personSignInfo"></param>
        /// <returns></returns>
        bool SendSignInfoToClient(bool ifSigned);
        
        /// <summary>
        /// 发送全部签到信息至客户端
        /// </summary>
        /// <param name="allSignInfo"></param>
        /// <returns></returns>
        bool SendAllSignInfoToClient(ObservableCollection<PersonSignInfo> allSignInfo);
    }
}
