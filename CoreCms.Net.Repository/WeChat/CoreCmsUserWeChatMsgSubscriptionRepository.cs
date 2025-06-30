
using CoreCms.Net.IRepository;
using CoreCms.Net.IRepository.UnitOfWork;
using CoreCms.Net.Model.Entities;

namespace CoreCms.Net.Repository
{
    /// <summary>
    ///     微信订阅消息存储表 接口实现
    /// </summary>
    public class CoreCmsUserWeChatMsgSubscriptionRepository : BaseRepository<CoreCmsUserWeChatMsgSubscription>,
        ICoreCmsUserWeChatMsgSubscriptionRepository
    {
        public CoreCmsUserWeChatMsgSubscriptionRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}