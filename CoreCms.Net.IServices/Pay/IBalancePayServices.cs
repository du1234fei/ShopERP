
using System.Threading.Tasks;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.UI;

namespace CoreCms.Net.IServices
{
    /// <summary>
    ///     余额支付 服务工厂接口
    /// </summary>
    public interface IBalancePayServices : IBaseServices<CoreCmsSetting>
    {
        /// <summary>
        ///     发起支付
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        Task<WebApiCallBack> PubPay(CoreCmsBillPayments entity);


        /// <summary>
        ///     用户余额退款
        /// </summary>
        /// <param name="refundInfo">退款单数据</param>
        /// <param name="paymentInfo">支付单数据</param>
        /// <returns></returns>
        Task<WebApiCallBack> Refund(CoreCmsBillRefund refundInfo, CoreCmsBillPayments paymentInfo);
    }
}