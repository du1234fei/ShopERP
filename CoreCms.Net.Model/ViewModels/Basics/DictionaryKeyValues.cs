﻿

using System.ComponentModel.DataAnnotations;

namespace CoreCms.Net.Model.ViewModels.Basics
{
    /// <summary>
    ///     全局配置字典值内容
    /// </summary>
    public class DictionaryKeyValues
    {
        /// <summary>
        ///     key
        /// </summary>
        [Required(ErrorMessage = "key不能为空")]
        public string sKey { get; set; }

        /// <summary>
        ///     值
        /// </summary>
        public string sValue { get; set; }
    }


    /// <summary>
    ///     常用复用无条件匹配
    /// </summary>
    public class CommonKeyValues
    {
        /// <summary>
        ///     key
        /// </summary>
        [Required(ErrorMessage = "key不能为空")]
        public string sKey { get; set; }

        /// <summary>
        ///     值
        /// </summary>
        public string sValue { get; set; }


        /// <summary>
        ///     说明备注
        /// </summary>
        public string sDescription { get; set; }
    }
}