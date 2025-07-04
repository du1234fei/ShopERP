
using SqlSugar;

namespace CoreCms.Net.Model.Entities
{
    /// <summary>
    ///     配送方式表
    /// </summary>
    public partial class CoreCmsShip
    {
        /// <summary>
        ///     商品总额满多少免运费
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public object areaFeeObj { get; set; } = null;
    }
}