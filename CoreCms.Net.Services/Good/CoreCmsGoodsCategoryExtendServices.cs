
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
    /// 商品分类扩展表 接口实现
    /// </summary>
    public class CoreCmsGoodsCategoryExtendServices : BaseServices<CoreCmsGoodsCategoryExtend>, ICoreCmsGoodsCategoryExtendServices
    {
        private readonly ICoreCmsGoodsCategoryExtendRepository _dal;
        private readonly IUnitOfWork _unitOfWork;
        public CoreCmsGoodsCategoryExtendServices(IUnitOfWork unitOfWork, ICoreCmsGoodsCategoryExtendRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
            _unitOfWork = unitOfWork;
        }


    }
}
