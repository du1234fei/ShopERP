using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    /// 代理商订单记录表
    /// </summary>
    [SugarTable("CoreCmsAgentOrder",TableDescription = "代理商订单记录表")]
    public partial class CoreCmsAgentOrder
    {
        /// <summary>
        /// 代理商订单记录表
        /// </summary>
        public CoreCmsAgentOrder()
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
        /// 用户代理商id
        /// </summary>
        [Display(Name = "用户代理商id")]
        [SugarColumn(ColumnDescription = "用户代理商id")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 userId { get; set; }
        /// <summary>
        /// 下单用户id
        /// </summary>
        [Display(Name = "下单用户id")]
        [SugarColumn(ColumnDescription = "下单用户id")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 buyUserId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        [Display(Name = "订单编号")]
        [SugarColumn(ColumnDescription = "订单编号", IsNullable = true)]
        [StringLength(50, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String orderId { get; set; }
        /// <summary>
        /// 结算金额
        /// </summary>
        [Display(Name = "结算金额")]
        [SugarColumn(ColumnDescription = "结算金额")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Decimal amount { get; set; }
        /// <summary>
        /// 是否结算
        /// </summary>
        [Display(Name = "是否结算")]
        [SugarColumn(ColumnDescription = "是否结算")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 isSettlement { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [SugarColumn(ColumnDescription = "创建时间")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.DateTime createTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [Display(Name = "更新时间")]
        [SugarColumn(ColumnDescription = "更新时间", IsNullable = true)]
        public System.DateTime? updateTime { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [Display(Name = "是否删除")]
        [SugarColumn(ColumnDescription = "是否删除")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Boolean isDelete { get; set; }
    }
}