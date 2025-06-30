
using System.Threading.Tasks;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.UI;

namespace CoreCms.Net.IServices
{
    /// <summary>
    ///     用户订阅提醒状态 服务工厂接口
    /// </summary>
    public interface
        ICoreCmsUserWeChatMsgSubscriptionSwitchServices : IBaseServices<CoreCmsUserWeChatMsgSubscriptionSwitch>
    {
        /// <summary>
        ///     获取用户是否订阅
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<WebApiCallBack> IsTip(int userId);


        /// <summary>
        ///     获取用户是否订阅
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<WebApiCallBack> CloseTip(int userId);
    }
}