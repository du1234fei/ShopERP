
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
    /// 单页内容 接口实现
    /// </summary>
    public class CoreCmsPagesItemsServices : BaseServices<CoreCmsPagesItems>, ICoreCmsPagesItemsServices
    {
        private readonly ICoreCmsPagesItemsRepository _dal;
        private readonly IUnitOfWork _unitOfWork;
        public CoreCmsPagesItemsServices(IUnitOfWork unitOfWork, ICoreCmsPagesItemsRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
            _unitOfWork = unitOfWork;
        }

    }
}
