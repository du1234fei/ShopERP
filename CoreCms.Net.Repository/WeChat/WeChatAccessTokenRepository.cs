using CoreCms.Net.IRepository;
using CoreCms.Net.IRepository.UnitOfWork;
using CoreCms.Net.Model.Entities;

namespace CoreCms.Net.Repository
{
    /// <summary>
    ///     微信授权交互 接口实现
    /// </summary>
    public class WeChatAccessTokenRepository : BaseRepository<WeChatAccessToken>, IWeChatAccessTokenRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public WeChatAccessTokenRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}