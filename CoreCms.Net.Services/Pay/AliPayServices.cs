
using CoreCms.Net.IRepository;
using CoreCms.Net.IServices;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.UI;

namespace CoreCms.Net.Services
{
    /// <summary>
    ///     支付宝支付 接口实现
    /// </summary>
    public class AliPayServices : BaseServices<CoreCmsSetting>, IAliPayServices
    {
        public AliPayServices(IWeChatPayRepository dal)
        {
            BaseDal = dal;
        }

        /// <summary>
        ///     发起支付
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        public WebApiCallBack PubPay(CoreCmsBillPayments entity)
        {
            var jm = new WebApiCallBack();
            return jm;
        }
    }
}