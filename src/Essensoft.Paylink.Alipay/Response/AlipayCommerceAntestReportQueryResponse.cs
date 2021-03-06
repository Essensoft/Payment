﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAntestReportQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 测试报告页url
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
