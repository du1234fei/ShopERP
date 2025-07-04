
using System.Threading.Tasks;
using CoreCms.Net.Model.ViewModels.Basics;
using CoreCms.Net.Model.ViewModels.Echarts;
using CoreCms.Net.Model.ViewModels.UI;

namespace CoreCms.Net.IRepository
{
    /// <summary>
    ///     报表通用返回 工厂接口
    /// </summary>
    public interface ICoreCmsReportsRepository : IBaseRepository<GetOrdersReportsDbSelectOut>
    {
        /// <summary>
        ///     获取订单销量查询返回结果
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="filter"></param>
        /// <param name="filterSed"></param>
        /// <param name="thesort"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<IPageList<GoodsSalesVolume>> GetGoodsSalesVolumes(string start, string end, string filter,
            string filterSed,
            string thesort, int pageIndex = 1, int pageSize = 5000);


        /// <summary>
        ///     获取商品收藏查询返回结果
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="thesort"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<IPageList<GoodsCollection>> GetGoodsCollections(string start, string end, string thesort,
            int pageIndex = 1, int pageSize = 5000);
    }
}