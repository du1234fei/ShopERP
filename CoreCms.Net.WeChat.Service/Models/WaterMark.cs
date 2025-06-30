using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreCms.Net.WeChat.Service.Utilities;

namespace CoreCms.Net.WeChat.Service.Models
{
    /// <summary>
    /// 水印
    /// </summary>
    [Serializable]
    public class Watermark
    {
        public string appid { get; set; }
        public long timestamp { get; set; }

        public DateTimeOffset DateTimeStamp
        {
            get { return DateTimeHelper.GetDateTimeFromXml(timestamp); }
        }
    }
}
