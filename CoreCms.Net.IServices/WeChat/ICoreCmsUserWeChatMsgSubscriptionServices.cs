
using System.Threading.Tasks;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.UI;

namespace CoreCms.Net.IServices
{
    /// <summary>
    ///     微信订阅消息存储表 服务工厂接口
    /// </summary>
    public interface ICoreCmsUserWeChatMsgSubscriptionServices : IBaseServices<CoreCmsUserWeChatMsgSubscription>
    {
        /// <summary>
        ///     获取模板信息
        /// </summary>
        /// <returns></returns>
        Task<WebApiCallBack> tmpl(int userId);

        /// <summary>
        ///     设置订阅状态
        /// </summary>
        /// <returns></returns>
        Task<WebApiCallBack> SetTip(int userId, string templateId, string status);
    }
}