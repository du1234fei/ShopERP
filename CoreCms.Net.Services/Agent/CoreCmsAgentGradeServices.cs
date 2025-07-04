
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CoreCms.Net.IRepository;
using CoreCms.Net.IRepository.UnitOfWork;
using CoreCms.Net.IServices;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.Basics;
using CoreCms.Net.Model.ViewModels.UI;
using SqlSugar;

namespace CoreCms.Net.Services
{
    /// <summary>
    ///     代理商等级设置表 接口实现
    /// </summary>
    public class CoreCmsAgentGradeServices : BaseServices<CoreCmsAgentGrade>, ICoreCmsAgentGradeServices
    {
        private readonly ICoreCmsAgentGradeRepository _dal;
        private readonly IUnitOfWork _unitOfWork;

        public CoreCmsAgentGradeServices(IUnitOfWork unitOfWork, ICoreCmsAgentGradeRepository dal)
        {
            _dal = dal;
            BaseDal = dal;
            _unitOfWork = unitOfWork;
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
        public new async Task<IPageList<CoreCmsAgentGrade>> QueryPageAsync(
            Expression<Func<CoreCmsAgentGrade, bool>> predicate,
            Expression<Func<CoreCmsAgentGrade, object>> orderByExpression, OrderByType orderByType, int pageIndex = 1,
            int pageSize = 20, bool blUseNoLock = false)
        {
            return await _dal.QueryPageAsync(predicate, orderByExpression, orderByType, pageIndex, pageSize,
                blUseNoLock);
        }

        #endregion

        #region 实现重写增删改查操作==========================================================

        /// <summary>
        ///     重写异步插入方法
        /// </summary>
        /// <param name="entity">实体数据</param>
        /// <returns></returns>
        public new async Task<AdminUiCallBack> InsertAsync(CoreCmsAgentGrade entity)
        {
            return await _dal.InsertAsync(entity);
        }

        /// <summary>
        ///     重写异步更新方法方法
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public new async Task<AdminUiCallBack> UpdateAsync(CoreCmsAgentGrade entity)
        {
            return await _dal.UpdateAsync(entity);
        }

        /// <summary>
        ///     重写异步更新方法方法
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public new async Task<AdminUiCallBack> UpdateAsync(List<CoreCmsAgentGrade> entity)
        {
            return await _dal.UpdateAsync(entity);
        }

        /// <summary>
        ///     重写删除指定ID的数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<AdminUiCallBack> DeleteByIdAsync(int id)
        {
            return await _dal.DeleteByIdAsync(id);
        }

        #endregion

        #region 获取缓存的所有数据==========================================================

        /// <summary>
        ///     获取缓存的所有数据
        /// </summary>
        /// <returns></returns>
        public async Task<List<CoreCmsAgentGrade>> GetCaChe()
        {
            return await _dal.GetCaChe();
        }

        /// <summary>
        ///     更新cache
        /// </summary>
        public async Task<List<CoreCmsAgentGrade>> UpdateCaChe()
        {
            return await _dal.UpdateCaChe();
        }

        #endregion
    }
}