
using CoreCms.Net.IRepository;
using CoreCms.Net.IRepository.UnitOfWork;
using CoreCms.Net.Model.Entities;

namespace CoreCms.Net.Repository
{
    /// <summary>
    ///     微信小程序消息模板 接口实现
    /// </summary>
    public class CoreCmsUserWeChatMsgTemplateRepository : BaseRepository<CoreCmsUserWeChatMsgTemplate>,
        ICoreCmsUserWeChatMsgTemplateRepository
    {
        public CoreCmsUserWeChatMsgTemplateRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}