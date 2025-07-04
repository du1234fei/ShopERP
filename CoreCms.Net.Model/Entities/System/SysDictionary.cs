using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    /// 数据字典表
    /// </summary>
    [SugarTable("SysDictionary",TableDescription = "数据字典表")]
    public partial class SysDictionary
    {
        /// <summary>
        /// 数据字典表
        /// </summary>
        public SysDictionary()
        {
        }

        /// <summary>
        /// 字典id
        /// </summary>
        [Display(Name = "字典id")]
        [SugarColumn(ColumnDescription = "字典id", IsPrimaryKey = true, IsIdentity = true)]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 id { get; set; }
        /// <summary>
        /// 字典标识
        /// </summary>
        [Display(Name = "字典标识")]
        [SugarColumn(ColumnDescription = "字典标识")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String dictCode { get; set; }
        /// <summary>
        /// 字典名称
        /// </summary>
        [Display(Name = "字典名称")]
        [SugarColumn(ColumnDescription = "字典名称")]
        [Required(ErrorMessage = "请输入{0}")]
        [StringLength(50, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String dictName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        [SugarColumn(ColumnDescription = "备注", IsNullable = true)]
        [StringLength(500, ErrorMessage = "【{0}】不能超过{1}字符长度")]
        public System.String comments { get; set; }
        /// <summary>
        /// 排序号
        /// </summary>
        [Display(Name = "排序号")]
        [SugarColumn(ColumnDescription = "排序号")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Int32 sortNumber { get; set; }
        /// <summary>
        /// 是否删除,0否,1是
        /// </summary>
        [Display(Name = "是否删除,0否,1是")]
        [SugarColumn(ColumnDescription = "是否删除,0否,1是")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.Boolean deleted { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [SugarColumn(ColumnDescription = "创建时间")]
        [Required(ErrorMessage = "请输入{0}")]
        public System.DateTime createTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [Display(Name = "修改时间")]
        [SugarColumn(ColumnDescription = "修改时间", IsNullable = true)]
        public System.DateTime? updateTime { get; set; }
    }
}