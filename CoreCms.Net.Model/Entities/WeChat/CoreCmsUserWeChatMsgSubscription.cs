using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    /// 微信订阅消息存储表
    /// </summary>
    [SugarTable("CoreCmsUserWeChatMsgSubscription",TableDescription = "微信订阅消息存储表")]
    public partial class CoreCmsUserWeChatMsgSubscription
    {
        /// <summary>
        /// 微信订阅消息存储表
        /// </summary>
        public CoreCmsUserWeChatMsgSubscription()
        {
        }

        /// <summary>
        /// 序列
        /// </summary>
        [Display(Name = "序列")]
        [SugarColumn(ColumnDescription = "序列", IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 id { get; set; }
        /// <summary>
        /// 模板Id
        /// </summary>
        [Display(Name = "模板Id")]
        [SugarColumn(ColumnDescription = "模板Id")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String templateId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        [Display(Name = "用户Id")]
        [SugarColumn(ColumnDescription = "用户Id")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 userId { get; set; }
        /// <summary>
        /// 订阅类型
        /// </summary>
        [Display(Name = "订阅类型")]
        [SugarColumn(ColumnDescription = "订阅类型")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String type { get; set; }
    }
}