
using System.ComponentModel.DataAnnotations;
using SqlSugar;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     商品收藏
    /// </summary>
    public partial class CoreCmsGoodsCollection
    {
        /// <summary>
        ///     商品信息
        /// </summary>
        [Display(Name = "商品信息")]
        [SugarColumn(IsIgnore = true)]
        public CoreCmsGoods goods { get; set; }
    }
}