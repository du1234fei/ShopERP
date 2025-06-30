
using CoreCms.Net.IRepository;
using CoreCms.Net.IRepository.UnitOfWork;
using CoreCms.Net.Model.Entities;

namespace CoreCms.Net.Repository
{
    /// <summary>
    ///     用户订阅提醒状态 接口实现
    /// </summary>
    public class CoreCmsUserWeChatMsgSubscriptionSwitchRepository :
        BaseRepository<CoreCmsUserWeChatMsgSubscriptionSwitch>, ICoreCmsUserWeChatMsgSubscriptionSwitchRepository
    {
        public CoreCmsUserWeChatMsgSubscriptionSwitchRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}