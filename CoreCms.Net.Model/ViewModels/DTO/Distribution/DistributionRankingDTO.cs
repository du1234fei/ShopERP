﻿
using System;

namespace CoreCms.Net.Model.ViewModels.DTO.Distribution
{
    public class DistributionRankingDTO
    {
        /// <summary>
        ///     分销商序列
        /// </summary>
        public int id { get; set; }


        /// <summary>
        ///     分销商昵称
        /// </summary>
        public string nickname { get; set; }

        /// <summary>
        ///     加入时间
        /// </summary>
        public DateTime createtime { get; set; }

        /// <summary>
        ///     累计收益
        /// </summary>
        public decimal totalInCome { get; set; }

        /// <summary>
        ///     订单数
        /// </summary>
        public decimal orderCount { get; set; }
    }
}