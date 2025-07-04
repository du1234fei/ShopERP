
using System;
using System.Threading.Tasks;
using CoreCms.Net.Configuration;
using CoreCms.Net.IRepository;
using CoreCms.Net.IRepository.UnitOfWork;
using CoreCms.Net.IServices;
using CoreCms.Net.Model.Entities;
using CoreCms.Net.Model.ViewModels.UI;


namespace CoreCms.Net.Services
{
    /// <summary>
    /// 商品会员价表 接口实现
    /// </summary>
    public class CoreCmsGoodsGradeServices : BaseServices<CoreCmsGoodsGrade>, ICoreCmsGoodsGradeServices
    {
        private readonly ICoreCmsGoodsGradeRepository _dal;
        private readonly IUnitOfWork _unitOfWork;
        public CoreCmsGoodsGradeServices(IUnitOfWork unitOfWork, ICoreCmsGoodsGradeRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
            _unitOfWork = unitOfWork;
        }


    }
}
