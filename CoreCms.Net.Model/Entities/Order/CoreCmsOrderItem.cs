using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    /// 订单明细表
    /// </summary>
    [SugarTable("CoreCmsOrderItem",TableDescription = "订单明细表")]
    public partial class CoreCmsOrderItem
    {
        /// <summary>
        /// 订单明细表
        /// </summary>
        public CoreCmsOrderItem()
        {
        }

        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        [SugarColumn(ColumnDescription = "序号", IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 id { get; set; }
        /// <summary>
        /// 订单ID 关联order.id
        /// </summary>
        [Display(Name = "订单ID 关联order.id")]
        [SugarColumn(ColumnDescription = "订单ID 关联order.id")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(20, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String orderId { get; set; }
        /// <summary>
        /// 商品ID 关联goods.id
        /// </summary>
        [Display(Name = "商品ID 关联goods.id")]
        [SugarColumn(ColumnDescription = "商品ID 关联goods.id")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 goodsId { get; set; }
        /// <summary>
        /// 货品ID 关联products.id
        /// </summary>
        [Display(Name = "货品ID 关联products.id")]
        [SugarColumn(ColumnDescription = "货品ID 关联products.id")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 productId { get; set; }
        /// <summary>
        /// 货品编码
        /// </summary>
        [Display(Name = "货品编码")]
        [SugarColumn(ColumnDescription = "货品编码", IsNullable = true)]
        [StringLength(30, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String sn { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        [Display(Name = "商品编码")]
        [SugarColumn(ColumnDescription = "商品编码", IsNullable = true)]
        [StringLength(30, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String bn { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [Display(Name = "商品名称")]
        [SugarColumn(ColumnDescription = "商品名称")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(200, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String name { get; set; }
        /// <summary>
        /// 货品价格单价
        /// </summary>
        [Display(Name = "货品价格单价")]
        [SugarColumn(ColumnDescription = "货品价格单价")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Decimal price { get; set; }
        /// <summary>
        /// 货品成本价单价
        /// </summary>
        [Display(Name = "货品成本价单价")]
        [SugarColumn(ColumnDescription = "货品成本价单价")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Decimal costprice { get; set; }
        /// <summary>
        /// 市场价
        /// </summary>
        [Display(Name = "市场价")]
        [SugarColumn(ColumnDescription = "市场价")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Decimal mktprice { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        [Display(Name = "图片")]
        [SugarColumn(ColumnDescription = "图片")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(100, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String imageUrl { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [Display(Name = "数量")]
        [SugarColumn(ColumnDescription = "数量")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 nums { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        [Display(Name = "总价")]
        [SugarColumn(ColumnDescription = "总价")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Decimal amount { get; set; }
        /// <summary>
        /// 商品优惠总金额
        /// </summary>
        [Display(Name = "商品优惠总金额")]
        [SugarColumn(ColumnDescription = "商品优惠总金额")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Decimal promotionAmount { get; set; }
        /// <summary>
        /// 促销信息
        /// </summary>
        [Display(Name = "促销信息")]
        [SugarColumn(ColumnDescription = "促销信息", IsNullable = true)]
        [StringLength(255, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String promotionList { get; set; }
        /// <summary>
        /// 总重量
        /// </summary>
        [Display(Name = "总重量")]
        [SugarColumn(ColumnDescription = "总重量")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Decimal weight { get; set; }
        /// <summary>
        /// 发货数量
        /// </summary>
        [Display(Name = "发货数量")]
        [SugarColumn(ColumnDescription = "发货数量")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 sendNums { get; set; }
        /// <summary>
        /// 货品明细序列号存储
        /// </summary>
        [Display(Name = "货品明细序列号存储")]
        [SugarColumn(ColumnDescription = "货品明细序列号存储", IsNullable = true)]
        public System.String addon { get; set; }
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
    }
}