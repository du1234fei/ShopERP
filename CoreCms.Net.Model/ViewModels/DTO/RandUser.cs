﻿
using System;

namespace CoreCms.Net.Model.ViewModels.DTO
{
    /// <summary>
    ///     随机用户数据(用于首页返回购买用户随机数据)
    /// </summary>
    public class RandUser
    {
        public string avatar { get; set; }
        public string nickname { get; set; }
        public string createTime { get; set; }
        public string desc { get; set; }

        public DateTime dt { get; set; }
    }
}