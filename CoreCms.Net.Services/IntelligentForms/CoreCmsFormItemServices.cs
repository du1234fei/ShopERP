
using CoreCms.Net.IRepository;
using CoreCms.Net.IRepository.UnitOfWork;
using CoreCms.Net.IServices;
using CoreCms.Net.Model.Entities;

namespace CoreCms.Net.Services
{
    /// <summary>
    ///     表单项表 接口实现
    /// </summary>
    public class CoreCmsFormItemServices : BaseServices<CoreCmsFormItem>, ICoreCmsFormItemServices
    {
        private readonly ICoreCmsFormItemRepository _dal;
        private readonly IUnitOfWork _unitOfWork;

        public CoreCmsFormItemServices(IUnitOfWork unitOfWork, ICoreCmsFormItemRepository dal)
        {
            _dal = dal;
            BaseDal = dal;
            _unitOfWork = unitOfWork;
        }
    }
}