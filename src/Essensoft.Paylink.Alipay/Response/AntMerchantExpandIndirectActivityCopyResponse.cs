﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityCopyResponse.
    /// </summary>
    public class AntMerchantExpandIndirectActivityCopyResponse : AlipayResponse
    {
        /// <summary>
        /// 活动权益复制结果
        /// </summary>
        [JsonPropertyName("copy_result")]
        public List<ActivityCopyResult> CopyResult { get; set; }
    }
}
