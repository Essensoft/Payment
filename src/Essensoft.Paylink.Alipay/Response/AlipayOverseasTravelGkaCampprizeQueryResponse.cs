﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelGkaCampprizeQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelGkaCampprizeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品信息列表，一定不为null，但是size可以为0
        /// </summary>
        [JsonPropertyName("prizes")]
        public List<PrizeInfo> Prizes { get; set; }
    }
}
