
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
    /// 微信小程序消息模板 接口实现
    /// </summary>
    public class CoreCmsUserWeChatMsgTemplateServices : BaseServices<CoreCmsUserWeChatMsgTemplate>, ICoreCmsUserWeChatMsgTemplateServices
    {
        private readonly ICoreCmsUserWeChatMsgTemplateRepository _dal;
        private readonly IUnitOfWork _unitOfWork;
        public CoreCmsUserWeChatMsgTemplateServices(IUnitOfWork unitOfWork, ICoreCmsUserWeChatMsgTemplateRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
            _unitOfWork = unitOfWork;
        }

    }
}
