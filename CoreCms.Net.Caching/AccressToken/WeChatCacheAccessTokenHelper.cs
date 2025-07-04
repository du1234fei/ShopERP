﻿using System.Threading.Tasks;
using CoreCms.Net.Caching.Manual;
using CoreCms.Net.Configuration;
using CoreCms.Net.Model.Entities;

namespace CoreCms.Net.Caching.AccressToken
{
    /// <summary>
    /// 微信帮助类
    /// </summary>
    public static class WeChatCacheAccessTokenHelper
    {
        /// <summary>
        /// 获取微信小程序accessToken
        /// </summary>
        /// <returns></returns>
        public static string GetWxOpenAccessToken()
        {
            //获取小程序AccessToken
            var cacheAccessToken = ManualDataCache.Instance.Get<WeChatAccessToken>(GlobalEnumVars.AccessTokenEnum.WxOpenAccessToken.ToString());
            return cacheAccessToken?.accessToken;
        }

        /// <summary>
        /// 获取微信公众号accessToken
        /// </summary>
        /// <returns></returns>
        public static string GetWeChatAccessToken()
        {
            //获取微信AccessToken
            var cacheAccessToken = ManualDataCache.Instance.Get<WeChatAccessToken>(GlobalEnumVars.AccessTokenEnum.WeiXinAccessToken.ToString());
            return cacheAccessToken?.accessToken;
        }

    }
}
