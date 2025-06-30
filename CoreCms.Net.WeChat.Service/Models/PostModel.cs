using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCms.Net.WeChat.Service.Models
{
    /// <summary>
    /// 微信公众服务器Post过来的加密参数集合（不包括PostData）
    /// <para>如需使用 NeuChar，需要在 MessageHandler 中提供 PostModel 并设置 AppId</para>
    /// </summary>
    public class PostModel : EncryptPostModel
    {
        public override string DomainId
        {
            get => this.AppId;
            set => this.AppId = value;
        }

        public string AppId { get; set; }

        /// <summary>设置服务器内部保密信息</summary>
        /// <param name="token"></param>
        /// <param name="encodingAESKey"></param>
        /// <param name="appId"></param>
        public void SetSecretInfo(string token, string encodingAESKey, string appId)
        {
            this.Token = token;
            this.EncodingAESKey = encodingAESKey;
            this.AppId = appId;
        }
    }
}
