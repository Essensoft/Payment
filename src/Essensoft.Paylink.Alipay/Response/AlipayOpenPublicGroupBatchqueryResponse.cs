﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicGroupBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicGroupBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户分组列表，包含每个分组的id、name、以及规则模型
        /// </summary>
        [JsonPropertyName("groups")]
        public List<QueryGroup> Groups { get; set; }
    }
}
