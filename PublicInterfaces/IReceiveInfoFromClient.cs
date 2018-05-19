using Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PublicInterfaces
{
    /// <summary>
    /// 服务端从客户端接收数据接口
    /// </summary>
    public interface IReceiveInfoFromClient
    {
        /// <summary>
        /// 接收用户信息函数
        /// </summary>
        /// <returns></returns>
        PersonInfo ReceivePersonInfoFromClient();

        /// <summary>
        /// 接收课表信息函数
        /// </summary>
        /// <returns>PictureInfo</returns>
        PictureInfo ReceivePictureInfoFromClient();

        /// <summary>
        /// 接收签到信息
        /// </summary>
        /// <returns></returns>
        PersonSignInfo ReveiveSignInfoFromClient();

        /// <summary>
        /// 接收状态信息
        /// </summary>
        /// <returns></returns>
        PersonStateInfo ReveiveStateInfoFromClient();
    }
}