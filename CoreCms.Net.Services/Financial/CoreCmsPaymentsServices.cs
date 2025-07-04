
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
    /// 支付方式表 接口实现
    /// </summary>
    public class CoreCmsPaymentsServices : BaseServices<CoreCmsPayments>, ICoreCmsPaymentsServices
    {
        private readonly ICoreCmsPaymentsRepository _dal;
        private readonly IUnitOfWork _unitOfWork;
        public CoreCmsPaymentsServices(IUnitOfWork unitOfWork, ICoreCmsPaymentsRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
            _unitOfWork = unitOfWork;
        }


    }
}
