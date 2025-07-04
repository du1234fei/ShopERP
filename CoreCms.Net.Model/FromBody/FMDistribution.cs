﻿

namespace CoreCms.Net.Model.FromBody
{
    //API接口提交================================================
    /// <summary>
    ///     申请成为分销商接口提交参数
    /// </summary>
    public class FMDistributionApply
    {
        public string agreement { get; set; }
        public string mobile { get; set; }
        public string name { get; set; }
        public string qq { get; set; }
        public string weixin { get; set; }
    }


    /// <summary>
    ///     店铺设置提交参数
    /// </summary>
    public class FMSetDistributionStorePost
    {
        public string storeBanner { get; set; }
        public string storeDesc { get; set; }
        public string storeLogo { get; set; }
        public string storeName { get; set; }
    }
}