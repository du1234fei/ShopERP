
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.UI;

namespace CoreCms.Net.IServices
{
    /// <summary>
    ///     支付宝支付 服务工厂接口
    /// </summary>
    public interface IAliPayServices : IBaseServices<CoreCmsSetting>
    {
        /// <summary>
        ///     发起支付
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        WebApiCallBack PubPay(CoreCmsBillPayments entity);
    }
}