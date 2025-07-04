using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    /// 购物车表
    /// </summary>
    [SugarTable("CoreCmsCart",TableDescription = "购物车表")]
    public partial class CoreCmsCart
    {
        /// <summary>
        /// 购物车表
        /// </summary>
        public CoreCmsCart()
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
        /// 用户序列
        /// </summary>
        [Display(Name = "用户序列")]
        [SugarColumn(ColumnDescription = "用户序列")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 userId { get; set; }
        /// <summary>
        /// 货品序列
        /// </summary>
        [Display(Name = "货品序列")]
        [SugarColumn(ColumnDescription = "货品序列")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 productId { get; set; }
        /// <summary>
        /// 货品数量
        /// </summary>
        [Display(Name = "货品数量")]
        [SugarColumn(ColumnDescription = "货品数量")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 nums { get; set; }
        /// <summary>
        /// 购物车类型
        /// </summary>
        [Display(Name = "购物车类型")]
        [SugarColumn(ColumnDescription = "购物车类型")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 type { get; set; }



        /// <summary>
        ///     关联对象序列
        /// </summary>
        [Display(Name = "关联对象序列")]
        [Required(ErrorMessage = "请输入{0}")]
        public int objectId { get; set; }

    }
}