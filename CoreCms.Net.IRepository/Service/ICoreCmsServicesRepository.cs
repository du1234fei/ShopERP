
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.Basics;
using SqlSugar;

namespace CoreCms.Net.IRepository
{
    /// <summary>
    ///     服务项目表 工厂接口
    /// </summary>
    public interface ICoreCmsServicesRepository : IBaseRepository<CoreCmsServices>
    {
        /// <summary>
        ///     根据条件查询分页数据
        /// </summary>
        /// <param name="predicate">判断集合</param>
        /// <param name="orderByType">排序方式</param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="orderByExpression"></param>
        /// <returns></returns>
        Task<IPageList<CoreCmsServices>> TagQueryPageAsync(
            Expression<Func<CoreCmsServices, bool>> predicate,
            Expression<Func<CoreCmsServices, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1,
            int pageSize = 20);
    }
}