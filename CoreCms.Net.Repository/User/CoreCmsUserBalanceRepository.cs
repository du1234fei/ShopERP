
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CoreCms.Net.IRepository;
using CoreCms.Net.IRepository.UnitOfWork;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.Basics;
using SqlSugar;

namespace CoreCms.Net.Repository
{
    /// <summary>
    ///     用户余额表 接口实现
    /// </summary>
    public class CoreCmsUserBalanceRepository : BaseRepository<CoreCmsUserBalance>, ICoreCmsUserBalanceRepository
    {
        public CoreCmsUserBalanceRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        #region 重写根据条件查询分页数据

        /// <summary>
        ///     重写根据条件查询分页数据
        /// </summary>
        /// <param name="predicate">判断集合</param>
        /// <param name="orderByType">排序方式</param>
        /// <param name="pageIndex">当前页面索引</param>
        /// <param name="pageSize">分布大小</param>
        /// <param name="orderByExpression"></param>
        /// <param name="blUseNoLock">是否使用WITH(NOLOCK)</param>
        /// <returns></returns>
        public new async Task<IPageList<CoreCmsUserBalance>> QueryPageAsync(
            Expression<Func<CoreCmsUserBalance, bool>> predicate,
            Expression<Func<CoreCmsUserBalance, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1,
            int pageSize = 20, bool blUseNoLock = false)
        {
            RefAsync<int> totalCount = 0;
            List<CoreCmsUserBalance> page;
            if (blUseNoLock)
                page = await DbClient.Queryable<CoreCmsUserBalance, CoreCmsUser>((p, sc) => new JoinQueryInfos(
                        JoinType.Left, p.userId == sc.id))
                    .Select((p, sc) => new CoreCmsUserBalance
                    {
                        id = p.id,
                        userId = p.userId,
                        type = p.type,
                        money = p.money,
                        balance = p.balance,
                        sourceId = p.sourceId,
                        memo = p.memo,
                        createTime = p.createTime,
                        userNickName = sc.nickName
                    })
                    .MergeTable()
                    .OrderByIF(orderByExpression != null, orderByExpression, orderByType)
                    .WhereIF(predicate != null, predicate)
                    .With(SqlWith.NoLock).ToPageListAsync(pageIndex, pageSize, totalCount);
            else
                page = await DbClient.Queryable<CoreCmsUserBalance, CoreCmsUser>((p, sc) => new JoinQueryInfos(
                        JoinType.Left, p.userId == sc.id))
                    .Select((p, sc) => new CoreCmsUserBalance
                    {
                        id = p.id,
                        userId = p.userId,
                        type = p.type,
                        money = p.money,
                        balance = p.balance,
                        sourceId = p.sourceId,
                        memo = p.memo,
                        createTime = p.createTime,
                        userNickName = sc.nickName
                    })
                    .MergeTable()
                    .OrderByIF(orderByExpression != null, orderByExpression, orderByType)
                    .WhereIF(predicate != null, predicate)
                    .ToPageListAsync(pageIndex, pageSize, totalCount);
            var list = new PageList<CoreCmsUserBalance>(page, pageIndex, pageSize, totalCount);
            return list;
        }

        #endregion
    }
}