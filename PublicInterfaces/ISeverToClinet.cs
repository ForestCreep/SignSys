using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PublicInterfaces
{
    /// <summary>
    /// 服务端与客户端通信接口
    /// </summary>
    public interface ISeverToClinet
    {
        /// <summary>
        /// 与服务端建立通信连接，
        /// 即启动监听程序
        /// </summary>
        /// <returns>返回值为bool，确定是否成功启动监听程序</returns>
        bool SetConnectionToClient();

        /// <summary>
        /// 客户端接收服务端已建立连接的远程终结点，
        /// 用于客户端监视窗体显示
        /// </summary>
        /// <returns></returns>
        Dictionary<string, int> ReceiveClientInfo();
    }
}
