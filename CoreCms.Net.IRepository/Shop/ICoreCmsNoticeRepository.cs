
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.Basics;
using SqlSugar;

namespace CoreCms.Net.IRepository
{
    /// <summary>
    ///     公告表 工厂接口
    /// </summary>
    public interface ICoreCmsNoticeRepository : IBaseRepository<CoreCmsNotice>
    {
        /// <summary>
        ///     重写根据条件查询分页数据
        /// </summary>
        /// <param name="predicate">判断集合</param>
        /// <param name="orderByType">排序方式</param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="orderByExpression"></param>
        /// <returns></returns>
        Task<IPageList<CoreCmsNotice>> QueryPageAsync(Expression<Func<CoreCmsNotice, bool>> predicate,
            Expression<Func<CoreCmsNotice, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1,
            int pageSize = 20);


        /// <summary>
        ///     获取列表首页用
        /// </summary>
        /// <param name="predicate">判断集合</param>
        /// <param name="orderByType">排序方式</param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="orderByExpression"></param>
        /// <returns></returns>
        Task<List<CoreCmsNotice>> QueryListAsync(Expression<Func<CoreCmsNotice, bool>> predicate,
            Expression<Func<CoreCmsNotice, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1,
            int pageSize = 20);
    }
}