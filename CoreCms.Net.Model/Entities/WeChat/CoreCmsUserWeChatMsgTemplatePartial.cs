
using SqlSugar;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     微信小程序消息模板
    /// </summary>
    public partial class CoreCmsUserWeChatMsgTemplate
    {
        /// <summary>
        ///     是否订阅
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public bool @is { get; set; }
    }
}