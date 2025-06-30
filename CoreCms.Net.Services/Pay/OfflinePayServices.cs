
using CoreCms.Net.IRepository;
using CoreCms.Net.IServices;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.UI;

namespace CoreCms.Net.Services
{
    /// <summary>
    ///     线下支付 接口实现
    /// </summary>
    public class OfflinePayServices : BaseServices<CoreCmsSetting>, IOfflinePayServices
    {
        public OfflinePayServices(IWeChatPayRepository dal)
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
            var jm = new WebApiCallBack {status = true};

            return jm;
        }
    }
}